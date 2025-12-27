using WildcardMatching;

// Example test cases
var testCases = new[]
{
            new { s = "aa", p = "a", expected = false },
            new { s = "aa", p = "*", expected = true },
            new { s = "cb", p = "?a", expected = false },
            new { s = "adceb", p = "*a*b", expected = true },
            new { s = "acdcb", p = "a*c?b", expected = false },
            new { s = "", p = "", expected = true },
            new { s = "", p = "*", expected = true },
            new { s = "a", p = "", expected = false },
            new { s = "abc", p = "???", expected = true },
            new { s = "abc", p = "??", expected = false },
            new { s = "abc", p = "*?", expected = true },
            new { s = "abc", p = "?*", expected = true },
            new { s = "abc", p = "*a*", expected = true },
            new { s = "abc", p = "*b*", expected = true },
            new { s = "abc", p = "*d*", expected = false },
            new { s = "mississippi", p = "m*si*pi", expected = true },
            new { s = "mississippi", p = "m*si*pp", expected = false },
            new { s = "aab", p = "c*a*b", expected = false },
            new { s = "aab", p = "*a*b", expected = true }
        };

foreach (var test in testCases)
{
    bool result = WildcardMatcherGreedy.IsMatch(test.s, test.p);
    Console.WriteLine($"IsMatch(\"{test.s}\", \"{test.p}\") = {result} (Expected: {test.expected})");
}
