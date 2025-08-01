module Raindrops

let raindrops = [(3, "Pling"); (5, "Plang"); (7, "Plong")] 

let convert (number: int): string = 
    let str = raindrops |> Seq.filter(fun (n, _) -> number % n = 0) |> Seq.fold (fun acc x -> acc + snd x) "" 
    
    if (str <> "") then str else number.ToString()