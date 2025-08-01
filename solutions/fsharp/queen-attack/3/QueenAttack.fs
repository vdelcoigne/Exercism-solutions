module QueenAttack

let create (x, y) = 
    let isInRange value = value >=0 && value < 8
    isInRange x && isInRange y

let canAttack (x1:int, y1:int) (x2, y2) =
    x1 = x2 || y1 = y2 || (abs(x1 - x2) = abs(y1 - y2)) 
