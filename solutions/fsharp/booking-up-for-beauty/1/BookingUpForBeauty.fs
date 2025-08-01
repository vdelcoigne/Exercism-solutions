module BookingUpForBeauty

open System
open System.Globalization

let parseDate s (format:string) = 
    DateTime.TryParseExact(s, format, CultureInfo.InvariantCulture, DateTimeStyles.None)
    
let schedule (appointmentDateDescription: string): DateTime = 
    let parse = parseDate appointmentDateDescription 
    let f1 = parse "M/dd/yyyy HH:mm:ss" 
    let f2 = parse "MMMM d, yyyy HH:mm:ss" 
    let f3 = parse "dddd, MMMM d, yyyy HH:mm:ss" 

    if (fst f1) then snd f1 
    elif (fst f2) then snd f2
    elif (fst f3) then snd f3
    else failwith "Could not parse"

let hasPassed (appointmentDate: DateTime): bool = 
    appointmentDate < DateTime.Now

let isAfternoonAppointment (appointmentDate: DateTime): bool =
    appointmentDate.Hour >= 12 && appointmentDate.Hour < 18

let description (appointmentDate: DateTime): string = 
    sprintf "You have an appointment on %s." (appointmentDate.ToString("M/d/yyyy h:mm:ss tt"))

let anniversaryDate(): DateTime = 
    DateTime(DateTime.Today.Year, 9, 15)
