module DndCharacter

open System 

let rollDice = 
    let rnd = Random()

    fun () -> rnd.Next(1, 7)

let modifier x = (float x - 10.0) / 2. |> floor |> int    

let ability() = 
    Array.init 4 (fun _ -> rollDice()) 
    |> Array.sort
    |> Array.tail
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
 
 