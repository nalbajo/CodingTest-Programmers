using System;

public class Solution {
    public int solution(int n, int k) {
        float i = n*12000+k*2000-n/10*2000;
        int answer = (int)i;
        
        return answer;
    }
}