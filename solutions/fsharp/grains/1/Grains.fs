module Grains

let square (n: int): Result<uint64,string> = 
    if (n <= 0 || n > 64) then Error "square must be between 1 and 64" else
    Ok (pown 2UL (n-1))

let total: Result<uint64,string> = 
    Ok (Seq.sumBy (fun n -> pown 2UL (n-1)) [1..64])