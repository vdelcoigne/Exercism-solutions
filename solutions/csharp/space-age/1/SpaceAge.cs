using System;

public class SpaceAge
{
    const double EarthYearInSeconds = 31557600.0;

    private readonly int _seconds;
    
    public SpaceAge(int seconds)
    {        
        _seconds = seconds;
    }

    private double GetAge(double coefficient) 
    {
         return Math.Round((_seconds / (coefficient * EarthYearInSeconds)), 2);
    }
    
    public double OnEarth() => GetAge(1);

    public double OnMercury() => GetAge(0.2408467);

    public double OnVenus()=> GetAge(0.61519726);

    public double OnMars() => GetAge(1.8808158);

    public double OnJupiter() => GetAge(11.862615);

    public double OnSaturn() => GetAge(29.447498);

    public double OnUranus() => GetAge(84.016846);

    public double OnNeptune() => GetAge(164.79132);
}