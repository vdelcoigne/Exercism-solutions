module RnaTranscription

let transform = function
    | 'G' -> 'C'
    | 'C' -> 'G'
    | 'T' -> 'A'
    | 'A' -> 'U'
    | _ -> failwith "Invalid DNA"

let toRna (dna: string): string = 
    Array.ofSeq dna |> Array.map transform |> System.String
    