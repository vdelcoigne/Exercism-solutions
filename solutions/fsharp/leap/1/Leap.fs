module Leap

let leapYear (year: int): bool = 
    let divisibleBy a = year % a = 0

    if divisibleBy 4 then (if divisibleBy 100 then (if divisibleBy 400 then true else false) else true) else false
