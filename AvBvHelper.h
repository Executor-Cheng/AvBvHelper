#pragma once
#include <string.h>
#include <stdlib.h>

static char Table[58] = { 102, 90, 111, 100, 82, 57, 88, 81, 68, 83, 85, 109, 50, 49, 121, 67, 107, 114, 54,
						  122, 66, 113, 105, 118, 101, 89, 97, 104, 56, 98, 116, 52, 120, 115, 87, 112, 72, 110,
						  74, 69, 55, 106, 76, 53, 86, 71, 51, 103, 117, 77, 84, 75, 78, 80, 65, 119, 99, 70 };

static const int Xor = 177451812;

static const long long Add = 8728348608;

char* Av2Bv(long long av);

int Bv2Av(const char* bv);
