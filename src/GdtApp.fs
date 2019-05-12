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

let inline classDrop classes onChange =
    let kvs = classes |> List.map(fun cls -> cls.name, cls.name)
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
type AppState = {ClassFocus: string;ClassCount:int;ExcludeGrimarillion:bool}

type App(initProps:AppProps) =
    inherit React.Component<AppProps,AppState>(initProps)
    do base.setInitState {ClassFocus="";ClassCount=gdClasses.Length;ExcludeGrimarillion=false}
    member x.getFocusedClass () =
        if System.String.IsNullOrWhiteSpace x.state.ClassFocus then
            None
        else
            // gdClasses is ok here, we're searching for a selected class
            gdClasses |> List.tryFind(fun c -> c.name = x.state.ClassFocus)
    member x.getIncludedTags classes  =
        // include only tags that the focused class has
        match x.getFocusedClass() with
        | None -> getAllTags classes
        | Some cls -> getClassTags cls |> List.distinctBy Tag.ToDisplay

    override this.render() =
        let classes = if this.state.ExcludeGrimarillion then gdClasses |> List.filter(fun cls -> cls.theme = Theme.GD) else gdClasses
        div [

        ] [
            str this.state.ClassFocus
            div [Class "row"][
                div[Class "col"][
                    label[(* Labelfor "excludeGrimarillion" *)][str "Exclude Grimarillion"]
                ]
                div[Class "col"][
                    input[Type "checkbox";Checked this.state.ExcludeGrimarillion;OnClick(fun _ -> this.setState(fun s _ -> {s with ExcludeGrimarillion = not s.ExcludeGrimarillion}))]

                ]
            ]
            classDrop classes (fun e ->
                printfn "Changing"
                this.setState(fun s p ->
                    {s with ClassFocus=e}))
            gdTable (this.getIncludedTags classes) classes
        ]

let inline app props = ofType<App,_,_> props []

let content:React.ReactElement = app AppProps