module GdtApp
open Fable.Import
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import
open Fulma
open GrimModTools.Data
open Schema
open Components
// type Model = {
//     ClassInclude : string list
// }
// let init =
//     {
//         ClassInclude = List.empty
//     }

// type Message =
//     |ChangeClassFilter of string

type AppProps = AppProps
type AppState = {ClassFilter : string}

let classDrop onChange =
    let kvs = gdClasses |> List.map(fun cls -> cls.name, cls.name)
    select (("No class filter",""):: kvs) None onChange
type App(initProps:AppProps) =
    inherit React.Component<AppProps,AppState>(initProps)
    do base.setInitState {ClassFilter=""}
    override x.render() =
        div [

        ] [
            str x.state.ClassFilter
            classDrop (fun e ->
                printfn "Changing"
                x.setState(fun s p ->
                    {s with ClassFilter=e}))
        ]
let inline app props = ofType<App,_,_> props []
let content:React.ReactElement =
    div [Class "container-fluid"] [
        app(AppProps)
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
    ]