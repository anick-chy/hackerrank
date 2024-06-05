namespace Top150
{
    internal class RemoveElementProblem
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0, i = 0, n = nums.Length, j = 0;
            while (i < n)
            {
                if (nums[i] != val)
                {
                    nums[j++] = nums[i];
                    k++;
                }
                i++;
            }

            return k;
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int k = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
