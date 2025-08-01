module PerfectNumbers

type Classification = Perfect | Abundant | Deficient 

let aliquotSum number =
    seq { for i in 1 .. number - 1 do if number % i = 0 then i } 
    |> Seq.sum 
    |> fun (sum) -> 
        match sum with
        | _ when sum = number -> Perfect
        | _ when sum > number -> Abundant
        | _ -> Deficient

let classify n : Classification option = 
    if (n <= 0) then None 
    else n |> aliquotSum |> Some