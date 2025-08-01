module TwoFer

let twoFer (input: string option): string = 
    match input with
    | None -> "One for you, one for me."
    | Some x -> sprintf "One for %s, one for me." x 