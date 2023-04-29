open Microsoft.AspNetCore.Builder
open System

let builder = WebApplication.CreateBuilder()
let app = builder.Build()

app.MapGet("/", Func<string>(fun () -> "Hello World 2!")) |> ignore
app.Run()