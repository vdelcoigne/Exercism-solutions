module Pangram

open System.Collections.Generic

let isPangram (input: string): bool = 
    let alphabet = List<char>()
    ['a'..'z'] |> Seq.iter alphabet.Add

    input.ToLower() |> String.iter (fun c -> alphabet.Remove(c) |> ignore)
    alphabet.Count = 0