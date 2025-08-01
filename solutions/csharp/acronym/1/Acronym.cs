using System; 
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var split = phrase.Split(new[] {' ', '_', '-'}, StringSplitOptions.RemoveEmptyEntries);
        return string.Concat(split.Select(c => Char.ToUpper(c[0])));
    }
} 