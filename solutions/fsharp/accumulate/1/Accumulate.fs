module Accumulate

let rec select func input acc =
    match input with
    | [] -> acc
    | head::tail -> func head :: select func tail acc

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    select func input []
