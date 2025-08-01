using System;

public static class CollatzConjecture
{
    private static bool IsEven(int number) => number % 2 == 0;
    
    private static int Compute(int number) {
        if (IsEven(number)) return number / 2;
        else return (number*3) + 1;
    }
    
    private static int Collatz(int number, int steps) {
        if (number == 1) return steps;
        return Collatz (Compute(number), steps + 1);
    }
    
    public static int Steps(int number)
    {
        if (number <= 0) throw new ArgumentOutOfRangeException();
        return Collatz(number, 0);
    }
}