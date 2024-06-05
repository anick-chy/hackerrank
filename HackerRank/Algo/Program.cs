// See https://aka.ms/new-console-template for more information
using Algo;

Console.WriteLine("Hello, World!");

//int n = Convert.ToInt32(Console.ReadLine().Trim());

//StairCase.staircase(n);


// between two sets
string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int m = Convert.ToInt32(firstMultipleInput[1]);

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

int total = BetweenTwoSets.getTotalX(arr, brr);