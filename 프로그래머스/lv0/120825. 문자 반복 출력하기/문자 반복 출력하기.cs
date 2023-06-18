using System;

public class Solution {
    public string solution(string my_string, int n)
    {
 string repeatedString = "";
    foreach (char c in my_string)
    {
        for (int i = 0; i < n; i++)
        {
            repeatedString += c;
        }
    }
    return repeatedString;
    }
}