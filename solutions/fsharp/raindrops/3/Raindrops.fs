module Raindrops

let raindrops = [(3, "Pling"); (5, "Plang"); (7, "Plong")] 

let convert (number: int): string = 
    let result = raindrops |> Seq.filter(fun (n, _) -> number % n = 0) |> Seq.map snd |> String.concat ""
  
    if (result <> "") then result else number.ToString()