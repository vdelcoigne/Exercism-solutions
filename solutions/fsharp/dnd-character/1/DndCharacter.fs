module DndCharacter

open System 

let rollDice = 
    let rnd = Random()

    fun () -> rnd.Next(1, 6)

let modifier x =
    Math.Floor (((x - 10) |> float) / 2.) |> int

let ability() = 
    Array.init 4 (fun _ -> rollDice()) 
    |> Array.sortByDescending (id) 
    |> Array.take 3
    |> Array.sum

type Character = {
    Strength: int
    Dexterity : int
    Constitution : int
    Intelligence : int
    Wisdom : int
    Charisma : int
    Hitpoints : int
}

let createCharacter() =
    let constitution = ability()
    {
        Strength = ability()
        Dexterity = ability()
        Constitution = constitution
        Intelligence = ability()
        Wisdom = ability()
        Charisma = ability()
        Hitpoints =  10 + modifier(constitution)
    }
 
 