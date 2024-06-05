namespace Algo
{
    internal class BetweenTwoSets
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            Dictionary<int, int> common = new();

            b = b.OrderBy(o => o).ToList();

            var firsFact = findCommonFactors(b[0]);
            foreach (var f in firsFact)
                common.Add(f, 1);

            int bCount = b.Count;
            for (int i = 1; i < bCount; i++)
            {
                var cf = findCommonFactors(b[i]);

                foreach (var c in cf)
                {
                    if (common.ContainsKey(c))
                        common[c]++;
                }
            }


            int aCount = a.Count;
            for (int i = 0; i < aCount; i++)
            {
                var com = common.Where(x => x.Value == bCount + i);
                foreach (var c in com)
                {
                    if (c.Key % a[i] == 0)
                        common[c.Key]++;
                }
            }

            int counter = 0;
            foreach (var kv in common)
            {
                if (kv.Value == aCount + bCount)
                    counter++;
            }

            return counter;
        }

        static List<int> findCommonFactors(int n)
        {
            List<int> r = new();
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    r.Add(i);
                    if (n / i != i)
                        r.Add(n / i);
                }
            }

            return r;
        }
    }
}
