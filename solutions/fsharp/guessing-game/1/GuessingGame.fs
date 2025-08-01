module GuessingGame

let reply (guess: int): string = 
    match guess with
    | i when i < 41 -> "Too low"    
    | i when i > 43 -> "Too high"
    | i when i = 42 -> "Correct"
    | _ -> "So close"
