(**
## this is my page
**)

#load "YahooFinance.fsx"

open YahooFinance

let twnk = YahooFinance.PriceHistory("TWNK")

twnk.[..3]

(***Include it***)


let list=[1;2;3]
list 

#r "nuget: Ploty.NET,2.0.0-preview.17"

open Plotly.Net

twnk
|> List.map ( fun day -> day.Date, day.AdjustedClose)
|> GenericChart.toChartHTML

***Include it raw***