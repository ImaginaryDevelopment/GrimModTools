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
    Dropdown.dropdown [ Dropdown.IsHoverable ]
        [ div [ ]
            [ Button.button [ ]
                [ span [ ]
                    [ str "Dropdown" ]
                  Icon.icon [ Icon.Size IsSmall ][]
                    ] ]
          Dropdown.menu [ ]
            [ Dropdown.content [ ]
                [ Dropdown.Item.a [ ]
                    [ str "Item n°1" ]
                  Dropdown.Item.a [ ]
                    [ str "Item n°2" ]
                  Dropdown.Item.a [ Dropdown.Item.IsActive true ]
                    [ str "Item n°3" ]
                  Dropdown.Item.a [ ]
                    [ str "Item n°4" ]
                  Dropdown.divider [ ]
                  Dropdown.Item.a [ ]
                    [ str "Item n°5" ] ] ] ]
    ]