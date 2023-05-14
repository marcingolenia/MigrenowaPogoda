module ForecastPressure

open System
open FSharp.Data

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
      "pressure": 1019.8,
      "hours": [
        {
          "pressure": 1023
        },
        {
          "pressure": 1023
        },
        {
          "pressure": 1023
        }
      ]
    },
    {
      "pressure": 1009.9,
      "hours": [
        {
          "pressure": 1015
        },
        {
          "pressure": 1014
        },
        {
          "pressure": 1007
        }
      ]
    }
  ]
}
""">

let forecast() =
    let today = DateTime.Today.ToString("yyyy-MM-dd")
    let tomorrow = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd")
    let apiKey = Environment.GetEnvironmentVariable("VISUAL_CROSSING_WEATHER_KEY")
    let url =
        $"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Warsaw%%2C%%20Poland/{today}/{tomorrow}?unitGroup=metric&elements=pressure&include=hours&key={apiKey}&contentType=json"
    let response =
        Http.RequestString(url, httpMethod = "GET", headers = [ "Accept", "application/json" ])
    let forecast = (Weather.Parse response)
    let todayPressure = (forecast.Days |> Seq.head).Hours |> Array.maxBy(fun p -> p.Pressure)
    let tomorrowPressure = (forecast.Days |> Seq.skip 1 |> Seq.head).Hours |> Array.minBy(fun p -> p.Pressure)
    (todayPressure.Pressure, tomorrowPressure.Pressure)