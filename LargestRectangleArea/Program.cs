using LargestRectangleArea.Solutions;

//Test([2, 4, 6, 8]);
Test([2, 1, 5, 6, 2, 3]);
//Test([3, 3, 3, 3]);
//Test([1, 3, 2, 1, 2]);
//Test([5]);
//Test([6, 5, 4, 3, 2, 1]);
static void Test(int[] histogram)
{
    Console.WriteLine("Histogram: [" + string.Join(", ", histogram) + "]");
    int result = HistogramMonotonicStackSolver.LargestRectangleArea(histogram);
    Console.WriteLine("Max Rectangle Area = " + result);
    Console.WriteLine(new string('-', 40));
}