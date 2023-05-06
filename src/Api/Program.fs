open Microsoft.AspNetCore.Builder
open System
open Microsoft.Extensions.DependencyInjection

let builder = WebApplication.CreateBuilder()

Engine.execute ForecastPressure.forecast MailSender.send
builder.Services.AddHostedService(fun _ ->
    QuartzHosting.Service(fun () ->
        printfn "Starting execution of ForecastPressure"
        Engine.execute ForecastPressure.forecast MailSender.send))
|> ignore

let app = builder.Build()
app.MapGet("/", Func<string>(fun () -> "Hello 👻!")) |> ignore
app.Run()
