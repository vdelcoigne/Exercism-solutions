module ProteinTranslation

let translate = function
| "AUG" -> "Methionine"
| "UUU" | "UUC" -> "Phenylalanine" 
| "UUA" | "UUG" -> "Leucine"
| "UCU" | "UCC" | "UCA" | "UCG" -> "Serine"
| "UAU" | "UAC" -> "Tyrosine"
| "UGU" | "UGC" -> "Cysteine"
| "UGG" -> "Tryptophan"
| _ -> ""

let isStop codon = 
    codon = "UAA" || codon = "UAG" || codon = "UGA"

let proteins (rna:string) = 
    let x = rna.Length / 3
    rna 
    |> Seq.splitInto x 
    |> Seq.map System.String
    |> Seq.takeWhile (isStop >> not)
    |> Seq.map(translate)
    |> Seq.toList

