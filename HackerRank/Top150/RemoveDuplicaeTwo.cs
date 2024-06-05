namespace Top150
{
    internal class RemoveDuplicaeTwo
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int k = 1, curSeq = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i-1] == nums[i] && curSeq == 1)
                {
                    curSeq++;
                    nums[k++] = nums[i];
                } else if (nums[i-1] != nums[i])
                {
                    curSeq = 1;
                    nums[k++] = nums[i];
                }
            }

            return k;
        }
    }
}
