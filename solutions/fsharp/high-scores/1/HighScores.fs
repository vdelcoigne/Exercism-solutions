module HighScores

let scores (values: int list): int list =
    values

let latest (values: int list): int =
    values |> List.last

let personalBest (values: int list): int =
    values |> List.sortDescending |> List.head

let personalTopThree (values: int list): int list = 
    match values with
    | array when List.length array < 3 -> array |> List.sortDescending
    | _ -> values |> List.sortDescending |> List.take 3