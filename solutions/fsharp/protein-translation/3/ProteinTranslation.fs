module ProteinTranslation

let proteins (rna:string) = 
    let isStop = function
        | "UAA" | "UAG" | "UGA" -> true
        | _ -> false

    let translate = function
        | "AUG" -> "Methionine"
        | "UUU" | "UUC" -> "Phenylalanine" 
        | "UUA" | "UUG" -> "Leucine"
        | "UCU" | "UCC" | "UCA" | "UCG" -> "Serine"
        | "UAU" | "UAC" -> "Tyrosine"
        | "UGU" | "UGC" -> "Cysteine"
        | "UGG" -> "Tryptophan"
        | _ -> ""

    rna 
    |> Seq.chunkBySize 3
    |> Seq.map System.String
    |> Seq.takeWhile (isStop >> not)
    |> Seq.map(translate)
    |> Seq.toList

