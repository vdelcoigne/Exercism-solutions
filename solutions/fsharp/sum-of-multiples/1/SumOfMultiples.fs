module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int = 
    numbers 
    |> List.filter (fun n -> n <> 0)
    |> List.collect (fun n -> [n..n..upperBound-1]) 
    |> List.distinct
    |> List.sum