module PerfectNumbers

type Classification = Perfect | Abundant | Deficient 

let aliquotSum number =
    let sum = seq { for i in 1 .. number - 1 do if number % i = 0 then i } |> Seq.sum

    if (sum = number) then Perfect
    elif (sum > number) then Abundant
    else Deficient

let classify n : Classification option = 
    if (n <= 0) then None 
    else aliquotSum n |> Some