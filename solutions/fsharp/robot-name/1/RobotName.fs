module RobotName

open System

type Robot(name) = 
    let mutable mutableName = name
    member this.Name = mutableName
    member this.SetName n = mutableName <- n

let randomizer = Random (int DateTime.UtcNow.Ticks)

let generateName() =
    let f1 = char (randomizer.Next(65, 90))
    let f2 = char (randomizer.Next(65, 90))
    sprintf "%c%c%d" f1 f2 (randomizer.Next(999))

let mkRobot() = 
    new Robot(generateName())

let name (robot:Robot) = 
    robot.Name

let reset (robot:Robot) =
    robot.SetName(generateName())
    robot