module Gigasecond

open System

let add (beginDate:DateTime) =
    Math.Pow(10.0, 9.0) |> beginDate.AddSeconds
