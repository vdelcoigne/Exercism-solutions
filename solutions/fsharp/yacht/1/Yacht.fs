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

let getYachtScore dice =
    if (dice |> List.distinct |> List.length = 1) then
        50
    else
        0

let getPoints =
    function
    | One -> 1
    | Two -> 2
    | Three -> 3
    | Four -> 4
    | Five -> 5
    | Six -> 6

let sum dice = dice |> List.sumBy (getPoints)

let getScore die dice =
    let count =
        dice
        |> List.filter (fun d -> d = die)
        |> List.length

    count * getPoints die

let littleStraight dice =
    let sorted = dice |> List.sort

    if (sorted = [ One; Two; Three; Four; Five ]) then
        30
    else
        0

let bigStraight dice =
    let sorted = dice |> List.sort

    if (sorted = [ Two; Three; Four; Five; Six ]) then
        30
    else
        0

let fullHouse dice =
    let isFullHouse =
        match dice |> List.countBy (id) with
        | [ (_, 2); (_, 3) ] -> true
        | _ -> false

    if (isFullHouse) then sum dice else 0

let getFourScore dice =
    let throw =
        dice
        |> List.countBy (id)
        |> List.sortByDescending (snd)
        |> List.head

    match throw with
    | (d, count) when count >= 4 -> getPoints d * 4
    | _ -> 0

let score category dice =
    match category with
    | Yacht -> getYachtScore dice
    | Ones -> getScore One dice
    | Twos -> getScore Two dice
    | Threes -> getScore Three dice
    | Fours -> getScore Four dice
    | Fives -> getScore Five dice
    | Sixes -> getScore Six dice
    | Choice -> sum dice
    | LittleStraight -> dice |> littleStraight
    | BigStraight -> dice |> bigStraight
    | FullHouse -> dice |> fullHouse
    | FourOfAKind -> dice |> getFourScore

