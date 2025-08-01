module EliudsEggs

let eggCount (n:int) = System.Convert.ToString(n, 2) |> Seq.filter (fun c -> c = '1') |> Seq.length

