#include "AvBvHelper.h"

char* Av2Bv(long long av)
{
	char* result = (char*)malloc(13);
    if (result == NULL)
    {
        return NULL;
    }
    result[0] = 66;
    result[1] = 86;
    result[2] = 49;
    result[5] = 52;
    result[7] = 49;
    result[9] = 55;
    result[12] = 0;
    av = (av ^ Xor) + Add;
    result[11] = Table[av / 1 % 58];
    result[10] = Table[av / 58 % 58];
    result[3] = Table[av / 3364 % 58];
    result[8] = Table[av / 195112 % 58];
    result[4] = Table[av / 11316496 % 58];
    result[6] = Table[av / 656356768 % 58];
    return result;
}

int Bv2Av(const char* bv)
{
    long long sum = 0;
    sum += strchr(Table, bv[11]) - Table;
    sum += (long long)(strchr(Table, bv[10]) - Table) * 58;
    sum += (long long)(strchr(Table, bv[3]) - Table) * 3364;
    sum += (long long)(strchr(Table, bv[8]) - Table) * 195112;
    sum += (long long)(strchr(Table, bv[4]) - Table) * 11316496;
    sum += (long long)(strchr(Table, bv[6]) - Table) * 656356768;
	return (int)((sum - Add) ^ Xor);
}
