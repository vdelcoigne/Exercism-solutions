using System;
using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var results =
            new List<(int, string)> {(3, "Pling"), (5, "Plang"), (7, "Plong")}
                .Where(f => number % f.Item1 == 0)
                .Select(f => f.Item2)
                .ToList();

        return results.Any() ? string.Concat(results) : number.ToString();
    }
}