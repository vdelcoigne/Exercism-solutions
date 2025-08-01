module SpaceAge

open System

type Planet = 
    | Mercury
    | Venus
    | Earth
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

[<Literal>]
let EarthYearInSeconds = 31557600.0

let orbitalPeriod = function 
    | Earth -> 1.0
    | Mercury -> 0.2408467 
    | Venus -> 0.61519726
    | Mars -> 1.8808158
    | Jupiter -> 11.862615
    | Saturn -> 29.447498
    | Uranus -> 84.016846
    | Neptune -> 164.79132

let age planet (seconds: int64) =
    Math.Round((float seconds / ((orbitalPeriod planet) * EarthYearInSeconds)), 2)
