module RobotName

open System

type Robot = { Name:string }

let randomizer = Random (int DateTime.UtcNow.Ticks)

let generateName() =
    let letter() = char (randomizer.Next(int 'A', int 'Z'))
    sprintf "%c%c%03d" (letter()) (letter()) (randomizer.Next(999))

let mkRobot() = { Name = generateName() }

let name (robot:Robot) = robot.Name

let reset (robot:Robot) = { robot with Name = generateName() }
