module LargestSeriesProduct

open System

let proc (input:string) (span:int) = 
    let ints = input.ToCharArray() |> Array.map (string >> int)
    
    let rec products (array: int array) result =
        match array with 
        | array when array.Length < span -> result
        | array -> 
            let product = array.[..span-1] |> Array.reduce(*)
            products (Array.tail array) (product :: result)

    products ints list.Empty |> List.max |> Some


let largestProduct (input:string) (span:int) : int option = 
    if (span > input.Length || span < 0) then None
    elif (input.ToCharArray() |> Array.forall(Char.IsDigit) |> not) then None
    elif (span = 0 || input = "") then Some 1
    else proc input span

