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

let students = ["Alice"; "Bob"; "Charlie"; "David"; "Eve"; "Fred"; 
     "Ginny"; "Harriet"; "Ileana";"Joseph"; "Kincaid"; "Larry" ] 

let plants (diagram: string) (student: string) =
    let place = students |> List.findIndex(fun name -> name = student)

    diagram.Split('\n')
    |> Seq.collect (fun p ->
        p.Substring(place * 2, 2)
        |> Seq.map (getPlant))
    |> Seq.toList
    