// See https://aka.ms/new-console-template for more information
using Top150;

Console.WriteLine("Hello, World!");

//string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
//int m = Convert.ToInt32(firstMultipleInput[0]);
//int n = Convert.ToInt32(firstMultipleInput[1]);

//int[] arr = new int[m + n];

//List<int> t = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
//for(int i = 0; i < m; i++)
//{
//    arr[i] = t[i];
//}

//int[] brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToArray();

//MergeSortedArray.Merge(arr, m, brr, n);

//int val = Convert.ToInt32(Console.ReadLine());
int[] nums = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToArray();

RemoveDuplicaeTwo.RemoveDuplicates(nums);