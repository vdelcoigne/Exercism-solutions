module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }

let create direction position = 
    { direction = direction; position = position } 

let advance robot =     
    let (x, y) = robot.position

    let newPos = 
        match robot.direction with
        | North -> (x, y + 1)
        | South -> (x, y - 1)
        | East -> (x + 1, y)
        | West -> (x - 1, y)

    { robot with position = newPos }

let rotateRight robot = 
    let newDir = 
        match robot.direction with
        | North -> East
        | East -> South
        | South -> West
        | West -> North
    
    { robot with direction = newDir }

let rotateLeft robot = 
    let newDir = 
        match robot.direction with
        | North -> West
        | East -> North
        | South -> East
        | West -> South
    
    { robot with direction = newDir }

let run robot = function
    | 'A' -> robot |> advance 
    | 'L' -> robot |> rotateLeft
    | 'R' -> robot |> rotateRight
    | _ -> robot

let move (instructions:string) (robot:Robot) = 
    instructions.ToCharArray()
    |> Array.fold run robot 