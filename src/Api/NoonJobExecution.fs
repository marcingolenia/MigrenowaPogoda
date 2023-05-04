module NoonJobExecution

open System.Threading.Tasks
open Quartz

let trigger =
    TriggerBuilder
        .Create()
        .WithCronSchedule("0 0 * ? * *")//0 0 12 * * ?
        .Build()

type Job(execute: unit -> Async<unit>) =
    interface IJob with
        member _.Execute _ =
            execute() |> Async.StartAsTask :> Task

let job = JobBuilder.Create<Job>().Build()
