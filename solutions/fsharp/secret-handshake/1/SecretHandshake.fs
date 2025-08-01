module SecretHandshake

let getSecret list =
    function
    | 1 -> "wink" :: list
    | 2 -> "double blink":: list
    | 4 ->  "close your eyes":: list
    | 8 ->  "jump":: list
    | 16 -> list |> List.rev
    | _ -> list

let commands number =
    [ 0 .. 4 ]
    |> List.map (fun shift -> (1 <<< shift) &&& number)
    |> List.fold getSecret List.empty 
    |> List.rev