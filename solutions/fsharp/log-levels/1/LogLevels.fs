module LogLevels

let message (logLine: string): string = 
    let array = logLine.Split(':') 
    array.[1].Trim()

let logLevel(logLine: string): string = 
    let array = logLine.Split(':') 
    array.[0].Replace("[","").Replace("]", "").Trim().ToLower()

let reformat(logLine: string): string = 
    let msg = message logLine
    let level = logLevel logLine
    $"{msg} ({level})"
