module RotationalCipher

open System

let (|Upper|Lower|Other|) =
    function
    | c when c |> Char.IsUpper -> Upper
    | c when c |> Char.IsLower -> Lower
    | _ -> Other

let encrypt shiftKey =
    let uppers = [ 'A' .. 'Z' ]
    let lowers = [ 'a' .. 'z' ]

    fun char ->
        let rotate chars =
            let idx = chars |> List.findIndex (fun c -> char = c)
            chars[(idx + shiftKey) % 26]

        match char with
        | Upper -> uppers |> rotate
        | Lower -> lowers |> rotate
        | Other -> char

let rotate (shiftKey: int) (text: string) =
    let encrypt = encrypt shiftKey

    text.ToCharArray()
    |> Array.map encrypt
    |> (function
    | chars -> new string (chars))