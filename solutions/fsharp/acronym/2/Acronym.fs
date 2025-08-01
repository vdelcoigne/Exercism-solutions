module Acronym

open System

let abbreviate(phrase: string) =
    phrase.Split([| ' '; '-'; '_' |], StringSplitOptions.RemoveEmptyEntries)
    |> Array.map (fun s -> s[0] |> Char.ToUpper |> string)
    |> String.concat ""

