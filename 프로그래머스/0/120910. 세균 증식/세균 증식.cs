using System;

public class Solution {
    public int solution(int n, int t) {
        int answer = 0;
        for (int o = 0; o < t; o++)
        {
            n += n;
        }
        return answer=n;
    }
}