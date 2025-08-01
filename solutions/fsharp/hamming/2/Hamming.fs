module Hamming

let distance (strand1: string) (strand2: string): int option = 
    if (strand1.Length <> strand2.Length) 
    then None 
    else 
        Seq.zip strand1 strand2
        |> Seq.sumBy (fun (c1, c2) -> if c1 = c2 then 0 else 1) 
        |> Some