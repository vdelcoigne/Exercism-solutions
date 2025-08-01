module Proverb

let recite = function
    | [] -> []
    | input ->    
        let folder (want, lost) phrases = 
            let phrase = $"For want of a {want} the {lost} was lost."
            phrase :: phrases

        let last = [ $"And all for the want of a {(input |> List.head)}." ]
        
        input
        |> List.pairwise 
        |> (fun words -> (words, last) ||> List.foldBack folder)

