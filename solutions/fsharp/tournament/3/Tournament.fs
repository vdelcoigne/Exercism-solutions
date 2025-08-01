module Tournament

type Outcome =
    | Win
    | Loss
    | Draw

type Results =
    { Wins: int
      Losses: int
      Draws: int }
    static member Init =
        { Wins = 0; Losses = 0; Draws = 0 }

    member this.MatchPlayed =
        this.Wins + this.Losses + this.Draws

    member this.Points =
        this.Wins * 3 + this.Draws * 1

type Team =
    { Name: string
      Results: Results }
    static member Create name = { Name = name; Results = Results.Init }

let teamScore outcome team =
    let results =
        match outcome with
        | Win -> { team.Results with Wins = team.Results.Wins + 1 }
        | Draw -> { team.Results with Draws = team.Results.Draws + 1 }
        | Loss -> { team.Results with Losses = team.Results.Losses + 1 }

    { team with Results = results }

let display team =
    let pad input = $"{input, 3}"

    $"{team.Name, -31}|{team.Results.MatchPlayed |> pad} |{team.Results.Wins |> pad} |{team.Results.Draws |> pad} |{team.Results.Losses |> pad} |{team.Results.Points |> pad}"

let getTournamentResults (teams: Team list) =
    let lines =
        teams
        |> List.sortBy (fun team -> -team.Results.Points, team.Name)
        |> List.map display

    let header =
        "Team                           | MP |  W |  D |  L |  P"

    header :: lines

let processMatch (teams: Team list) (row: string) =
    let inverted =
        function
        | Win -> Loss
        | Loss -> Win
        | Draw -> Draw

    let parseOutcome =
        function
        | "win" -> Win
        | "draw" -> Draw
        | "loss" -> Loss
        | _ -> failwith "Invalid outcome!"

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
                let newList =
                    teams |> List.filter (fun t -> t <> team)

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
                let newList =
                    teams |> List.filter (fun t -> t <> team)

                let newTeam =
                    team |> teamScore (outcome |> inverted)

                newTeam :: newList

    teams

let tally (input: string list) =
    input 
    |> List.fold processMatch list.Empty 
    |> getTournamentResults

