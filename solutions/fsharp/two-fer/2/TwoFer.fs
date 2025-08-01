module TwoFer

let twoFer (input: string option): string = 
    sprintf "One for %s, one for me." (input |> Option.defaultValue "you")
    