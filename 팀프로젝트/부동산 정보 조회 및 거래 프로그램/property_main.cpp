#include <iostream>
#include <time.h>
#include <stdlib.h>
#include <string>
#include <algorithm>
#include "property_head.h"
#include <vector>
#include <windows.h>
#include <fstream>
using namespace std;

int num = 0; // ���� case���� ���� ����
int choice = 0;
char filename[] = "transaction.txt";
int shot;

vector<Alone_House> alone_house_vc;
vector<All_House> all_house_vc;
vector<Alone_House> alone_house_vc2;
vector<All_House> all_house_vc2;
void Set_All_House()
{
    // 1��° �Ź� (�Ÿ� ����Ʈ)
    All_House new_all_apart1;
    new_all_apart1.set_trade_price(4);   // �� > cout���� ���� ���̱�
    new_all_apart1.set_location("���� ������");   // �����ǵ�
    new_all_apart1.set_zone_size(40); //�� > cout���� �� ���̱�
    new_all_apart1.set_room_number(4);   // �� ����
    new_all_apart1.set_kind("����Ʈ");   // �ǹ� ����
    new_all_apart1.set_community_space("�ｺ��");
    new_all_apart1.set_apart_name("e���Ѽ���");
    new_all_apart1.set_adress("õ�Ƚ� �źε�");
    new_all_apart1.in_live = true;
    new_all_apart1.residence_type[2] = 1;

    all_house_vc.push_back(new_all_apart1);

    // 2��° �Ź� (�Ÿ� ����Ʈ)
    All_House new_all_apart2;
    new_all_apart2.set_trade_price(5);   // �� > cout���� ���� ���̱�
    new_all_apart2.set_location("���� ������");   // �����ǵ�
    new_all_apart2.set_zone_size(45); //�� > cout���� �� ���̱�
    new_all_apart2.set_room_number(5);   // �� ����
    new_all_apart2.set_kind("����Ʈ");   // �ǹ� ����
    new_all_apart2.set_community_space("������, �ｺ��");
    new_all_apart2.set_apart_name("Ǫ������");
    new_all_apart2.set_adress("õ�Ƚ� ���ﵿ");
    new_all_apart2.in_live = false;
    new_all_apart2.residence_type[2] = 1;

    all_house_vc.push_back(new_all_apart2);

    // 3��° �Ź� (�Ÿ� ����Ʈ)
    All_House new_all_apart3;
    new_all_apart3.set_trade_price(5);   // �� > cout���� ���� ���̱�
    new_all_apart3.set_location("���θ�");   // �����ǵ�
    new_all_apart3.set_zone_size(34); //�� > cout���� �� ���̱�
    new_all_apart3.set_room_number(3);   // �� ����
    new_all_apart3.set_kind("����Ʈ");   // �ǹ� ����
    new_all_apart3.set_community_space("������");
    new_all_apart3.set_apart_name("�״밡����Ʈ");
    new_all_apart3.set_adress("�ȼ��� ������");
    new_all_apart3.in_live = true;
    new_all_apart3.residence_type[2] = 1;

    all_house_vc.push_back(new_all_apart3);

    // 4��° �Ź� (���� ����)
    All_House new_all_apart4;
    new_all_apart4.set_monthly_price(45);   // ���� > cout���� ���� ���̱�
    new_all_apart4.set_location("���θ�");   // �����ǵ�
    new_all_apart4.set_zone_size(8); //�� > cout���� �� ���̱�
    new_all_apart4.set_room_number(0);   // �� ����
    new_all_apart4.set_kind("����");   // �ǹ� ����
    new_all_apart4.set_community_space("������");
    new_all_apart4.set_apart_name("�帲Ÿ��");
    new_all_apart4.set_adress("�ƻ�� ���⸮");
    new_all_apart4.in_live = false;
    new_all_apart4.residence_type[1] = 1;

    all_house_vc.push_back(new_all_apart4);

    // 5��° �Ź� (���� ����)
    All_House new_all_apart5;
    new_all_apart5.set_monthly_price(60);   // ���� > cout���� ���� ���̱�
    new_all_apart5.set_location("������");   // �����ǵ�
    new_all_apart5.set_zone_size(13); //�� > cout���� �� ���̱�
    new_all_apart5.set_room_number(0);   // �� ����
    new_all_apart5.set_kind("����");   // �ǹ� ����
    new_all_apart5.set_community_space("������");
    new_all_apart5.set_apart_name("��Ÿ������ 10��");
    new_all_apart5.set_adress("õ�Ƚ� ���ﵿ");
    new_all_apart5.in_live = true;
    new_all_apart5.residence_type[1] = 1;

    all_house_vc.push_back(new_all_apart5);

    // 6��° �Ź� (���� ���ǽ���)
    All_House new_all_apart6;
    new_all_apart6.set_year_price(1);   // �� > cout���� ���� ���̱�
    new_all_apart6.set_location("������");   // �����ǵ�
    new_all_apart6.set_zone_size(13); //�� > cout���� �� ���̱�
    new_all_apart6.set_room_number(1);   // �� ����
    new_all_apart6.set_kind("���ǽ���");   // �ǹ� ����
    new_all_apart6.set_community_space("������");
    new_all_apart6.set_apart_name("�ñ״Ͽ�");
    new_all_apart6.set_adress("õ�Ƚ� ������");
    new_all_apart6.in_live = true;
    new_all_apart6.residence_type[0] = 1;

    all_house_vc.push_back(new_all_apart6);


    // 7��° �Ź� (���� ����Ʈ)
    All_House new_all_apart7;
    new_all_apart7.set_year_price(3);   // �� > cout���� ���� ���̱�
    new_all_apart7.set_location("���� ������");   // �����ǵ�
    new_all_apart7.set_zone_size(36); //�� > cout���� �� ���̱�
    new_all_apart7.set_room_number(3);   // �� ����
    new_all_apart7.set_kind("����Ʈ");   // �ǹ� ����
    new_all_apart7.set_community_space("������, ������, �ｺ��");
    new_all_apart7.set_apart_name("�븲�ѽ�");
    new_all_apart7.set_adress("õ�Ƚ� �źε�");
    new_all_apart7.in_live = false;
    new_all_apart7.residence_type[0] = 1;

    all_house_vc.push_back(new_all_apart7);

    // 8�� �Ź� (����)
    Alone_House new_alone_housing1;
    new_alone_housing1.set_trade_price(7); // ��
    new_alone_housing1.set_location("���θ�");
    new_alone_housing1.set_zone_size(70); // ��
    new_alone_housing1.set_room_number(4);
    new_alone_housing1.set_kind("����");
    new_alone_housing1.set_adress("�ƻ�� ������");
    new_alone_housing1.in_live = true;
    new_alone_housing1.residence_type[2] = 1;
    new_alone_housing1.garden = true;

    alone_house_vc.push_back(new_alone_housing1);

    // 9�� �Ź� (����)
    Alone_House new_alone_housing2;
    new_alone_housing2.set_trade_price(12); // ��
    new_alone_housing2.set_location("������");
    new_alone_housing2.set_zone_size(65); // ��
    new_alone_housing2.set_room_number(4);
    new_alone_housing2.set_kind("����");
    new_alone_housing2.set_adress("õ�Ƚ� ������");
    new_alone_housing2.in_live = false;
    new_alone_housing2.residence_type[2] = 1;

    alone_house_vc.push_back(new_alone_housing2);

    // 10�� �Ź� (����)
    Alone_House new_alone_housing3;
    new_alone_housing3.set_trade_price(10); // ��
    new_alone_housing3.set_location("���� ������");
    new_alone_housing3.set_zone_size(75); // ��
    new_alone_housing3.set_room_number(5);
    new_alone_housing3.set_kind("����");
    new_alone_housing3.set_adress("õ�Ƚ� �δ뵿");
    new_alone_housing3.in_live = true;
    new_alone_housing3.residence_type[2] = 1;

    alone_house_vc.push_back(new_alone_housing3);
}

