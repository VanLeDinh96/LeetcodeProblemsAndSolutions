namespace WildcardMatching;

public sealed class WildcardMatcherGreedy
{
    public static bool IsMatch(string s, string p)
    {
        int i = 0; // pointer for s
        int j = 0; // pointer for p
        int starIndex = -1;   // last position of '*' in pattern
        int matchIndex = -1;  // position in s that '*' corresponds to

        while (i < s.Length)
        {
            // Case 1: chars match or pattern has '?'
            if (j < p.Length && (p[j] == s[i] || p[j] == '?'))
            {
                i++;
                j++;
            }
            // Case 2: pattern has '*'
            else if (j < p.Length && p[j] == '*')
            {
                // Record star position & the string index at this time
                starIndex = j;
                matchIndex = i;
                j++; // Treat '*' initially as matching empty
            }
            // Case 3: mismatch but we saw '*' before -> backtrack
            else if (starIndex != -1)
            {
                // Reset pattern pointer to char after the last '*'
                j = starIndex + 1;

                // Increase match length of '*'
                matchIndex++;
                i = matchIndex;
            }
            else
            {
                // No '*' to fallback to -> not match
                return false;
            }
        }

        // Pattern must have only '*' left
        while (j < p.Length && p[j] == '*')
            j++;

        return j == p.Length;
    }
}
