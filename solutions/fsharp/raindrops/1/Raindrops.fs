module Raindrops

let raindrops = [(3, "Pling"); (5, "Plang"); (7, "Plong")] 

let fetch number str (modulo, text) : string = 
    if (number % modulo = 0) then str + text else str

let convert (number: int): string = 
    let mutable str = ""
    for raindrop in raindrops do
        str <- fetch number str raindrop

    if (str <> "") then str else number.ToString()
