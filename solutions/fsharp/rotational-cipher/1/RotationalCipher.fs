module RotationalCipher

open System

let encrypt shiftKey =
    let uppers = [ 'A' .. 'Z' ]
    let lowers = [ 'a' .. 'z' ]

    fun char ->
        let rotate chars =
            let idx = chars |> List.findIndex (fun c -> char = c)
            chars[(idx + shiftKey) % 26]

        match char with
        | c when c |> Char.IsUpper -> uppers |> rotate
        | c when c |> Char.IsLower -> lowers |> rotate
        | c -> c

let rotate (shiftKey: int) (text: string) =
    let encrypt = encrypt shiftKey

    text.ToCharArray()
    |> Array.map encrypt
    |> (function
    | chars -> new string (chars))
