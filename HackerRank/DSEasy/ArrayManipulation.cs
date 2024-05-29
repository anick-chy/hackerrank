namespace DSEasy
{
    internal class ArrayManipulation
    {
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            long[] arr = new long[n + 1];
            long max = 0;
            foreach (var query in queries)
            {
                arr[query[0]] += query[2];
                if (query[1] < n)
                    arr[query[1] + 1] -= query[2];
            }
            for(int i = 1; i <= n; i++)
            {
                arr[i] += arr[i - 1];
                max = Math.Max(max, arr[i]);
            }

            return max;
        }
    }
}
