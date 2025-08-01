module BeerSong

let firstPhrase = function
    | 0 -> "No more bottles of beer on the wall, no more bottles of beer."
    | 1 -> "1 bottle of beer on the wall, 1 bottle of beer."
    | i -> $"%d{i} bottles of beer on the wall, %d{i} bottles of beer."

let secondPhrase = function
    | 0 -> "Go to the store and buy some more, 99 bottles of beer on the wall."
    | 1 -> "Take it down and pass it around, no more bottles of beer on the wall."
    | 2 -> "Take one down and pass it around, 1 bottle of beer on the wall."
    | i -> $"Take one down and pass it around, %d{i-1} bottles of beer on the wall."

let recite (startBottles: int) (takeDown: int) = 
    [
        let e = (startBottles - takeDown + 1)
        for i in [startBottles .. -1 .. e] do
            yield (firstPhrase i)
            yield (secondPhrase i)
            if (takeDown > 1 && i <> e) then yield ""
    ]



   