module NucleotideCount

let folder map (c: char) =
    match c with
    | 'A'
    | 'C'
    | 'G'
    | 'T' ->
        map
        |> Map.change c (function
            | Some v -> Some(v + 1)
            | None -> Some 1)
    | _ -> map

let nucleotideCounts(strand: string) : Option<Map<char, int>> =
    if
        strand
        |> Seq.exists (fun c ->
            match c with
            | 'A'
            | 'C'
            | 'G'
            | 'T' -> false
            | _ -> true)
    then
        None
    else
        let map = Map [ 'A', 0; 'C', 0; 'G', 0; 'T', 0 ]
        strand |> Seq.fold folder map |> Some