void show_AllHouse()
{
    int i = 0, j = 0, x = 0, y = 0;
    cout << "��� �Ź��� �����帮�ڽ��ϴ�." << endl << endl;
    for (i = 0; i < all_house_vc.size(); i++)
    {
        cout << "[" << i + 1 << "��° �Ź� ����]" << endl;

        if (all_house_vc.at(i).in_live == true)
        {
            cout << "(�� �� �ִ� �Ź��Դϴ�!)" << endl;
        }
        else { cout << "(�̹� �ȸ� �Ź��Դϴ�!)" << endl; }

        cout << "�ǹ� �̸� : " << all_house_vc.at(i).get_apart_name() << endl;
        cout << "���� : " << all_house_vc.at(i).get_kind() << endl;
        cout << "�ּ� : " << all_house_vc.at(i).get_adress() << endl;
        cout << "��ġ : " << all_house_vc.at(i).get_location() << endl;
        cout << "��� : " << all_house_vc.at(i).get_zone_size() << endl;
        cout << "�� ���� : " << all_house_vc.at(i).get_room_number() << endl;
        cout << "�����ü� : " << all_house_vc.at(i).get_community_space() << endl;
        if (all_house_vc.at(i).residence_type[0] == 1)
        {
            cout << "���� ���� / ������ : " << all_house_vc.at(i).get_year_price() << "���" << endl;
        }
        if (all_house_vc.at(i).residence_type[1] == 1)
        {
            cout << "���� ���� / ������ : " << all_house_vc.at(i).get_monthly_price() << "����" << endl;
        }
        if (all_house_vc.at(i).residence_type[2] == 1)
        {
            cout << "�Ÿ� ���� / �ŸŰ� : " << all_house_vc.at(i).get_trade_price() << "���" << endl;
        }
        cout << endl << endl;
    }

    for (x = 0; x < all_house_vc2.size(); x++, i++)
    {
        cout << "[" << i + 1 << "��° �Ź� ����]" << endl;

        if (all_house_vc2.at(x).in_live == true)
        {
            cout << "(�� �� �ִ� �Ź��Դϴ�!)" << endl;
        }
        else { cout << "(�̹� �ȸ� �Ź��Դϴ�!)" << endl; }

        cout << "�ǹ� �̸� : " << all_house_vc2.at(x).get_apart_name() << endl;
        cout << "���� : " << all_house_vc2.at(x).get_kind() << endl;
        cout << "�ּ� : " << all_house_vc2.at(x).get_adress() << endl;
        cout << "��ġ : " << all_house_vc2.at(x).get_location() << endl;
        cout << "��� : " << all_house_vc2.at(x).get_zone_size() << endl;
        cout << "�� ���� : " << all_house_vc2.at(x).get_room_number() << endl;
        cout << "�����ü� : " << all_house_vc2.at(x).get_community_space() << endl;
        if (all_house_vc2.at(x).residence_type[0] == 1)
        {
            cout << "���� ���� / ������ : " << all_house_vc2.at(x).get_year_price() << "���" << endl;
        }
        if (all_house_vc2.at(x).residence_type[1] == 1)
        {
            cout << "���� ���� / ������ : " << all_house_vc2.at(x).get_monthly_price() << "����" << endl;
        }
        if (all_house_vc2.at(x).residence_type[2] == 1)
        {
            cout << "�Ÿ� ���� / �ŸŰ� : " << all_house_vc2.at(x).get_trade_price() << "���" << endl;
        }
        cout << endl << endl;
    }

    for (j = 0; j < alone_house_vc.size(); j++, i++)
    {
        cout << "[" << i + 1 << "��° �Ź� ����]" << endl;

        if (alone_house_vc.at(j).in_live == true)
        {
            cout << "(�� �� �ִ� �Ź��Դϴ�!)" << endl;
        }
        else { cout << "(�̹� �ȸ� �Ź��Դϴ�!)" << endl; }

        cout << "����    : " << alone_house_vc.at(j).get_kind() << endl;
        cout << "�ּ�    : " << alone_house_vc.at(j).get_adress() << endl;
        cout << "��ġ    : " << alone_house_vc.at(j).get_location() << endl;
        cout << "���    : " << alone_house_vc.at(j).get_zone_size() << endl;
        cout << "�� ���� : " << alone_house_vc.at(j).get_room_number() << endl;
        cout << "�ŸŰ�  : " << alone_house_vc.at(j).get_trade_price() << "���" << "\n\n" << endl;
    }

    for (y = 0; y < alone_house_vc2.size(); y++, i++)
    {
        cout << "[" << i + 1 << "��° �Ź� ����]" << endl;

        if (alone_house_vc2.at(y).in_live == true)
        {
            cout << "(�� �� �ִ� �Ź��Դϴ�!)" << endl;
        }
        else { cout << "(�̹� �ȸ� �Ź��Դϴ�!)" << endl; }

        cout << "����    : " << alone_house_vc2.at(y).get_kind() << endl;
        cout << "�ּ�    : " << alone_house_vc2.at(y).get_adress() << endl;
        cout << "��ġ    : " << alone_house_vc2.at(y).get_location() << endl;
        cout << "���    : " << alone_house_vc2.at(y).get_zone_size() << endl;
        cout << "�� ���� : " << alone_house_vc2.at(y).get_room_number() << endl;
        cout << "�ŸŰ�  : " << alone_house_vc2.at(y).get_trade_price() << "���" << "\n\n" << endl;
    }
}




