using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool IsDivBy(int n) => year % n == 0;

        return IsDivBy(400) || (!IsDivBy(100) && IsDivBy(4));
    }
}