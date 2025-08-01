using System;
using System.Linq;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        return input.Select(getPoints).Sum();

        static int getPoints(char c)
        {
            return Char.ToLower(c) switch
            {
                'a' or 'e' or 'i' or 'o' or 'u' or 'l' or 'n' or 'r' or 's' or 't' => 1,
                'd' or 'g' => 2,
                'b' or 'c' or 'm' or 'p' => 3,
                'f' or 'h' or 'v' or 'w' or 'y' => 4,
                'k' => 5,
                'j' or 'x' => 8,
                'q' or 'z' => 10,
                _ => 0
            };
        }
    }
}