// 2�� ���� ����

void true_purchase()
{
    system("cls");
    int i = 0, j = 0;
    if (all_house_vc.at(0).in_live == true)
    {
        cout << "< 1�� �Ź�(���� ���� �Ź�) >" << endl;
        cout << "����Ʈ �̸� : " << all_house_vc.at(0).get_apart_name() << endl;
        cout << "�ְ��� ���� : " << all_house_vc.at(0).get_kind() << endl;
        cout << "�ּ� : " << all_house_vc.at(0).get_adress() << endl;
        cout << "��ġ : " << all_house_vc.at(0).get_location() << endl;
        cout << "��� : " << all_house_vc.at(0).get_zone_size() << "��" << endl;
        cout << "�� ���� : " << all_house_vc.at(0).get_room_number() << "��" << endl;
        cout << "���� �ü� : " << all_house_vc.at(0).get_community_space() << endl;
        cout << "�ŸŰ� : " << all_house_vc.at(0).get_trade_price() << "��" << endl;
        cout << endl;
    }

    if (all_house_vc.at(2).in_live == true)
    {
        cout << "< 2�� �Ź�(���� ���� �Ź�) >" << endl;
        cout << "����Ʈ �̸� : " << all_house_vc.at(2).get_apart_name() << endl;
        cout << "�ְ��� ���� : " << all_house_vc.at(2).get_kind() << endl;
        cout << "�ּ� : " << all_house_vc.at(2).get_adress() << endl;
        cout << "��ġ : " << all_house_vc.at(2).get_location() << endl;
        cout << "��� : " << all_house_vc.at(2).get_zone_size() << "��" << endl;
        cout << "�� ���� : " << all_house_vc.at(2).get_room_number() << "��" << endl;
        cout << "���� �ü� : " << all_house_vc.at(2).get_community_space() << endl;
        cout << "�ŸŰ� : " << all_house_vc.at(2).get_trade_price() << "��" << endl;
        cout << endl;
    }

    if (all_house_vc.at(4).in_live == true)
    {
        cout << "< 3�� �Ź�(���� ���� �Ź�) >" << endl;
        cout << "���ǽ��� �̸� : " << all_house_vc.at(4).get_apart_name() << endl;
        cout << "�ְ��� ���� : " << all_house_vc.at(4).get_kind() << endl;
        cout << "�ּ� : " << all_house_vc.at(4).get_adress() << endl;
        cout << "��ġ : " << all_house_vc.at(4).get_location() << endl;
        cout << "��� : " << all_house_vc.at(4).get_zone_size() << "��" << endl;
        cout << "�� ���� : " << all_house_vc.at(4).get_room_number() << "��" << endl;
        cout << "���� �ü� : " << all_house_vc.at(4).get_community_space() << endl;
        cout << "������ : " << all_house_vc.at(4).get_monthly_price() << "����" << endl;
        cout << endl;
    }

    if (all_house_vc.at(5).in_live == true)
    {
        cout << "< 4�� �Ź�(���� ���� �Ź�) >" << endl;
        cout << "����Ʈ �̸� : " << all_house_vc.at(5).get_apart_name() << endl;
        cout << "�ְ��� ���� : " << all_house_vc.at(5).get_kind() << endl;
        cout << "�ּ� : " << all_house_vc.at(5).get_adress() << endl;
        cout << "��ġ : " << all_house_vc.at(5).get_location() << endl;
        cout << "��� : " << all_house_vc.at(5).get_zone_size() << "��" << endl;
        cout << "�� ���� : " << all_house_vc.at(5).get_room_number() << "��" << endl;
        cout << "���� �ü� : " << all_house_vc.at(5).get_community_space() << endl;
        cout << "������ : " << all_house_vc.at(5).get_year_price() << "��" << endl;
        cout << endl;
    }

    if (alone_house_vc.at(0).in_live == true)
    {
        cout << "< 5�� �Ź�(���� ���� �Ź�) >" << endl;
        cout << "�ְ��� ���� : " << alone_house_vc.at(0).get_kind() << endl;
        cout << "�ּ� : " << alone_house_vc.at(0).get_adress() << endl;
        cout << "��ġ : " << alone_house_vc.at(0).get_location() << endl;
        cout << "��� : " << alone_house_vc.at(0).get_zone_size() << "��" << endl;
        cout << "�� ���� : " << alone_house_vc.at(0).get_room_number() << "��" << endl;
        cout << "�ŸŰ� : " << alone_house_vc.at(0).get_trade_price() << "��" << endl;
        cout << endl;
    }

    if (alone_house_vc.at(2).in_live == true)
    {
        cout << "< 6�� �Ź�(���� ���� �Ź�) >" << endl;
        cout << "�ְ��� ���� : " << alone_house_vc.at(2).get_kind() << endl;
        cout << "�ּ� : " << alone_house_vc.at(2).get_adress() << endl;
        cout << "��ġ : " << alone_house_vc.at(2).get_location() << endl;
        cout << "��� : " << alone_house_vc.at(2).get_zone_size() << "��" << endl;
        cout << "�� ���� : " << alone_house_vc.at(2).get_room_number() << "��" << endl;
        cout << "�ŸŰ� : " << alone_house_vc.at(2).get_trade_price() << "��" << endl;
        cout << endl;
    }

    for (i = 0; i < all_house_vc2.size(); i++)
    {
        cout << "< " << i + 7 << "�� �Ź�(���� ���� �Ź�) >" << endl;
        cout << "�ְ��� ���� : " << all_house_vc2.at(i).get_kind() << endl;
        cout << "�ּ� : " << all_house_vc2.at(i).get_adress() << endl;
        cout << "��ġ : " << all_house_vc2.at(i).get_location() << endl;
        cout << "��� : " << all_house_vc2.at(i).get_zone_size() << "��" << endl;
        cout << "�� ���� : " << all_house_vc2.at(i).get_room_number() << "��" << endl;
        if (all_house_vc2.at(i).residence_type[0] == 1)
            cout << "������ : " << all_house_vc2.at(i).get_year_price() << "��" << endl;
        if (all_house_vc2.at(i).residence_type[1] == 1)
            cout << "������ : " << all_house_vc2.at(i).get_monthly_price() << "��" << endl;
        if (all_house_vc2.at(i).residence_type[1] == 1)
            cout << "�ŸŰ� : " << all_house_vc2.at(i).get_trade_price() << "��" << endl;
        cout << endl;
    }
    for (j = 0; j < alone_house_vc2.size(); j++, i++)
    {
        cout << "< " << i + 7 << "�� �Ź�(���� ���� �Ź�) >" << endl;
        cout << "�ְ��� ���� : " << alone_house_vc2.at(j).get_kind() << endl;
        cout << "�ּ� : " << alone_house_vc2.at(j).get_adress() << endl;
        cout << "��ġ : " << alone_house_vc2.at(j).get_location() << endl;
        cout << "��� : " << alone_house_vc2.at(j).get_zone_size() << "��" << endl;
        cout << "�� ���� : " << alone_house_vc2.at(j).get_room_number() << "��" << endl;
        cout << "�ŸŰ� : " << alone_house_vc2.at(j).get_trade_price() << "��" << endl;
        cout << endl;
    }
}

