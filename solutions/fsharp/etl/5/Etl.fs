module Etl

open System 

let folder map score chars = 
    chars |> List.fold (fun map char -> map |> Map.add (Char.ToLower(char)) score) map

let transform (scoresWithLetters: Map<int, char list>): Map<char, int> =     
   scoresWithLetters |> Map.fold folder Map.empty



