module Accumulate

let tailRec fn input = 
    let rec innerRec fn acc = function
        | [] -> acc
        | h::t -> innerRec fn (fn h :: acc) t
    innerRec fn [] input |> List.rev

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    tailRec func input