int sold_choice()
{
    true_purchase();
    cout << "������ �Ź��� �����Ͻÿ�." << endl;
    cin >> choice;
    Sleep(500);
    system("cls");

    return choice;
}

void sold(int choice)
{
    
    switch (choice)
    {
    case 1:   // �Ÿ� �Ź�
        if (all_house_vc.at(0).in_live == true)
        {
            cout << "����Ʈ �̸� : " << all_house_vc.at(0).get_apart_name() << endl;
            cout << "�ְ��� ���� : " << all_house_vc.at(0).get_kind() << endl;
            cout << "�ּ� : " << all_house_vc.at(0).get_adress() << endl;
            cout << "��ġ : " << all_house_vc.at(0).get_location() << endl;
            cout << "��� : " << all_house_vc.at(0).get_zone_size() << "��" << endl;
            cout << "�� ���� : " << all_house_vc.at(0).get_room_number() << "��" << endl;
            cout << "���� �ü� : " << all_house_vc.at(0).get_community_space() << endl;
            cout << "�ŸŰ� : " << all_house_vc.at(0).get_trade_price() << "��" << endl;
            cout << endl;
            num = 1;
        }
        break;

    case 2: // �Ÿ� �Ź�
        if (all_house_vc.at(2).in_live == true)
        {
            cout << "����Ʈ �̸� : " << all_house_vc.at(2).get_apart_name() << endl;
            cout << "�ְ��� ���� : " << all_house_vc.at(2).get_kind() << endl;
            cout << "�ּ� : " << all_house_vc.at(2).get_adress() << endl;
            cout << "��ġ : " << all_house_vc.at(2).get_location() << endl;
            cout << "��� : " << all_house_vc.at(2).get_zone_size() << "��" << endl;
            cout << "�� ���� : " << all_house_vc.at(2).get_room_number() << "��" << endl;
            cout << "���� �ü� : " << all_house_vc.at(2).get_community_space() << endl;
            cout << "�ŸŰ� : " << all_house_vc.at(2).get_trade_price() << "��" << endl;
            cout << endl;
            num = 2;
        }
        break;

    case 3: // ���� �Ź�
        if (all_house_vc.at(4).in_live == true)
        {
            cout << "���ǽ��� �̸� : " << all_house_vc.at(4).get_apart_name() << endl;
            cout << "�ְ��� ���� : " << all_house_vc.at(4).get_kind() << endl;
            cout << "�ּ� : " << all_house_vc.at(4).get_adress() << endl;
            cout << "��ġ : " << all_house_vc.at(4).get_location() << endl;
            cout << "��� : " << all_house_vc.at(4).get_zone_size() << "��" << endl;
            cout << "�� ���� : " << all_house_vc.at(4).get_room_number() << "��" << endl;
            cout << "���� �ü� : " << all_house_vc.at(4).get_community_space() << endl;
            cout << "������ : " << all_house_vc.at(4).get_monthly_price() << "����" << endl;
            cout << endl;
            num = 3;
        }
        break;

    case 4: // ���� �Ź�
        if (all_house_vc.at(5).in_live == true)
        {
            cout << "����Ʈ �̸� : " << all_house_vc.at(5).get_apart_name() << endl;
            cout << "�ְ��� ���� : " << all_house_vc.at(5).get_kind() << endl;
            cout << "�ּ� : " << all_house_vc.at(5).get_adress() << endl;
            cout << "��ġ : " << all_house_vc.at(5).get_location() << endl;
            cout << "��� : " << all_house_vc.at(5).get_zone_size() << "��" << endl;
            cout << "�� ���� : " << all_house_vc.at(5).get_room_number() << "��" << endl;
            cout << "���� �ü� : " << all_house_vc.at(5).get_community_space() << endl;
            cout << "������ : " << all_house_vc.at(5).get_year_price() << "��" << endl;
            cout << endl;
            num = 4;
        }
        break;

    case 5: // �Ÿ� ���� �Ź�
        if (alone_house_vc.at(0).in_live == true)
        {
            cout << "�ְ��� ���� : " << alone_house_vc.at(0).get_kind() << endl;
            cout << "�ּ� : " << alone_house_vc.at(0).get_adress() << endl;
            cout << "��ġ : " << alone_house_vc.at(0).get_location() << endl;
            cout << "��� : " << alone_house_vc.at(0).get_zone_size() << "��" << endl;
            cout << "�� ���� : " << alone_house_vc.at(0).get_room_number() << "��" << endl;
            cout << "�ŸŰ� : " << alone_house_vc.at(0).get_trade_price() << "��" << endl;
            cout << endl;
            num = 5;
        }
        break;

    case 6: // �Ÿ� ���� �Ź�
        if (alone_house_vc.at(2).in_live == true)
        {
            cout << "�ְ��� ���� : " << alone_house_vc.at(2).get_kind() << endl;
            cout << "�ּ� : " << alone_house_vc.at(2).get_adress() << endl;
            cout << "��ġ : " << alone_house_vc.at(2).get_location() << endl;
            cout << "��� : " << alone_house_vc.at(2).get_zone_size() << "��" << endl;
            cout << "�� ���� : " << alone_house_vc.at(2).get_room_number() << "��" << endl;
            cout << "�ŸŰ� : " << alone_house_vc.at(2).get_trade_price() << "��" << endl;
            cout << endl;
            num = 6;
        }
        break;


    default:
        break;
    }

    if (choice >= 7 && choice <= (alone_house_vc2.size() + all_house_vc2.size() + 6))
    {
        if (choice - 6 <= all_house_vc2.size())
        {
            cout << "����Ʈ �̸� : " << all_house_vc2.at(choice - 7).get_apart_name() << endl;
            cout << "�ְ��� ���� : " << all_house_vc2.at(choice - 7).get_kind() << endl;
            cout << "�ּ� : " << all_house_vc2.at(choice - 7).get_adress() << endl;
            cout << "��ġ : " << all_house_vc2.at(choice - 7).get_location() << endl;
            cout << "��� : " << all_house_vc2.at(choice - 7).get_zone_size() << "��" << endl;
            cout << "�� ���� : " << all_house_vc2.at(choice - 7).get_room_number() << "��" << endl;
            cout << "���� �ü� : " << all_house_vc2.at(choice - 7).get_community_space() << endl;
            if (all_house_vc2.at(choice - 7).residence_type[0] == 1)
                cout << "������ : " << all_house_vc2.at(choice - 7).get_year_price() << "��" << endl;
            if (all_house_vc2.at(choice - 7).residence_type[1] == 1)
                cout << "������ : " << all_house_vc2.at(choice - 7).get_monthly_price() << "��" << endl;
            if (all_house_vc2.at(choice - 7).residence_type[1] == 1)
                cout << "�ŸŰ� : " << all_house_vc2.at(choice - 7).get_trade_price() << "��" << endl;
            cout << endl;
            num = choice;
        }
        else
        {
            cout << "�ְ��� ���� : " << alone_house_vc2.at(choice - all_house_vc2.size() - 7).get_kind() << endl;
            cout << "�ּ� : " << alone_house_vc2.at(choice - all_house_vc2.size() - 7).get_adress() << endl;
            cout << "��ġ : " << alone_house_vc2.at(choice - all_house_vc2.size() - 7).get_location() << endl;
            cout << "��� : " << alone_house_vc2.at(choice - all_house_vc2.size() - 7).get_zone_size() << "��" << endl;
            cout << "�� ���� : " << alone_house_vc2.at(choice - all_house_vc2.size() - 7).get_room_number() << "��" << endl;
            cout << "�ŸŰ� : " << alone_house_vc2.at(choice - all_house_vc2.size() - 7).get_trade_price() << "��" << endl;
            cout << endl;
            num = choice;
        }
    }
    else if(choice <= 0 || choice > 6 + alone_house_vc2.size() + all_house_vc2.size())
    {
        cout << "��Ͽ� ���� �����Դϴ�! �ʱ� ȭ������ ���ư��ϴ�!" << endl;
        Sleep(2000);
    }
}

