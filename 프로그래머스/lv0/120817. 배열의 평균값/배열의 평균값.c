#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// numbers_len은 배열 numbers의 길이입니다.
double solution(int numbers[], size_t numbers_len)
{
    double num=0;
    double res=0.0;
    for(int i=0; i<numbers_len; i++)
    {
        num = num + numbers[i];
        res = num / numbers_len;
    }
        return res;
}