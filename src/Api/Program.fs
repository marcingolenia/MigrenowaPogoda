open Microsoft.AspNetCore.Builder
open System
open Microsoft.Extensions.DependencyInjection

let builder = WebApplication.CreateBuilder()
builder.Services.AddHostedService(fun _ -> QuartzHosting.Service (fun () -> Engine.execute ForecastPressure.forecast MailSender.send)) |> ignore
let app = builder.Build()
app.MapGet("/", Func<string>(fun () -> "Hello 👻!")) |> ignore
app.Run()