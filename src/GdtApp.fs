module GdtApp
open Fable.Import
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma
open Data
open Schema
open Components
let content:React.ReactElement =
    let classDrop =
        let kvs = gdClasses |> List.map(fun cls -> cls.name, cls.name)
        select kvs None ignore
    div [Class "container-fluid"] [
        table [Class "table table-dark"] [
            thead [] [
                tr [] [
                    yield th [Scope "col"] [str "Class"]
                    yield! allTagDisplays
                        |> List.map(fun name -> th [Scope "col"][str name])
                ]
            ]
            tbody [] (
                gdClasses
                |> List.map(fun cls ->
                    tr [Class <| string cls.theme][
                        yield td[][
                            str cls.name
                        ]
                        yield! (
                            allTags
                            |> List.map(GdClass.HasSkillWithTag cls)
                            |> List.map(fun hasTag ->
                                td[][
                                    yield input [Type "checkbox";Disabled true;Checked hasTag]
                                ]
                            )
                        )
                    ]
                )
            )

        ]
        str "hello components"
        classDrop
        classDrop
    ]