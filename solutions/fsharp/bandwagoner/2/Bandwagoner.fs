module Bandwagoner

type Coach = 
    { Name: string
      FormerPlayer: bool }

type Stats =
    { Wins: int
      Losses: int }

type Team = {
    Name: string
    Coach: Coach
    Stats: Stats
}

let createCoach name formerPlayer =
    { Name = name; FormerPlayer = formerPlayer }

let createStats wins losses =
    { Wins = wins; Losses = losses }

let createTeam name coach stats =
    { Name = name; Coach = coach; Stats = stats }

let replaceCoach team coach =
    { team with Coach = coach }

let isSameTeam = (=)

let rootForTeam team =
    team.Name = "Chicago Bulls" ||
    team.Coach.Name = "Gregg Popovich" ||
    team.Coach.FormerPlayer ||
    team.Stats.Wins >= 60 || 
    team.Stats.Losses > team.Stats.Wins
