namespace WildcardMatching;

public class WildcardMatcherBruteForce
{
    public bool IsMatch(string s, string p)
    {
        return Dfs(0, 0, s, p);
    }

    private static bool Dfs(int i, int j, string s, string p)
    {
        // Base case: both string and pattern are fully matched
        if (i == s.Length && j == p.Length)
            return true;

        // Pattern finished but string not finished -> cannot match
        if (j == p.Length)
            return false;

        // Case 1: current chars match OR pattern has '?'
        if (i < s.Length && (p[j] == s[i] || p[j] == '?'))
        {
            if (Dfs(i + 1, j + 1, s, p))
                return true;
        }

        // Case 2: pattern has '*'
        if (p[j] == '*')
        {
            // Option A: '*' matches empty string -> move pattern only
            if (Dfs(i, j + 1, s, p))
                return true;

            // Option B: '*' matches one or more chars -> move string only
            if (i < s.Length && Dfs(i + 1, j, s, p))
                return true;
        }

        // Otherwise -> mismatch
        return false;
    }
}
