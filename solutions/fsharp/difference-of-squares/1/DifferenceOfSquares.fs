module DifferenceOfSquares

let squareOfSum number = 
    [ 1 .. number ] |> List.sum |> (function n -> n * n)

let sumOfSquares number =
    [ 1 .. number ] |> List.sumBy(fun n -> n * n)

let differenceOfSquares number = 
    (squareOfSum number) - (sumOfSquares number)