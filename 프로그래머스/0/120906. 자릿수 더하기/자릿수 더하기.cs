using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        answer = (n % 10) +
                 (n / 10 % 10) +
                 (n / 100 % 10) +
                 (n / 1000 % 10) +
                 (n / 10000 % 10) +
                 (n / 100000 % 10) +
                 (n / 1000000 % 10);
        return answer;
    }
}