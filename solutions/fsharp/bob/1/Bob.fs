module Bob

let isQuestion (input:string) = 
    input.LastIndexOf("?") = input.Length - 1

let isYelling (input:string) = 
    let chars = input.ToCharArray() |> Array.filter(System.Char.IsLetter)

    if (chars |> Array.isEmpty) then false
    else chars |> Array.forall(System.Char.IsUpper)

let response (input: string): string = 
    let trimmed = input.Trim()
    if (trimmed = "") then "Fine. Be that way!"
    else
        match (isQuestion trimmed, isYelling trimmed) with 
        | (true, true) -> "Calm down, I know what I'm doing!"
        | (true, false) -> "Sure."
        | (false, true) -> "Whoa, chill out!"
        | _ -> "Whatever."