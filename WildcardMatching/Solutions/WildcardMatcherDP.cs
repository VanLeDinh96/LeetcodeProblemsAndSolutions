namespace WildcardMatching;

public sealed class WildcardMatcherDP
{
    public static bool IsMatch(string s, string p)
    {
        int n = s.Length;
        int m = p.Length;

        // dp[i][j] = true means s[0..i-1] matches p[0..j-1]
        bool[,] dp = new bool[n + 1, m + 1];

        // Empty string matches empty pattern
        dp[0, 0] = true;

        // Handle leading '*' in pattern that can match empty string
        for (int j = 1; j <= m; j++)
        {
            if (p[j - 1] == '*')
                dp[0, j] = dp[0, j - 1];
        }

        // Fill DP table
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                char sc = s[i - 1];
                char pc = p[j - 1];

                if (pc == sc || pc == '?')
                {
                    // Characters match -> depend on previous states
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else if (pc == '*')
                {
                    // '*' matches empty -> dp[i][j-1]
                    // '*' matches one+ char -> dp[i-1][j]
                    dp[i, j] = dp[i, j - 1] || dp[i - 1, j];
                }
                else
                {
                    dp[i, j] = false;
                }
            }
        }

        return dp[n, m];
    }
}
