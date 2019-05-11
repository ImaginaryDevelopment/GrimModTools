module GdtApp
open Fable.Import
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma
open Data
open Components
let content:React.ReactElement =
    let classDrop =
        let kvs = gdClasses |> List.map(fun cls -> cls.name, cls.name)
        select kvs None ignore
    div [] [
        str "hello components"
        classDrop
    ]