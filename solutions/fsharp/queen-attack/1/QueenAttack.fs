module QueenAttack

open System

let create (position: int * int) = 
    let isInRange value = value >=0 && value < 8
    fst position |> isInRange && snd position |> isInRange

let canAttack (queen1: int * int) (queen2: int * int) =
    let (x1, y1) = queen1
    let (x2, y2) = queen2

    match queen1, queen2 with
    | (_, _) when x1 = x2 || y1 = y2 -> true
    | _ -> Math.Abs(x1 - x2) = Math.Abs(y1 - y2)