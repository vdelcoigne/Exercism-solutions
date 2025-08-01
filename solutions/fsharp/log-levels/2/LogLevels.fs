module LogLevels

let parseLog logLine = 
    let m = System.Text.RegularExpressions.Regex.Match(logLine, "\[(?<level>\w+)\]:(?<message>.*)")
    (m.Groups.["level"].Value.ToLower(), m.Groups.["message"].Value.Trim())

let message logLine = 
    logLine |> parseLog |> snd

let logLevel logLine = 
    logLine |> parseLog |> fst

let reformat(logLine: string): string = 
    let (level, msg) = logLine |> parseLog
    $"{msg} ({level})"
