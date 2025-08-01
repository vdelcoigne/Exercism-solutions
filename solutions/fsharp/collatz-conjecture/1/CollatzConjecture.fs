module CollatzConjecture

let isEven number = number % 2 = 0

let compute number = 
    if (number |> isEven) then number / 2
    else (number * 3) + 1

let rec collatz number steps =
    if number = 1 then steps
    else collatz (compute number) steps+1

let steps (number: int): int option = 
    if (number <= 0) then None
    else collatz number 0 |> Some