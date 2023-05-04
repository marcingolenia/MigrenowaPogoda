module QuartzHosting

open System.Threading.Tasks
open Microsoft.Extensions.Hosting
open Quartz
open Quartz.Impl
open Quartz.Spi

type JobFactory(job: unit -> Async<unit>) =
    interface IJobFactory with
        member _.NewJob(bundle, _) =
            match bundle.JobDetail.JobType with
            | _type when _type = typeof<NoonJobExecution.Job> -> NoonJobExecution.Job job :> IJob
            | _ -> failwith "Not supported Job"

        member _.ReturnJob _ = ()

type Service(job: unit -> Async<unit>) =
    let mutable scheduler: IScheduler = null

    interface IHostedService with

        member _.StartAsync cancellation =
            printfn $"Starting Quartz Hosting Service"

            task {
                let! schedulerConfig = StdSchedulerFactory().GetScheduler()
                schedulerConfig.JobFactory <- JobFactory job
                let! _ = schedulerConfig.ScheduleJob(NoonJobExecution.job, NoonJobExecution.trigger, cancellation)
                do! schedulerConfig.Start cancellation
                scheduler <- schedulerConfig
            }
            :> Task

        member _.StopAsync cancellation =
            printfn $"Stopping Quartz Hosting Service"
            scheduler.Shutdown cancellation
