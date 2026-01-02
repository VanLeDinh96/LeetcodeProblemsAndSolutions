namespace LargestRectangleArea.Solutions;

public sealed class HistogramMonotonicStackSolver
{
    public static int LargestRectangleArea(int[] heights)
    {
        Stack<int> stack = new();
        stack.Push(-1);
        int maxArea = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            while (stack.Peek() != -1 && heights[i] < heights[stack.Peek()])
            {
                int h = heights[stack.Pop()];
                int width = i - stack.Peek() - 1;
                int area = h * width;
                maxArea = Math.Max(maxArea, area);
            }

            stack.Push(i);
        }

        int n = heights.Length;

        while (stack.Peek() != -1)
        {
            int h = heights[stack.Pop()];
            int width = n - stack.Peek() - 1;
            int area = h * width;
            maxArea = Math.Max(maxArea, area);
        }

        return maxArea;
    }
}