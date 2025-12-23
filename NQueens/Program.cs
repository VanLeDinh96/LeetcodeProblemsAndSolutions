using NQueens;

var solution = new Solution();
int test = solution.TotalNQueens(8);
//for (int n = 1; n <= 8; n++)
//{
//    int result = solution.TotalNQueens(n);
//    Console.WriteLine($"n = {n}, TotalNQueens = {result}");
//}

// Expected output:
// n = 1, TotalNQueens = 1
// n = 2, TotalNQueens = 0
// n = 3, TotalNQueens = 0
// n = 4, TotalNQueens = 2
// n = 5, TotalNQueens = 10
// n = 6, TotalNQueens = 4
// n = 7, TotalNQueens = 40
// n = 8, TotalNQueens = 92
