module CarsAssemble

let getRate speed = 
    if (speed >= 1 && speed <= 4) then 1.0
    elif (speed >= 5 && speed <= 8) then 0.9
    elif (speed = 9) then 0.8
    elif (speed = 10) then 0.77
    else 0.0

let productionRatePerHour (speed: int): float =
    (float)speed * 221.0 * (getRate speed)

let workingItemsPerMinute(speed: int): int =
   (int)(productionRatePerHour(speed) / 60.0)