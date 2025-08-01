module Darts

open System

type TargetArea = 
| Outside 
| OuterCircle 
| MiddleCircle
| InnerCircle 

let getTargetArea x y  = 
    let distance x y = (x * x) + (y * y) |> Math.Sqrt 

    match distance x y with
    | f when f >= 0.0 && f <= 1.0-> InnerCircle
    | f when f > 1.0 && f <= 5.0-> MiddleCircle
    | f when f > 5.0 && f <= 10.0-> OuterCircle
    | _ -> Outside

let score (x: double) (y: double): int = 
    match getTargetArea x y with
    | Outside -> 0
    | OuterCircle -> 1
    | MiddleCircle -> 5
    | InnerCircle -> 10