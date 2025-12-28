namespace WildcardMatching;

public sealed class Greedy
{
    public static bool IsMatch(string s, string p)
    {
        int i = 0, j = 0;
        int asteriskIndex = -1;
        int matchIndex = 0;
        while (i < s.Length)
        {
            if (j < p.Length && (s[i] == p[j] || p[j] == '?'))
            {
                i++;
                j++;
            }
            else if (j < p.Length && p[j] == '*')
            {
                asteriskIndex = j;
                matchIndex = i; // khi gặp dấu * thì phải ghi nhớ * bắt đầu khớp với vị trí nào trong string
                j++;
            }
            else if (asteriskIndex != -1)
            {
                j = asteriskIndex + 1;
                matchIndex++;
                i = matchIndex;
            }
            else
            {
                return false;
            }
        }
        while(j < p.Length && p[j] == '*')
        {
            j++;
        }
        return j == p.Length;
    }
}
