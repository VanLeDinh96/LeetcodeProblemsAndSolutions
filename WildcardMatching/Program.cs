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
        };

foreach (var test in testCases)
{
    bool result = WildcardMatcherGreedy.IsMatch(test.s, test.p);
    Console.WriteLine($"IsMatch(\"{test.s}\", \"{test.p}\") = {result} (Expected: {test.expected})");
}
