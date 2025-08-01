module Etl

let transform (scoresWithLetters: Map<int, char list>): Map<char, int> = 
    let mutable result = Map.empty<char, int>

    let add char score = 
        result <- Map.add (char |> System.Char.ToLower) score result

    scoresWithLetters |> Map.iter 
        (fun score chars -> for char in chars do add char score)

    result
