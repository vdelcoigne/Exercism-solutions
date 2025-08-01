module ResistorColorDuo

let folder state item =
    let value =
        match item with
        | "black" -> 0
        | "brown" -> 1
        | "red" -> 2
        | "orange" -> 3
        | "yellow" -> 4
        | "green" -> 5
        | "blue" -> 6
        | "violet" -> 7
        | "grey" -> 8
        | "white" -> 9
        | _ -> failwith "invalid color"

    state + (string value)
    
let value colors =
    colors |> List.take 2 |> List.fold folder "" |> int
