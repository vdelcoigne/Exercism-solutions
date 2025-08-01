module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }

let create direction position = 
    { direction = direction; position = position } 

let advance robot =     
    let (x, y) = robot.position
    let newPosition = 
        match robot.direction with
        | North -> (x, y + 1)
        | South -> (x, y - 1)
        | East -> (x + 1, y)
        | West -> (x - 1, y)
    { robot with position = newPosition }

let left = function
    | North -> West
    | East -> North
    | South -> East
    | West -> South

let right = function
    | North -> East
    | East -> South
    | South -> West
    | West -> North
        
let rotate getDirection robot = 
    { robot with direction = getDirection robot.direction }

let run robot = function
    | 'A' -> robot |> advance 
    | 'L' -> robot |> rotate left
    | 'R' -> robot |> rotate right
    | _ -> robot

let move (instructions:string) (robot:Robot) = 
    instructions.ToCharArray()
    |> Array.fold run robot 