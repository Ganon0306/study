#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) 
{
    int answer = 0;
    int b = n/2;
    for (int a = 1;  a <= b; a++)
    {
        answer += (2*a);
    }
    return answer;
}