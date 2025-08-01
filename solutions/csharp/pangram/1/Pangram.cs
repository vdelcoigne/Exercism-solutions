using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input) => input.ToLower().Where(c => Char.IsLetter(c)).ToHashSet().Count == 26;
}
