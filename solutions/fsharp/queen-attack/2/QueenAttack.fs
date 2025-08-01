module QueenAttack

open System

let create (x, y) = 
    let isInRange value = value >=0 && value < 8
    isInRange x && isInRange y

let canAttack (x1:int, y1:int) (x2, y2) =
    x1 = x2 || y1 = y2 || (Math.Abs(x1 - x2) = Math.Abs(y1 - y2)) 
