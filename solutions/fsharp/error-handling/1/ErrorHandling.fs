module ErrorHandling

open System

let handleErrorByThrowingException() = raise (Exception())

let handleErrorByReturningOption (input: string) =
    try
        input
        |> int
        |> Some
    with _ -> None

let handleErrorByReturningResult (input: string) =
    try
        input
        |> int
        |> Ok
    with _ -> Error "Could not convert input to integer"

let bind switchFunction twoTrackInput =
    match twoTrackInput with
    | Ok s -> switchFunction s
    | Error f -> Error f

let cleanupDisposablesWhenThrowingException (resource: IDisposable) =
    resource.Dispose()
    raise (Exception())
