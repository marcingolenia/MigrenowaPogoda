open Mailjet.Client
open Mailjet.Client.TransactionalEmails
open Microsoft.AspNetCore.Builder
open System
open Microsoft.Extensions.DependencyInjection

let send () =
    task {
        let client =
            MailjetClient(
                Environment.GetEnvironmentVariable("MJ_APIKEY_PUBLIC"),
                Environment.GetEnvironmentVariable("MJ_APIKEY_PRIVATE")
            )

        let email =
            TransactionalEmailBuilder()
                .WithFrom(SendContact("marcingolenia@gmail.com"))
                .WithSubject("Migrenowa Pogoda")
                .WithHtmlPart("<h1>Header</h1>")
                .WithTo(SendContact("marcingolenia@gmail.com"))
                .Build()

        let! _ = client.SendTransactionalEmailAsync email
        ()
    }

let builder = WebApplication.CreateBuilder()
builder.Services.AddHostedService(fun _ -> QuartzHosting.Service (fun() -> send() |> Async.AwaitTask)) |> ignore
let app = builder.Build()
app.MapGet("/", Func<string>(fun () -> "Hello World 3!")) |> ignore
app.Run()