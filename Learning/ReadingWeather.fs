module ReadingWeather

open System
open Xunit
open FSharp.Data
open FsUnit.Xunit

type Weather =
    JsonProvider<"""
{
 "queryCost": 1,
 "latitude": 52.2356,
 "longitude": 21.0104,
 "resolvedAddress": "Warszawa, Woj. Mazowieckie, Polska",
 "address": "Warsaw, Poland",
 "timezone": "Europe/Warsaw",
 "tzoffset": 2,
 "days": [
  {
   "datetime": "2023-05-01",
   "datetimeEpoch": 1682892000,
   "tempmax": 16.4,
   "pressure": 1020.9,
   "precipsum": 0,
   "precipsumnormal": 0,
   "snowsum": 0,
   "datetimeInstance": "2023-04-30T22:00:00.000Z"
  }
 ]
}
""">

[<Fact>]
let ``Get Pressure`` () =
    let today = DateTime.Today.ToString("yyyy-MM-dd")
    let tomorrow = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd")
    let apiKey = Environment.GetEnvironmentVariable("VISUAL_CROSSING_WEATHER_KEY")

    let url =
        $"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Warsaw%%2C%%20Poland/{today}/{tomorrow}?unitGroup=metric&elements=datetime%%2Cpressure&include=days&key={apiKey}&contentType=json"

    let r =
        Http.RequestString(url, httpMethod = "GET", headers = [ "Accept", "application/json" ])

    let forecast = (Weather.Parse r)
    let todayPressure = (forecast.Days |> Seq.head).Pressure
    let tomorrowPressure = (forecast.Days |> Seq.skip 1 |> Seq.head).Pressure
    todayPressure |> should greaterThan 800M
    tomorrowPressure |> should greaterThan 800M
