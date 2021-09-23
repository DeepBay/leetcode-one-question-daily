public class Solution {
    public bool IsPowerOfThree(int n) 
    {
        for(int i=0;i<=19;i++)
        {
            if(n==Math.Pow(3,i))
                return true;
        }
        return false;
    }
}
