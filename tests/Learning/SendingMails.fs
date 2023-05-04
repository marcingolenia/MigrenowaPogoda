module SendingMails

open System
open Mailjet.Client.TransactionalEmails
open Xunit
open Mailjet.Client

[<Fact>]
let ``My test`` () =
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
