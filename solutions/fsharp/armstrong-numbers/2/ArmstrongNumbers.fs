module ArmstrongNumbers

open System

let asDigitArray n =
    n.ToString().ToCharArray()
    |> Array.map (Char.GetNumericValue >> int)

let isArmstrongNumber (number: int): bool = 
    let numbers = number |> asDigitArray
    numbers |> Array.sumBy (fun x -> pown x numbers.Length) |> (=) number