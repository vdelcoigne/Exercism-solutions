module ArmstrongNumbers

open System

let asDigitArray n =
    n.ToString().ToCharArray()
    |> Array.map (Char.GetNumericValue >> int)

let isArmstrongNumber (number: int): bool = 
    let numbers = number |> asDigitArray
    number = ((0, numbers) ||> Array.fold (fun acc curr -> acc + pown curr numbers.Length))