module KindergartenGarden

type Plant = 
    | Grass
    | Clover
    | Radishes
    | Violets

let getPlant = function 
    | 'V' -> Violets
    | 'C' -> Clover
    | 'R' -> Radishes
    | 'G' -> Grass
    | _ -> failwith "Unknown plant"

let getStudent = function
    | "Alice" -> 0
    | "Bob" -> 2
    | "Charlie" -> 4
    | "David" -> 6
    | "Eve" -> 8
    | "Fred" -> 10
    | "Ginny" -> 12
    | "Harriet" -> 14
    | "Ileana" -> 16
    | "Joseph" -> 18
    | "Kincaid" -> 20
    | "Larry" -> 22
    | _ -> failwith "Unknown student"

let plants (diagram: string) (student: string) =
    let idx = student |> getStudent

    diagram.Split('\n')
    |> Array.collect (fun p ->
        p.Substring(idx, 2)
        |> Seq.map (getPlant)
        |> Seq.toArray)
    |> Array.toList
    