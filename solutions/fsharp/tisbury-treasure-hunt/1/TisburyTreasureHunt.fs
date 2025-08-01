module TisburyTreasureHunt

let getCoordinate (line: string * string): string =
    snd(line)

let convertCoordinate (coordinate: string): int * char = 
    (coordinate.[0] |> string |> int, coordinate.[1])

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool = 
    let azCoord = getCoordinate azarasData |> convertCoordinate
    let (_, ruisCoord, _) = ruisData

    azCoord = ruisCoord

let createRecord (azarasData: string * string) (ruisData: string * (int * char) * string) : (string * string * string * string) =
    if (compareRecords azarasData ruisData) then
        let (location, _, color) = ruisData
        (snd(azarasData), location, color, fst(azarasData))
    else 
        ("", "", "", "")
