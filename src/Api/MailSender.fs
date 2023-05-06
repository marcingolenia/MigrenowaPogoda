module MailSender

open System
open System.Threading.Tasks
open Engine
open Mailjet.Client
open Mailjet.Client.TransactionalEmails
open Newtonsoft.Json

[<Literal>]
let Intro =
    """
Zła wiadomość, niestety jutro ciśnienie: 
"""

let buildContent bestPressure (pressureEvent: PressureEvent) =
    Intro
    + match pressureEvent with
      | PressureDrop (today, tomorrow) ->
          $"Spadnie znacznie z {today} hPa na {tomorrow} hPa. Zalecamy poranny spacer i kawę. Zadbaj o sen, unikaj stresu i nawadniaj się."
      | PressureUp (today, tomorrow) ->
          $"Wzrośnie znacznie z {today} hPa na {tomorrow} hPa. Zadbaj o sen, unikaj stresu i nawadniaj się."
      | HighPressure pressure ->
          $"Będzie wysokie {pressure} hPa, gdzie {bestPressure} hPa jest optymalne. Zadbaj o sen, unikaj stresu i nawadniaj się."
      | LowPressure pressure ->
          $"Będzie niskie {pressure} hPa, gdzie {bestPressure} hPa jest optymalne. Zalecamy poranny spacer i kawę. Zadbaj o sen, unikaj stresu  i nawadniaj się."

let send bestPressure (pressureEvent: PressureEvent) =
    let recipients =
        Environment.GetEnvironmentVariable "MIGRENOWA_POGODA_MAILS"
        |> JsonConvert.DeserializeObject<string list>
        |> List.ofSeq

    let client =
        MailjetClient(
            Environment.GetEnvironmentVariable "MJ_APIKEY_PUBLIC",
            Environment.GetEnvironmentVariable "MJ_APIKEY_PRIVATE"
        )

    let email =
        TransactionalEmailBuilder()
            .WithFrom(SendContact "marcingolenia@gmail.com")
            .WithSubject($"Migrenowa Pogoda, zadbaj o siebie jutro! ({DateTime.Today.AddDays 1:``yyyy-MM-dd``})")
            .WithHtmlPart(MailTemplate.withTextContent (buildContent bestPressure pressureEvent))
            .WithTo(recipients |> List.map SendContact)
            .Build()

    task {
        let! _ = client.SendTransactionalEmailAsync email
        ()
    }
    :> Task
