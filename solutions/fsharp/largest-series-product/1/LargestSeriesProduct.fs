module LargestSeriesProduct

open System

let proc (input:string) (span:int) = 
    let ints = input.ToCharArray() |> Array.map (string >> int)
    
    ints 
    |> Array.mapi(fun i c -> ints.[i..i+span-1]) 
    |> Array.filter(fun x -> x.Length = span)
    |> Array.map(fun x -> x |> Array.reduce(*))
    |> Array.max
    |> Some

let largestProduct (input:string) (span:int) : int option = 
    if (span > input.Length || span < 0) then None
    elif (input.ToCharArray() |> Array.forall(Char.IsDigit) |> not) then None
    elif (span = 0 || input = "") then Some 1
    else proc input span

