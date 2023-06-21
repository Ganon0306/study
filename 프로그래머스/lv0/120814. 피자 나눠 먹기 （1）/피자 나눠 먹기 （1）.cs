using System;

public class Solution {
    public int solution(int n) {
        
         int a = 0;
        if(n%7 == 0)
        {
       a=0;
            }
        else
        {
            a=1;
        }
            int answer = n/7+a;
        
        return answer;
    }
}