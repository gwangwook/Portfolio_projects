#include <iostream>
#include <string>
#include <algorithm>
#include "property_head.h"
using namespace std;

// House 클래스
void House::set_residence_type(const char* input_type)
{
	string a(input_type);
	if (a.find("전세") != string::npos)
	{
		this->residence_type[0] = 1;
	}
	if (a.find("월세") != string::npos)
	{
		this->residence_type[1] = 1;
	}
	if (a.find("매매") != string::npos)
	{
		this->residence_type[2] = 1;
	}
}

void House::set_adress(const char* adress)
{
	strcpy(this->adress, adress);
}
void House::set_location(const char* location)
{
	strcpy(this->location, location);
}
void House::set_kind(const char* kind) 
{ 
	strcpy(this->kind, kind);
}
void House::set_year_price(int year_price)
{
	this->year_price = year_price;
}
void House::set_monthly_price(int monthly_price)
{
	this->monthly_price = monthly_price;
}
void House::set_trade_price(int trade_price)
{
	this->trade_price = trade_price;
}
void House::set_zone_size(int zone_size)
{
	this->zone_size = zone_size;
}
void House::set_room_number(int room_number)
{
	this->room_number = room_number;
}

const char* House::get_adress() { return adress; }
const char* House::get_location()	{ return location; }
const char* House::get_kind() { return kind; }
int House::get_year_price()				{return year_price; }
int House::get_monthly_price()		{ return monthly_price; }
int House::get_trade_price()			{ return trade_price; }
int House::get_zone_size()				{ return zone_size; }
int House::get_room_number()			{ return room_number; }


// (All_House)공동주택 클래스 정의
void All_House::set_apart_name(const char* apart_name) { strcpy(this->apart_name, apart_name); }
void All_House::set_community_space(const char* community_space) { strcpy(this->community_space, community_space); }

const char* All_House::get_apart_name() { return apart_name; }
const char* All_House::get_community_space() {return community_space; }