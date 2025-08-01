module Yacht

type Category =
    | Ones
    | Twos
    | Threes
    | Fours
    | Fives
    | Sixes
    | FullHouse
    | FourOfAKind
    | LittleStraight
    | BigStraight
    | Choice
    | Yacht

type Die =
    | One
    | Two
    | Three
    | Four
    | Five
    | Six

let getPoints =
    function
    | One -> 1
    | Two -> 2
    | Three -> 3
    | Four -> 4
    | Five -> 5
    | Six -> 6

let sum dice = dice |> List.sumBy (getPoints)

let yachtScore dice =
    dice 
    |> List.distinct 
    |> List.length
    |> function 
    | 1 -> 50
    | _ -> 0

let getScore die dice =
    dice
    |> List.filter (fun d -> d = die)
    |> List.length
    |> (fun count -> count * getPoints die)

let straight ref dice =
    dice
    |> List.sort
    |> (fun dice -> if dice = ref then 30 else 0)

let littleStraight = straight [ One; Two; Three; Four; Five ]
let bigStraight = straight [ Two; Three; Four; Five; Six ]

let fullHouse dice =
    match dice |> List.countBy (id) with
    | [ (_, 2); (_, 3) ] -> sum dice
    | _ -> 0

let fourScore dice =
    dice
    |> List.countBy (id)
    |> List.sortByDescending (snd)
    |> List.head
    |> (function
    | (dice, count) when count >= 4 -> getPoints dice * 4
    | _ -> 0)

let score category dice =
    match category with
    | Yacht -> yachtScore dice
    | Ones -> dice |> getScore One
    | Twos -> dice |> getScore Two
    | Threes -> dice |> getScore Three
    | Fours -> dice |> getScore Four
    | Fives -> dice |> getScore Five
    | Sixes -> dice |> getScore Six
    | Choice -> sum dice
    | LittleStraight -> dice |> littleStraight
    | BigStraight -> dice |> bigStraight
    | FullHouse -> dice |> fullHouse
    | FourOfAKind -> dice |> fourScore

