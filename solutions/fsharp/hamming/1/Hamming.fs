module Hamming

let distance (strand1: string) (strand2: string): int option = 
    if (strand1.Length <> strand2.Length) 
    then None 
    else 
        List.zip (strand1 |> List.ofSeq) (strand2 |> List.ofSeq)
        |> List.sumBy (fun (c1, c2) -> if c1 = c2 then 0 else 1) 
        |> Some