module Isogram

open System 

let isIsogram (str: string) =
    let clean = str |> Seq.filter(Char.IsLetter)

    let uniqueCount =
        clean
        |> Seq.map (Char.ToLower)
        |> Set.ofSeq
        |> Set.count

    uniqueCount = (clean |> Seq.length)