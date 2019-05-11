module Components
open Fable.Import
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma

let select values selected =
    div [] [
        Dropdown.dropdown[

        ][
            Dropdown.menu [][
                Dropdown.content []
                    [
                        Dropdown.Item.a [] [str "Item 1"]
                    ]
            ]

        ]
        select[
        ][]
    ]


let content:React.ReactElement = div [] [
    str "hello components"
    Dropdown.dropdown[

    ][
        Dropdown.menu [][
            Dropdown.content []
                [
                    Dropdown.Item.a [] [str "Item 1"]
                ]
        ]

    ]
    ]