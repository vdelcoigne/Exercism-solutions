using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var numbers = number.ToString().Select(char.GetNumericValue).ToArray();

        return numbers.Sum(n => Math.Pow(n, numbers.Length)) == number;
    }
}