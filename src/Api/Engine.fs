module Engine

open System.Threading.Tasks
open Microsoft.FSharp.Core

[<Literal>]
let HpaMaxDifference = 8

type PressureEvent =
    | PressureDrop of int * int
    | PressureUp of int * int

let execute (readPressures: unit -> int * int) (sendNotification: PressureEvent -> Task) =
    let todayPressure, tomorrowPressure = readPressures ()

    let pressureEvent =
        match todayPressure - tomorrowPressure with
        | difference when difference > HpaMaxDifference -> Some(PressureDrop(todayPressure, tomorrowPressure))
        | difference when difference < -HpaMaxDifference -> Some(PressureUp(todayPressure, tomorrowPressure))
        | _ -> None

    match pressureEvent with
    | Some event -> sendNotification event 
    | None -> Task.CompletedTask
