using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
for (int n1= n; n > 0 && n<= 1000; n-=2)
{
    if (n1 % 2 == 0)
    {
        answer += n;
    }
    else
    {
        answer += (n - 1);
    }
    
}
    return answer;
        return answer;
    }
}