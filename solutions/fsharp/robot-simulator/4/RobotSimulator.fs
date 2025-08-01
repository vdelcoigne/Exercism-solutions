module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }

let create direction position = 
    { direction = direction; position = position } 

let advance robot =     
    match (robot.direction, robot.position) with
    | North, (x, y) -> (x, y + 1)
    | South, (x, y) -> (x, y - 1)
    | East, (x, y) -> (x + 1, y)
    | West, (x, y) -> (x - 1, y)
    |> fun position -> { robot with position = position }

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