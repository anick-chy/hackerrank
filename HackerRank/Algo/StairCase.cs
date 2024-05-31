using System.Text;

namespace Algo
{
    internal class StairCase
    {
        public static void staircase(int n)
        {
            StringBuilder sb = new();
            for (int i = 0; i < n; i++)
            {
                sb.Append(' ');
            }

            for (int i = n - 1; i >= 0; i--)
            {
                sb[i] = '#';
                Console.WriteLine(sb);
            }
        }
    }
}
