module Bob

open System

let isQuestion (input:string) = 
    input.EndsWith("?")

let isYelling input = 
    input |> String.exists(Char.IsLetter) && input = input.ToUpper()

let response (input: string) = 
    let phrase = input.Trim()
    if (phrase = "") then "Fine. Be that way!"
    else
        match (isQuestion phrase, isYelling phrase) with 
        | (true, true) -> "Calm down, I know what I'm doing!"
        | (true, false) -> "Sure."
        | (false, true) -> "Whoa, chill out!"
        | _ -> "Whatever."