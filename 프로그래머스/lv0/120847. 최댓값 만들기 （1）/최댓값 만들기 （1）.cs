using System;

public class Solution {
    public int solution(int[] numbers) {
        int a = numbers.Length;
        Array.Sort(numbers);
        
        int answer = numbers[a-1] * numbers[a-2];
        return answer;
    }
}