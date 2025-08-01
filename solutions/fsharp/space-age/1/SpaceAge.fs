module SpaceAge

open System

type Planet = 
    | Earth
    | Venus
    | Mars
    | Uranus
    | Neptune
    | Saturn
    | Mercury
    | Jupiter

let earthRotation = 31557600.0

let age (planet: Planet) (seconds: int64): float =
    let orbitalPeriod rotation = earthRotation * rotation
    
    let earthYears = 
        match planet with
        | Earth -> earthRotation
        | Mercury -> orbitalPeriod 0.2408467 
        | Venus -> orbitalPeriod 0.61519726
        | Mars -> orbitalPeriod 1.8808158
        | Jupiter -> orbitalPeriod 11.862615
        | Saturn -> orbitalPeriod 29.447498
        | Uranus -> orbitalPeriod 84.016846
        | Neptune -> orbitalPeriod 164.79132

    Math.Round((float(seconds) / earthYears), 2)
