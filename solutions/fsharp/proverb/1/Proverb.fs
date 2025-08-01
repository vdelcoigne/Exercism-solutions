module Proverb

let recite (input: string list): string list =
    match input with 
    | [] -> []
    | _ ->
        let words = 
            input
            |> List.pairwise 
            |> List.map (fun (w1, w2) -> sprintf "For want of a %s the %s was lost." w1 w2)

        [ sprintf "And all for the want of a %s." (input |> List.head) ] |> List.append words

