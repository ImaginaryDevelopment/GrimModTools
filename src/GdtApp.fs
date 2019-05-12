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

let classDrop onChange =
    let kvs = gdClasses |> List.map(fun cls -> cls.name, cls.name)
    select (("No class filter",""):: kvs) None onChange

let gdTable allTags classes : React.ReactElement =
    let allTagDisplays = getTagDisplays allTags
    div [Class "container-fluid"] [
        table [Class "table table-dark"] [
            thead [] [
                tr [] [
                    yield th [Scope "col"] [str <| sprintf "Class(%i)" gdClasses.Length]
                    yield! allTagDisplays
                        |> List.map(fun name -> th [Scope "col"][str name])
                ]
            ]
            tbody [] (
                classes
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
type AppProps = AppProps
type AppState = {ClassFocus: string;ClassCount:int}

type App(initProps:AppProps) =
    inherit React.Component<AppProps,AppState>(initProps)
    do base.setInitState {ClassFocus="";ClassCount=gdClasses.Length}
    member x.getFocusedClass() =
        if System.String.IsNullOrWhiteSpace x.state.ClassFocus then
            None
        else
            gdClasses |> List.tryFind(fun c -> c.name = x.state.ClassFocus)
    member x.getIncludedTags() =
        // include only tags that the focused class has
        match x.getFocusedClass() with
        | None -> allTags
        | Some cls -> getClassTags cls |> List.distinctBy Tag.ToDisplay

    override x.render() =
        div [

        ] [
            str x.state.ClassFocus
            classDrop (fun e ->
                printfn "Changing"
                x.setState(fun s p ->
                    {s with ClassFocus=e}))
            gdTable (x.getIncludedTags()) gdClasses
        ]

let inline app props = ofType<App,_,_> props []

let content:React.ReactElement = app AppProps