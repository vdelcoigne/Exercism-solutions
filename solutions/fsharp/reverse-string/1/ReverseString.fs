module ReverseString

let reverse (input: string): string = 
    input.ToCharArray() |> Array.rev |> (fun chars -> new string(chars))