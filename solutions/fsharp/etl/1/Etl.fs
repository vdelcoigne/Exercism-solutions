module Etl

let transform (scoresWithLetters: Map<int, char list>): Map<char, int> = 
    let mutable result = Map.empty<char, int>

    let add char key = 
        result <- Map.add (char |> System.Char.ToLower) key result

    scoresWithLetters |> Map.iter 
        (fun key chars -> for char in chars do add char key)

    result
