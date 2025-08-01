module Pangram

open System

let isPangram (input: string): bool = 
    (input.ToLower() |> Seq.where (fun c -> Char.IsLetter c) |> Set.ofSeq).Count = 26
