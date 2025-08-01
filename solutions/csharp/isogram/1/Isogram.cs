using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var clean = word.Where(Char.IsLetter);

        var count = clean.Select(Char.ToLower).ToHashSet().Count;
        return count == clean.Count();
    }
}