void Yee()
{
    int select, selcet2;


    ofstream file(filename, ios::trunc);

    switch (choice)
    {
    case 1: select = 0; selcet2 = 0; break;
    case 2: select = 2; selcet2 = 0; break;
    case 3: select = 4; selcet2 = 0; break;
    case 4: select = 5; selcet2 = 0; break;
    case 5: select = 0; selcet2 = 1; break;
    case 6: select = 2; selcet2 = 1; break;
    default: break;
    }

    if (selcet2 == 0)
    {
        if (file.is_open())
        {
            if (choice < 3) { file << "�ŸŰ� : " << all_house_vc.at(select).get_trade_price() << "��" << endl; }
            else if (choice == 3) { file << "�ŸŰ� : " << all_house_vc.at(select).get_monthly_price() << "����" << endl; }
            else if (choice == 4) { file << "�ŸŰ� : " << all_house_vc.at(select).get_year_price() << "��" << endl; }

            file << "�ε��� �Ÿ� ��༭(�� ����)" << endl
                << "����Ʈ �̸� : " << all_house_vc.at(select).get_apart_name() << endl
                << "��� : " << all_house_vc.at(select).get_location() << endl
                << "��� : " << all_house_vc.at(select).get_zone_size() << "��" << endl
                << "�� ���� : " << all_house_vc.at(select).get_room_number() << "��" << endl
                << "�ְ��� ���� : " << all_house_vc.at(select).get_kind() << endl
                << "�ּ� : " << all_house_vc.at(select).get_adress() << endl;
            file.close();
        }
    }
    else if (selcet2 == 1)
    {
        if (file.is_open())
        {
            file << "�ε��� �Ÿ� ��༭(�� ����)" << endl
                << "�ŸŰ� : " << alone_house_vc.at(select).get_trade_price() << "��" << endl
                << "��� : " << alone_house_vc.at(select).get_location() << endl
                << "��� : " << alone_house_vc.at(select).get_zone_size() << "��" << endl
                << "�� ���� : " << alone_house_vc.at(select).get_room_number() << "��" << endl
                << "�ְ��� ���� : " << alone_house_vc.at(select).get_kind() << endl
                << "�ּ� : " << alone_house_vc.at(select).get_adress() << endl;
            file.close();
        }
    }
}

