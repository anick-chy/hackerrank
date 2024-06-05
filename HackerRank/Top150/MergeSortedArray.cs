namespace Top150
{
    internal class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int l = m + n - 1;
            int i = m - 1, j = n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums2[j] < nums1[i])
                {
                    nums1[l] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[l] = nums2[j];
                    j--;
                }
                l--;
            }
            while(i >= 0)
            {
                nums1[l--] = nums1[i--];
            }
            while(j >= 0)
            {
                nums1[l--] = nums2[j--];
            }
        }
    }
}
