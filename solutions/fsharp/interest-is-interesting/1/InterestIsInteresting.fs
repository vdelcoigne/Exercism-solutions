module InterestIsInteresting

let interestRate =
    function 
    | b when b < 0m -> -3.213f 
    | b when b < 1000m -> 0.5f
    | b when b >= 1000m && b < 5000m -> 1.621f
    | _ -> 2.475f
 
let annualBalanceUpdate(balance: decimal): decimal =
    let rate = interestRate balance |> decimal
    let interest = (rate / 100m) * balance 
    balance + interest

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    if (balance < 0m) then 0
    else 
        balance * (taxFreePercentage |> decimal) / 100m * 2m |> int
