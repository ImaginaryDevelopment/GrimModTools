module Main

open Fable.Import
open Fable.Helpers.React
open Fable.Helpers.React.Props
open StaticWebGenerator
open Fulma

type IPerson =
    abstract firstName: string
    abstract familyName: string
    abstract birthday: string

// Make sure to always resolve paths to avoid conflicts in generated JS files
// Check fable-splitter README for info about ${entryDir} macro

// let markdownPath = IO.resolve "${entryDir}/../README.md"
let dataPath = IO.resolve "${entryDir}/../data/people.json"
let indexPath = IO.resolve "${entryDir}/../docs/index.html"
let jsDir = "${entryDir}/../docs/js/"
let createTable() =
    let createHead (headers: string list) =
        thead [] [
            tr [] [for header in headers do
                    yield th [] [str header]]
        ]
    let people =
        IO.readFile dataPath
        |> JS.JSON.parse
        |> unbox<IPerson array>
    div [] [
        hr []
        p [] [str """The text above has been parsed from markdown,
                the table below is generated from a React component."""]
        br []
        Table.table [ Table.IsStriped ] [
            createHead ["First Name"; "Family Name"; "Birthday"]
            tbody [] [
                for person in people do
                    yield tr [] [
                        td [] [str person.firstName]
                        td [] [str person.familyName]
                        td [] [str person.birthday]
                    ]
            ]
        ]
    ]
let header =
    header [] [
        h1 [

        ][
            a [
                Href "https://imaginarydevelopment.github.io/GrimModTools/"
                ]
                [str "Grim Mod Tools"]
            form [
                Style [Display "inline-block"]
                Action "https://www.paypal.com/cgi-bin/webscr"
                Method "Post"
                Target "_top"
                ][
                input [Type "hidden";Name "cmd";Value"_s-xclick"]
                input [Type "hidden";Name "hosted_button_id";Value "AGNYY6UJUJNB6"]
                input [
                    Type "image"
                    Src "https://www.paypalobjects.com/en_US/i/scr/pixel.gif"
                    Name "submit"
                    Style [ Border "0"]
                    Alt "PayPal - The safer, easier way to pay online!"
                    ]
                img [
                    Src "https://www.paypalobjects.com/en_US/i/scr/pixel.gif";Alt ""
                    Style [
                        Width "1"
                        Height "1"
                    ]
                ]

            ]
            p [][
                a [Href "https://www.grimdawn.com/forums/"][str "Forums"]
                // no idea how to unsafe in fulma
                // unsafe "&nbsp; &diams; &nbsp;"
                a [Href"https://github.com/ImaginaryDevelopment/GrimModTools/issues"][
                    str "Report Issues or request features"
                ]
                a [Href "https://www.reddit.com/r/Grimdawn/"][str "Reddit"]
            ]
        ]
    ]
let frame titleText content data =
    let cssLink path =
        link [ Rel "stylesheet"; Type "text/css"; Href path ]
    html [] [
        head [] [
            yield title [] [str titleText]
            yield meta [ HTMLAttr.Custom ("httpEquiv", "Content-Type")
                         HTMLAttr.Content "text/html; charset=utf-8" ]
            yield meta [ Name "viewport"
                         HTMLAttr.Content "width=device-width, initial-scale=1" ]
            yield meta [ Name "author"
                         HTMLAttr.Content "ImaginaryDevelopment"]
            yield cssLink "https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"
            yield cssLink "https://cdnjs.cloudflare.com/ajax/libs/bulma/0.5.1/css/bulma.min.css"
            yield cssLink "css/global.css"
        ]
        body [] [
            Fulma.Container.container [] [
                header
                content
                div [][
                    str "Useful links"
                    ul [] [
                        li [][a [Href "https://www.grimdawn.com/forums/showthread.php?t=77514"][str "Mod forum post" ]]
                        li [][ str "Not mod compatible, but useful";ul [] [
                            li[][a [Href "https://www.grimdawn.com/forums/showthread.php?t=35240"][str "Grim Dawn Item Assistant"]]
                        ]]
                    ]
                ]
                footer [] [
                    let today = System.DateTime.Now
                    yield str <| sprintf "v0.0.1 - %i-%i-%i" today.Month today.Day today.Year
                    yield br []
                    yield str "Grim Dawn is a game by "
                    yield a [Href "https://www.grimdawn.com/"][
                        str "Crate Entertainment, LLC."
                    ]
                ]
                data
                script [Src "js/ga.js"] []
            ]
        ]
    ]

let content = Components.content
let render() =
    // let content =
    //     IO.readFile markdownPath
    //     |> parseMarkdownAsReactEl "content"
    let data =
        createTable()
    frame "Grim Dawn - Mod Tools" content data
    |> parseReactStatic
    |> IO.writeFile indexPath
    IO.readFile "src/js/ga.js"
    |> IO.writeFile (IO.resolve <| sprintf "%s%s" jsDir "ga.js")
    printfn "Render complete!"

render()
