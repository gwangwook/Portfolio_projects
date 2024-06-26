#pragma once

#include<iostream>

class House
{
protected:
	char adress[50];
	char location[30];            // ���� ������, ���� ������, ���θ� 3��������
	char kind[20];   // ���� ���� ���� : ����Ʈ, ����, ���ǽ���, ����
	//       �׷� �׳� ���� ���� �ŸŸ� �ް� �ϳ��� �����ؼ� �ϴ� ������    
	// 1. ����, 2. ����, 3. �Ÿ� -> price = (1 or 2 or 3�� ������ ��)

	int year_price;                     // ���� ����
	int monthly_price;                     // ���� ����
	int trade_price;                     // �Ÿ� ����
	int zone_size;               // ���
	int room_number;            // �� ����

public:
	int residence_type[3] = { 0 }; // ���� ����(����, ����, �Ÿ�)
	bool in_live;                  // ���� ���� �Ǵ�

	//House();   // �Ű����� ���� ������ (����)
	//House(const char* residence_type, const char* location);   // �Ű����� �ִ� ������
	//House(const char* residence_type, const char* location, int price, int zone_size, int room_number);

	//void set_Houseinfo(int residence_type, const char* location, int price, int zone_size, int room_number);   // �ѹ��� �Ҵ� �ޱ�

	void set_adress(const char* adress);
	void set_residence_type(const char* input_type);   //set ����
	void set_location(const char* location);
	void set_kind(const char* kind);
	void set_year_price(int year_price);
	void set_monthly_price(int monthly_price);
	void set_trade_price(int trade_price);
	void set_zone_size(int zone_size);
	void set_room_number(int room_number);
	//get ����
	const char* get_adress();
	const char* get_location();
	const char* get_kind();
	int get_year_price();
	int get_monthly_price();
	int get_trade_price();
	int get_zone_size();
	int get_room_number();
};


class Alone_House : public House      // �ܵ� ���� (�ڽ� Ŭ���� 1)
{
public:
	bool garden;      // ����(����) ����

};

// �޼��� �ۼ� �� ���� ���� �ּ�ó���� ����

class All_House : public House      // ���� ���� (�ڽ� Ŭ���� 2)
{
protected:
	char apart_name[50];
	bool parking;   // ������ ����
	char community_space[30];   // Ŀ�´�Ƽ ����(������, �ｺ��, �����繫��, ���)

public:
	// All_House();
	// All_House(const char* residence_type, const char* location, int price, int zone_size, int room_number);

	// void set_house_all(const char* residence_type, const char* location, int price, int zone_size, int room_number);

	void set_apart_name(const char* apart_name);
	void set_community_space(const char* community_space);

	const char* get_apart_name();
	const char* get_community_space();
};