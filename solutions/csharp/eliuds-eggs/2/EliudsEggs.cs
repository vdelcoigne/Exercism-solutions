using System.Linq;

public static class EliudsEggs
{
    public static int EggCount(int encodedCount) =>
        System.Convert.ToString(encodedCount, 2).Where(c => c == '1').Count();
}
