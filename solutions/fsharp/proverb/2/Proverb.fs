module Proverb

let recite = function
    | [] -> []
    | input ->
        let words = 
            input
            |> List.pairwise 
            |> List.map (fun (w1, w2) -> sprintf "For want of a %s the %s was lost." w1 w2)

        words @ [ sprintf "And all for the want of a %s." (input |> List.head) ] 

