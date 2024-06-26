import numpy as np
import cv2
from keras.models import load_model
from keras import backend as K
from tensorflow import keras
import handwritten_reco3 as hr
from keras.layers import (
    Input,
    Conv2D,
    MaxPooling2D,
    Reshape,
    Bidirectional,
    LSTM,
    Dense,
    Lambda,
    Activation,
    BatchNormalization,
    Dropout,
    Flatten,
)

# Predefined character set
alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-' "
num_of_characters = len(alphabet) + 1  # +1 for ctc pseudo blank
max_str_len = 24  # max length of input labels
labels = Input(name="gtruth_labels", shape=[max_str_len], dtype="float32")
input_length = Input(name="input_length", shape=[1], dtype="int64")
label_length = Input(name="label_length", shape=[1], dtype="int64")

# Model define
input_data = Input(shape=(256, 64, 1), name="input")

inner = Conv2D(
    32, (3, 3), padding="same", name="conv1", kernel_initializer="he_normal"
)(input_data)
inner = BatchNormalization()(inner)
inner = Activation("relu")(inner)
inner = MaxPooling2D(pool_size=(2, 2), name="max1")(inner)

inner = Conv2D(
    64, (3, 3), padding="same", name="conv2", kernel_initializer="he_normal"
)(inner)
inner = BatchNormalization()(inner)
inner = Activation("relu")(inner)
inner = MaxPooling2D(pool_size=(2, 2), name="max2")(inner)
inner = Dropout(0.3)(inner)

inner = Conv2D(
    128, (3, 3), padding="same", name="conv3", kernel_initializer="he_normal"
)(inner)
inner = BatchNormalization()(inner)
inner = Activation("relu")(inner)
inner = MaxPooling2D(pool_size=(1, 2), name="max3")(inner)
inner = Dropout(0.3)(inner)

# CNN to RNN
inner = Reshape(target_shape=((64, 1024)), name="reshape")(inner)
inner = Dense(64, activation="relu", kernel_initializer="he_normal", name="dense1")(
    inner
)

## RNN
inner = Bidirectional(LSTM(256, return_sequences=True), name="lstm1")(inner)
inner = Bidirectional(LSTM(256, return_sequences=True), name="lstm2")(inner)

## OUTPUT
inner = Dense(num_of_characters, kernel_initializer="he_normal", name="dense2")(inner)
y_pred = Activation("softmax", name="softmax")(inner)


# Lambda 함수 대신 사용할 함수 정의
def ctc_lambda_func(y_true, y_pred):
    return y_pred


def ctc_lambda_func(args):
    y_pred, labels, input_length, label_length = args
    # the 2 is critical here since the first couple outputs of the RNN
    # tend to be garbage
    y_pred = y_pred[:, 2:, :]
    return K.ctc_batch_cost(labels, y_pred, input_length, label_length)


# Function to map numbers to characters
def num_to_label(num_list):
    # Convert numer list to a string
    return "".join([alphabet[i] for i in num_list if i < len(alphabet) and i >= 0])


# Function for image preprocessing
def preprocess(img, img_size=(256, 64)):
    (h, w) = img.shape
    final_img = np.ones([64, 256]) * 255  # Background color

    # Adjusting the image size without changing its aspect ratio
    if w > 256:
        img = img[:, :256]
    if h > 64:
        img = img[:64, :]

    final_img[:h, :w] = img
    final_img = cv2.rotate(final_img, cv2.ROTATE_90_CLOCKWISE)
    return final_img / 255.0


################################## 여서부터 메인 ####################################
model = keras.models.load_model(
    "best_model_handwritten2.keras",
    custom_objects={"ctc_lambda_func": ctc_lambda_func},
)


# Function for character extraction from images
def predict_from_image(img_path):
    # Load and preprocess the image
    image = cv2.imread(img_path, cv2.IMREAD_GRAYSCALE)
    processed_image = preprocess(image)
    processed_image = processed_image.reshape(1, 256, 64, 1)

    # Predict
    pred = model.predict(processed_image)
    input_len = np.ones(pred.shape[0]) * pred.shape[1]

    # Decode the raw prediction
    results = K.ctc_decode(pred, input_length=input_len, greedy=True)[0][0].numpy()

    # Remove blanks and convert to text
    cleaned_results = [r for r in results if r != -1]
    output_text = num_to_label(cleaned_results)

    return output_text


# Change 'your_image_path_here' to the path of the image you want to predict
print(predict_from_image("test.jpg"))
