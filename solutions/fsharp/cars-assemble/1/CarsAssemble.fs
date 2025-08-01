module CarsAssemble

let getRate speed = 
    match speed with
    | v when v >= 1 && v <= 4 -> 1.0
    | v when v >= 5 && v <= 8 -> 0.9
    | 9 -> 0.8
    | 10 -> 0.77
    | _ -> 0.0

let productionRatePerHour (speed: int): float =
    (float)speed * 221.0 * (getRate speed)

let workingItemsPerMinute(speed: int): int =
   (int)(productionRatePerHour(speed) / 60.0)