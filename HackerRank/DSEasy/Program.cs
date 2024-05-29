// See https://aka.ms/new-console-template for more information
using DSEasy;

Console.WriteLine("Hello, World!");

// hour glass
//List<List<int>> arr = new List<List<int>>();

//for (int i = 0; i < 6; i++)
//{
//    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
//}

//Console.WriteLine(HourGlass.hourglassSum(arr));

// dynamic array
//string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//int n = Convert.ToInt32(firstMultipleInput[0]);

//int q = Convert.ToInt32(firstMultipleInput[1]);

//List<List<int>> queries = new List<List<int>>();

//for (int i = 0; i < q; i++)
//{
//    queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
//}

//List<int> result = DynamicArray.dynamicArray(n, queries);

// Array Manipulation
string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int m = Convert.ToInt32(firstMultipleInput[1]);

List<List<int>> queries = new List<List<int>>();

for (int i = 0; i < m; i++)
{
    queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
}

long result = ArrayManipulation.arrayManipulation(n, queries);