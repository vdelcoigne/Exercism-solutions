module Etl

let folder (map:Map<char, int>) (key:int) (chars:char list)  = 
    let lower = System.Char.ToLower
    
    (map, chars) ||> List.fold (fun map char -> map |> Map.add (lower char) key)

let transform (scoresWithLetters: Map<int, char list>): Map<char, int> =     
    (Map.empty<char, int>, scoresWithLetters) ||> Map.fold folder


