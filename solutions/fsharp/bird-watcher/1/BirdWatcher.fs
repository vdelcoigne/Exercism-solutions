module BirdWatcher

let lastWeek =
   [| 0; 2; 5; 3; 7; 8; 4 |]

let yesterday (counts: int[]) : int =
    counts.[5]

let total (counts: int[]) : int =
    counts |> Array.sum

let dayWithoutBirds counts =
    counts |> Array.exists (fun el -> el = 0)

let incrementTodaysCount(counts: int[]): int[] =
    counts.[6] <- counts.[6] + 1
    counts

let oddWeek counts =
  counts = [| 1; 0; 1; 0; 1; 0; 1 |]
