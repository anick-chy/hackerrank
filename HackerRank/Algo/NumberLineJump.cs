namespace Algo
{
    internal class NumberLineJump
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int[] slow = new int[2];
            int[] fast = new int[2];

            if(v1 <= v2)
            {
                slow[0] = x1;
                slow[1] = v1;
                fast[0] = x2;
                fast[1] = v2;
            }
            else
            {
                slow[0] = x2;
                slow[1] = v2;
                fast[0] = x1;
                fast[1] = v1;
            }
            string s = "NO";
            while (slow[0] >= fast[0])
            {
                if (slow[0] == fast[0])
                {
                    s = "YES";
                    break;
                }
                slow[0] += slow[1];
                fast[0] += fast[1];
            }

            return s;
        }
    }
}
