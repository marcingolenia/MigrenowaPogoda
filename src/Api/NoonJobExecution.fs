module NoonJobExecution

open System.Threading.Tasks
open Quartz

let trigger =
    TriggerBuilder
        .Create()
        .WithCronSchedule("0 0 17 * * ?")
        .Build()

type Job(execute: unit -> Task) =
    interface IJob with
        member _.Execute _ = execute()

let job = JobBuilder.Create<Job>().Build()
