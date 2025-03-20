using System;

public class Solution {
    public int solution(int n) {
            int answer = 0;
            int k;
            if (n % 7 == 0)
            {
                k = n / 7;
                answer = k;
            }
            else
            {
                k = n / 7;
                answer = 1 + k;
            }
               return answer;
    }
}