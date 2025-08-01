module Leap

let leapYear (year: int): bool = 
    let divisibleBy a = year % a = 0

    if not (divisibleBy 4) then false 
    elif (divisibleBy 100) then 
        divisibleBy 400
    else true