module Allergies

open System

type Allergen = 
| Eggs
| Peanuts 
| Shellfish 
| Strawberries 
| Tomatoes 
| Chocolate 
| Pollen 
| Cats

let getScore =
    function
    | Eggs -> 1
    | Peanuts -> 2
    | Shellfish -> 4
    | Strawberries -> 8
    | Tomatoes -> 16
    | Chocolate -> 32
    | Pollen -> 64
    | Cats -> 128

let getAllergen =
    function
    | 1 -> Some Eggs
    | 2 -> Some Peanuts
    | 4 -> Some Shellfish
    | 8 -> Some Strawberries
    | 16 -> Some Tomatoes
    | 32 -> Some Chocolate
    | 64 -> Some Pollen
    | 128 -> Some Cats
    | _ -> None

let allergicTo codedAllergies allergen =
    let score = getScore allergen
    (score &&& codedAllergies) = score

let list codedAllergies =
    [ 0 .. 7 ]
    |> List.map (fun shift -> (1 <<< shift) &&& codedAllergies)
    |> List.choose (getAllergen)