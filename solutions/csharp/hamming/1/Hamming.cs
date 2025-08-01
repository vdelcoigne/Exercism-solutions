using System;using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException();
        }

        return firstStrand.Zip(secondStrand).Aggregate(0, (i, tuple) =>
        {
            if (tuple.First != tuple.Second)
            {
                return i + 1;
            }

            return i;
        });
    }
}
