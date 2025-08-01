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

let getStudentPlace student =
    ["Alice"; "Bob"; "Charlie"; "David"; "Eve"; "Fred"; 
     "Ginny"; "Harriet"; "Ileana";"Joseph"; "Kincaid"; "Larry" ] 
    |> List.findIndex(fun name -> name = student)
    |> (fun idx -> idx * 2)

let plants (diagram: string) (student: string) =
    let place = student |> getStudentPlace

    diagram.Split('\n')
    |> Array.collect (fun p ->
        p.Substring(place, 2)
        |> Seq.map (getPlant)
        |> Seq.toArray)
    |> Array.toList
    