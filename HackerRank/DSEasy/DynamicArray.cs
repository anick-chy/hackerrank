namespace DSEasy
{
    internal class DynamicArray
    {
        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            List<List<int>> arr = new();
            for(int i = 0;i < n; i++)
            {
                arr.Add(new List<int>());
            }
            List<int> answers = new();
            int lastAnswer = 0;
            foreach (var query in queries)
            {
                int idx = (query[1] ^ lastAnswer) % n;

                if (query[0] == 1)
                {
                    arr[idx].Add(query[2]);
                }
                else if (query[0] == 2)
                {
                    lastAnswer = arr[idx][query[2] % arr[idx].Count];
                    answers.Add(lastAnswer);
                }
            }

            return answers;
        }
    }
}