void sold_decision()
{
    char pick;
    cout << endl;
    cout << "����Ͻðڽ��ϱ�?" << endl;
    cout << "�ŷ��� ���Ͻø� y(Y)��, ��ġ �����ø� n(N)�� �����ּ���!" << endl;
    cin >> pick;

    if (pick == 'y' || pick == 'Y')
    {

        cout << "���������� ����� �Ϸ�Ǿ����ϴ�." << endl;
        if (num == 1)
        {
            all_house_vc.at(0).in_live = false;
            Yee();
        }
        else if (num == 2)
        {
            all_house_vc.at(2).in_live = false;
            Yee();
        }
        else if (num == 3)
        {
            all_house_vc.at(4).in_live = false;
            Yee();
        }
        else if (num == 4)
        {
            all_house_vc.at(5).in_live = false;
            Yee();
        }
        else if (num == 5)
        {
            alone_house_vc.at(0).in_live = false;
            Yee();
        }
        else if (num == 6)
        {
            alone_house_vc.at(2).in_live = false;
            Yee();
        }
        else if (num >= 7 && num <= (alone_house_vc2.size() + all_house_vc2.size() + 6))
        {
            if (num - 6 <= all_house_vc2.size())
            {
                all_house_vc2.at(choice - 7).in_live = false;
                ofstream file(filename, ios::trunc);

                if (file.is_open())
                {
                    if (choice < 3) { file << "�ŸŰ� : " << all_house_vc.at(choice - 7).get_trade_price() << "��" << endl; }
                    else if (choice == 3) { file << "�ŸŰ� : " << all_house_vc.at(choice - 7).get_monthly_price() << "����" << endl; }
                    else if (choice == 4) { file << "�ŸŰ� : " << all_house_vc.at(choice - 7).get_year_price() << "��" << endl; }
                    file << "�ε��� �Ÿ� ��༭(�� ����)" << endl 
                        << "�ǹ� �̸� : " << all_house_vc.at(choice - 7).get_apart_name() << endl
                        << "���� : " << all_house_vc.at(choice - 7).get_kind() << endl
                        << "�ּ� : " << all_house_vc.at(choice - 7).get_adress() << endl
                        << "��ġ : " << all_house_vc.at(choice - 7).get_location() << endl
                        << "��� : " << all_house_vc.at(choice - 7).get_zone_size() << endl
                        << "�� ���� : " << all_house_vc.at(choice - 7).get_zone_size() << endl
                        << "�����ü� : " << all_house_vc.at(choice - 7).get_community_space() << endl;
                    file.close();
                }
            }
            else
            {
                alone_house_vc2.at(choice - all_house_vc2.size() - 7).in_live = false;
                ofstream file(filename, ios::trunc);
                if (file.is_open())
                {
                    file << "�ε��� �Ÿ� ��༭(�� ����)" << endl 
                        << "�ŸŰ� : " << alone_house_vc.at(choice - all_house_vc2.size() - 7).get_trade_price() << "��" << endl
                        << "��� : " << alone_house_vc.at(choice - all_house_vc2.size() - 7).get_location() << endl
                        << "��� : " << alone_house_vc.at(choice - all_house_vc2.size() - 7).get_zone_size() << "��" << endl
                        << "�� ���� : " << alone_house_vc.at(choice - all_house_vc2.size() - 7).get_room_number() << "��" << endl
                        << "�ְ��� ���� : " << alone_house_vc.at(choice - all_house_vc2.size() - 7).get_kind() << endl
                        << "�ּ� : " << alone_house_vc.at(choice - all_house_vc2.size() - 7).get_adress() << endl;
                    file.close();
                }
            }
        }
    }
    else if (pick == 'n' || pick == 'N')
    {
        cout << "������� �ʽ��ϴ�." << endl;
    }
}


