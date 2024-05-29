namespace DSEasy
{
    internal class HourGlass
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            int max = -100;
            // 6 X 6 array
            // row will move from 0 to 3
            // col will move from 0 to 3
            for (int row = 0; row <= 3; row++)
            {
                for (int col = 0; col <=3; col++)
                {
                    int localSum = 0;
                    for (int i = row; i <= row + 2; i++)
                    {
                        for (int j = col; j<= col + 2; j++)
                        {
                            if (i == row + 1 && (j == col || j == col + 2))
                                continue;
                            localSum += arr[i][j];
                        }
                    }
                    if (localSum > max)
                        max = localSum;
                }
            }
            return max;
        }
    }
}
