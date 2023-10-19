namespace Recursion
{
    public class Recursion
    {
        public static int GetNum(int len, int sum, int k, int s) {
            if (len == k) 
            {
                if (sum == s) 
                {
                    return 1;
                }
                return 0;
            }
            
            int c = (len == 0 ? 1 : 0);
            int res = 0;
            
            for (int i = c; i < 10; i++) {
                res += GetNum(len + 1, sum + i, k, s);
            }
            
            return res;
        }

        public static int Execute(int k, int s)
        {
            return GetNum(0, 0, k, s);
        }
    }
}