void buy()      // ����ڰ� �Ǹ�(�ε����� ����)
{
    char kind[20];
    int kind2;
    char location[20];
    char residance_type[30];
    int price;
    int zone_size;
    int room_number;
    char name[30];
    char commnuity_space[30];
    char adress[50];
    bool garden;
    bool in_live;
    char choice;
    int count = 0;

    system("cls");
    cout << "�Ǹŵ���� ���ϴ� �ǹ��� ������ �Է����ּ���(�������� : 1, �ܵ����� : 2): " << endl;  //�ǹ� ���� ����
    cin >> kind2;
    if (kind2 == 1 || kind2 == 2)
    {
        cout << "�Ǹŵ���� ���ϴ� �ǹ��� ������ �Է����ּ���: " << endl;
    }
    else { cout << "�ٽ� �õ����ּ���" << endl; }

    if (kind2 == 1)
    {
        cout << "�Է¹��: ���������� ���(�ǹ�����, ��ġ(������, ����������, ���θ�), ���, �氳��, �ǹ��̸�, �ǹ��ּ�, Ŀ�´�Ƽ����)" << endl;
        cin >> kind >> location >> zone_size >> room_number >> name >> adress >> commnuity_space;
        cout << "����Ͻô� �ְ�Ÿ�԰� ������ �Է����ּ���(����(���), ����(����), �Ÿ�(���)): " << endl;
        cin >> residance_type;
        cin >> price;

        All_House new_all_apart;
        new_all_apart.set_location(location);   // �����ǵ�
        new_all_apart.set_zone_size(zone_size); //�� > cout���� �� ���̱�
        new_all_apart.set_room_number(room_number);   // �� ����
        new_all_apart.set_kind(kind);   // �ǹ� ����
        new_all_apart.set_community_space(commnuity_space);
        new_all_apart.set_apart_name(name);
        new_all_apart.set_adress(adress);
        new_all_apart.set_residence_type(residance_type);
        if (strcmp(residance_type, "����") == 0) { new_all_apart.residence_type[0] = 1; new_all_apart.set_year_price((unsigned int)price); }
        else if (strcmp(residance_type, "����") == 0) { new_all_apart.residence_type[1] = 1; new_all_apart.set_monthly_price((unsigned int)price); }
        else if (strcmp(residance_type, "�Ÿ�") == 0) { new_all_apart.residence_type[2] = 1; new_all_apart.set_trade_price((unsigned int)price); }
        new_all_apart.in_live = true;
        cout << "(�Ǹ� ����Ϸ��� �ϴ� �Ź�)" << endl;
        cout << "�ǹ� �̸� : " << new_all_apart.get_apart_name() << endl;
        cout << "���� : " << new_all_apart.get_kind() << endl;
        cout << "�ּ� : " << new_all_apart.get_adress() << endl;
        cout << "��ġ : " << new_all_apart.get_location() << endl;
        cout << "��� : " << new_all_apart.get_zone_size() << endl;
        cout << "�� ���� : " << new_all_apart.get_zone_size() << endl;
        cout << "�����ü� : " << new_all_apart.get_community_space() << endl;
        if (new_all_apart.residence_type[0] == 1)
        {
            cout << "���� ���� / ������ : " << new_all_apart.get_year_price() << "���" << endl;
        }
        if (new_all_apart.residence_type[1] == 1)
        {
            cout << "���� ���� / ������ : " << new_all_apart.get_monthly_price() << "����" << endl;
        }
        if (new_all_apart.residence_type[2] == 1)
        {
            cout << "�Ÿ� ���� / �ŸŰ� : " << new_all_apart.get_trade_price() << "���" << endl;
        }
        cout << endl << endl;
        cout << "�ŷ��� �Ͻ÷��� y(Y) �ŷ��� ���� �������� n(N) �� �Է����ּ���: " << endl;
        cin >> choice;
        if (choice == 'y' || choice == 'Y')
        {
            all_house_vc2.push_back(new_all_apart);

            ofstream file(filename, ios::trunc);

            if (file.is_open())
            {
                file << "�ε��� �Ÿ� ��༭(�ε��� ����)" << endl 
                    << "�ǹ� �̸� : " << new_all_apart.get_apart_name() << endl
                    << "���� : " << new_all_apart.get_kind() << endl
                    << "�ּ� : " << new_all_apart.get_adress() << endl
                    << "��ġ : " << new_all_apart.get_location() << endl
                    << "��� : " << new_all_apart.get_zone_size() << endl
                    << "�� ���� : " << new_all_apart.get_zone_size() << endl
                    << "�����ü� : " << new_all_apart.get_community_space() << endl;
                file.close();
            }


            cout << "�ش� �Ź��� �Ǹ� ��ϵǾ����ϴ�." << endl << "�̿��� �ּż� �����մϴ�! :)" << endl;
            Sleep(2000);
        }
        else if (choice == 'n' || choice == 'N') { cout << "�ŷ��� ����մϴ�."; Sleep(2000); }
        else {
            cout << "��Ͽ� ���� �����Դϴ�! �ʱ� ȭ������ ���ư��ϴ�!" << endl;
            Sleep(2000);
        }
    }
    if (kind2 == 2)
    {
        cout << "�Է¹��: �ܵ������� ���(��ġ(������, ����������, ���θ�), ���, �氳��, �ǹ��ּ�, �ո��� ����(true : 1,false : 0)" << endl;
        cin >> location >> zone_size >> room_number >> adress >> garden;

        cout << "����Ͻô� ������ �Է����ּ���(�Ÿ�(���)): ";
        cin >> price;
        Alone_House new_alone_house;
        new_alone_house.set_trade_price(price); // ��
        new_alone_house.set_location(location);
        new_alone_house.set_zone_size(zone_size); // ��
        new_alone_house.set_room_number(room_number);
        new_alone_house.set_kind("����");
        new_alone_house.set_adress(adress);
        new_alone_house.in_live = true;
        //new_alone_house.in_live = false;
        cout << "(�Ǹ� ����Ϸ��� �ϴ� �Ź�)" << endl;
        cout << "����    : " << new_alone_house.get_kind() << endl;
        cout << "�ּ�    : " << new_alone_house.get_adress() << endl;
        cout << "��ġ    : " << new_alone_house.get_location() << endl;
        cout << "���    : " << new_alone_house.get_zone_size() << endl;
        cout << "�� ���� : " << new_alone_house.get_room_number() << endl;
        cout << "�ŸŰ�  : " << new_alone_house.get_trade_price() << "���" << "\n\n" << endl;

        cout << "�ŷ��� �Ͻ÷��� y(Y) �ŷ��� ���� �������� n(N) �� �Է����ּ���: ";
        cin >> choice;
        if (choice == 'y' || choice == 'Y')
        {
            alone_house_vc2.push_back(new_alone_house);

            ofstream file(filename, ios::trunc);

            if (file.is_open())
            {
                file << "�ε��� �Ÿ� ��༭(�ε��� ����)" << endl 
                    << "����    : " << new_alone_house.get_kind() << endl
                    << "�ּ�    : " << new_alone_house.get_adress() << endl
                    << "��ġ    : " << new_alone_house.get_location() << endl
                    << "���    : " << new_alone_house.get_zone_size() << endl
                    << "�� ���� : " << new_alone_house.get_room_number() << endl
                    << "�ŸŰ�  : " << new_alone_house.get_trade_price() << "���" << "\n\n" << endl;
                file.close();
            }

            cout << "�ش� �Ź��� �Ǹ� ��ϵǾ����ϴ�." << endl << "�̿��� �ּż� �����մϴ�! :)" << endl;
            Sleep(2000);
        }
        else if (choice == 'n' || choice == 'N') { cout << "�ŷ��� ����մϴ�."; Sleep(2000); }
        else {
            cout << "��Ͽ� ���� �����Դϴ�! �ʱ� ȭ������ ���ư��ϴ�!" << endl;
            Sleep(2000);
        }
    }
}

