module Tournament

type Outcome =
    | Win
    | Loss
    | Draw

type Team =
    { Name: string
      Results: int * int * int }
    static member Create name = { Name = name; Results = (0, 0, 0) }

    member this.Points =
        let win, draw, _ = this.Results

        win * 3 + draw * 1

    member this.MatchPlayed =
        let win, draw, loss = this.Results

        win + draw + loss

let parseOutcome =
    function
    | "win" -> Win
    | "draw" -> Draw
    | "loss" -> Loss
    | _ -> failwith "Invalid outcome!"

let teamScore outcome team =
    let win, draw, loss = team.Results

    let results =
        match outcome with
        | Win -> (win + 1, draw, loss)
        | Draw -> (win, draw + 1, loss)
        | Loss -> (win, draw, loss + 1)

    { team with Results = results }

let display team =
    let win, draw, loss = team.Results

    let spaceToInsert = new string(' ', 31 - team.Name.Length)
//    let x = System.String.Format("{0, 3}", team.Points)
    
    $"%s{team.Name}{spaceToInsert}|  %d{team.MatchPlayed} |  %d{win} |  %d{draw} |  %d{loss} |{team.Points, 3}"


let printTeams (teams: Team list) =
    let text =
        teams
        |> List.sortBy(fun team -> -team.Points, team.Name) 
        |> List.map display

    let header = "Team                           | MP |  W |  D |  L |  P"

    header :: text

let folder (teams: Team list) (row: string) =
    let inverted =
        function
        | Win -> Loss
        | Loss -> Win
        | Draw -> Draw

    let input = row.Split(';')

    let homeTeam = input[0]
    let awayTeam = input[1]
    let outcome = input[2] |> parseOutcome

    let teams =
        teams
        |> List.tryFind (fun t -> t.Name = homeTeam)
        |> function
            | None ->
                (Team.Create homeTeam |> teamScore outcome)
                :: teams
            | Some team ->
                let newList = teams |> List.filter(fun t -> t <> team)
                let newTeam = team |> teamScore outcome
                newTeam :: newList 

    let teams =
        teams
        |> List.tryFind (fun t -> t.Name = awayTeam)
        |> function
            | None ->
                (Team.Create awayTeam
                 |> teamScore (outcome |> inverted))
                :: teams
            | Some team ->
                let newList = teams |> List.filter(fun t -> t <> team)
                let newTeam = team |> teamScore (outcome |> inverted)
                newTeam :: newList 

    teams

let tally (input: string list) =
    let teams = input |> List.fold folder list.Empty

    teams |> printTeams

