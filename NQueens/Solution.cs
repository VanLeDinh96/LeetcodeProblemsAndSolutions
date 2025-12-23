namespace NQueens;

public class Solution
{
    private int _count;
    private bool[] _cols;
    private bool[] _diag1;
    private bool[] _diag2;
    private int _n;

    public int TotalNQueens(int n)
    {
        _n = n;
        _count = 0;

        _cols = new bool[n];
        _diag1 = new bool[2 * n];
        _diag2 = new bool[2 * n];

        Backtrack(0);

        return _count;
    }

    private void Backtrack(int row)
    {
        if (row == _n)
        {
            _count++;
            return;
        }

        for (int col = 0; col < _n; col++)
        {
            int d1 = row - col + _n;
            int d2 = row + col;

            if (_cols[col] || _diag1[d1] || _diag2[d2])
                continue;

            _cols[col] = true;
            _diag1[d1] = true;
            _diag2[d2] = true;

            Backtrack(row + 1);

            _cols[col] = false;
            _diag1[d1] = false;
            _diag2[d2] = false;
        }
    }
}
