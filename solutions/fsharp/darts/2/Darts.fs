module Darts

let score (x: double) (y: double): int =
    let distance = (x * x) + (y * y) |> sqrt

    match distance with
    | d when d <= 1.0 -> 10
    | d when d <= 5.0 -> 5
    | d when d <= 10.0 -> 1
    | _ -> 0
