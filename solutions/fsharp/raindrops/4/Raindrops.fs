module Raindrops

let raindrops = [(3, "Pling"); (5, "Plang"); (7, "Plong")] 

let convert (number: int): string = 
     raindrops 
     |> Seq.filter(fun (n, _) -> number % n = 0) 
     |> Seq.map snd 
     |> String.concat ""
     |> function "" -> string number | s -> s
  