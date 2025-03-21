using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0;
        if(2<=slice && slice <= 10)
{
    if (n/slice == 1 && n%slice == 0)
    {
        answer = 1;
    }
    else if (n / slice == 1 && n % slice != 0)
    {
        answer = 2;
    }
    else if (n / slice != 1 && n % slice == 0)
    {
        int k = n / slice;
        answer =  k;
    }
    else if (n / slice != 1 && n % slice != 0)
    {
        int k = n / slice;
        answer = k+1;
    }

}
        return answer;
    }
}