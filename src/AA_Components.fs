module Components
open Fable.Import
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma

let select values selected onChange =
    div [] [
        select[ // https://stackoverflow.com/questions/55093894/how-to-add-the-selected-attribute-to-a-select-option-in-fable
            match selected with
            | None -> ()
            | Some v -> yield Value v
            yield OnChange (fun ev ->
                let value = !!ev.target?value
                onChange value
            )
        ](
            values
            |> List.map(fun (k,v) ->
                option [Value v][str k]
            )
        )
    ]
let testDropdown () =
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