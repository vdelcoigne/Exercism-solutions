module SqueakyClean

open System

let transform (c: char) : string =
    match c with
    | '-' -> "_"
    | ' ' -> String.Empty
    | d when Char.IsDigit d -> String.Empty
    | c when c >= 'α' && c <= 'ω' -> "?"
    | c when c >= 'a' && c <= 'z' -> string c
    | c when Char.IsUpper c -> $"-{c}".ToLower()
    | c -> $"{c}".ToLower()

let clean (identifier: string) : string = identifier |> String.collect transform