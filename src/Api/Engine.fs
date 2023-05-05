module Engine

open System.Threading.Tasks
open Microsoft.FSharp.Core

[<Literal>]
let BestPressure = 1013

[<Literal>]
let HpaMaxDifference = 6

let lowPressureLimit = BestPressure - HpaMaxDifference
let highPressureLimit = BestPressure + HpaMaxDifference


type PressureEvent =
    | PressureDrop of decimal * decimal
    | LowPressure of decimal
    | PressureUp of decimal * decimal
    | HighPressure of decimal

type Report = { intro: string }

let execute (readPressures: unit -> decimal * decimal) (sendNotification: decimal -> PressureEvent -> Task) =
    let todaysPressure, tomorrowsPressure = readPressures ()

    let pressureEvent =
        match todaysPressure - tomorrowsPressure with
        | difference when difference > HpaMaxDifference -> Some(PressureDrop(todaysPressure, tomorrowsPressure))
        | difference when difference < -HpaMaxDifference -> Some(PressureUp(todaysPressure, tomorrowsPressure))
        | _ when tomorrowsPressure > highPressureLimit -> Some(HighPressure tomorrowsPressure)
        | _ when tomorrowsPressure < lowPressureLimit -> Some(LowPressure tomorrowsPressure)
        | _ -> None

    match pressureEvent with
    | Some event -> sendNotification BestPressure event 
    | None -> Task.CompletedTask
