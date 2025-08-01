module Leap

let leapYear (year: int): bool = 
    let divisibleBy a = year % a = 0

    divisibleBy 400 || (divisibleBy 4 && not (divisibleBy 100))