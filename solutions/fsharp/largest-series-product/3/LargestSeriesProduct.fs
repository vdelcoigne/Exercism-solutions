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
    match (span > input.Length || span < 0,
               input |> Seq.forall Char.IsDigit |> not,
               span = 0 || input = "") with
    | (true, _, _) -> None
    | (_, true, _) -> None
    | (_, _, true) -> Some 1
    | _ -> proc input span