void print_1()      // �ܼ� �޴� ��¿�
{
    Sleep(500);     // ������ ��¹� ���ð�
    system("cls");  // �ܼ�â Ŭ����
    cout << "************** < ��� �ε��� > **************" << endl;
    cout << "*     1. �ε��� �����Ź� ����               *" << endl;
    cout << "*     2. �ε��� �����ϱ�(���� ����)       * " << endl;
    cout << "*     3. �ε��� �Ǹ��ϱ�(�ε����� ����)     * " << endl;
    cout << "*     4. �ֱٰŷ�����                       *" << endl;
    cout << "*     5. �����ϱ�                           *" << endl;
    cout << "*********************************************" << endl;
}

void switch1()
{
    char keypress_1;

    for (;;)
    {
        system("cls");          // �ܼ�â �ʱ�ȭ
        show_AllHouse();     // ���� �Ź� ��ü �����ֱ�
        cout << "\n���� â���� ���ư����� 1�� �Է��Ͻÿ�" << endl;

        cin >> keypress_1;

        if (keypress_1 == '1') { break; }
    }
}

void show_Yee()
{
    string line;
    char keypress_2;

    for (;;)
    {
        system("cls");

        ifstream file("transaction.txt");

        if (file.is_open())
        {
            while (getline(file, line)) { cout << line << endl; }
            file.close();
        }

        cout << "\n���� â���� ���ư����� 1�� �Է��Ͻÿ�" << endl;
        cin >> keypress_2;

        if (keypress_2 == '1') { break; }
    }

}

int main()
{
    Set_All_House();
    char keypress;


    for (;;)
    {
        print_1();


        cin >> keypress;
        if (keypress == '5')
        {
            system("cls");
            cout << "�ý��� ����\n" << endl;
            shot = remove(filename);
            break;
        }

        switch (keypress)
        {
        case '1': cout << "���� �ε����� ��ȸ�մϴ�.\n" << endl;  switch1();   break;
        case '2': cout << "���� ������ �ε����� ��ȸ�մϴ�.\n" << endl;
            sold(sold_choice());
            if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6 ||
               (choice >= 7 && choice <= (alone_house_vc2.size() + all_house_vc2.size() + 6)))
            {
                sold_decision();
            }
            break;
        case '3': cout << "�Ǹ��� �ε����� ������ �Է����ּ���\n" << endl;  buy();   break;
        case '4': cout << "�ŷ��� �ε����� ������ ��ȸ�մϴ�.\n" << endl; show_Yee();  break;
        default:  cout << "�ٽ� �Է����ּ���" << endl;  break;
        }
    }
}