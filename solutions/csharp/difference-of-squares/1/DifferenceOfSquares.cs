using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {       
        var sum = Enumerable.Range(1, max).Sum();
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        return Enumerable.Range(1, max).Sum(n => n * n);
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return (CalculateSquareOfSum(max)) - (CalculateSumOfSquares(max));
    }
}