module BookingUpForBeauty

open System

let schedule appointmentDateDescription = 
    DateTime.Parse appointmentDateDescription

let hasPassed appointmentDate = 
    appointmentDate < DateTime.Now

let isAfternoonAppointment (appointmentDate: DateTime) =
    appointmentDate.Hour >= 12 && appointmentDate.Hour < 18

let description (appointmentDate: DateTime) = 
    $"You have an appointment on {appointmentDate}."

let anniversaryDate(): DateTime = 
    DateTime(DateTime.Today.Year, 9, 15)
