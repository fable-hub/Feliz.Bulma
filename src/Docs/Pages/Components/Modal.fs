module Docs.Pages.Components.Modal

open Feliz
open Feliz.Bulma
open Docs.Helpers

[<ReactComponent>]
let ModalComponent () =
    let modalState, toggleState = React.useState (false)

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Modal"
        Html.hr []
        Bulma.content [
            Bulma.title "Basic"
            Bulma.columns [
                Bulma.column [
                    Bulma.button.button [
                        prop.ariaHasPopup true
                        prop.target "modal-sample"
                        prop.text "Launch example modal"
                        prop.onClick (fun _ -> toggleState (true))
                    ]
                    Bulma.modal [
                        prop.id "modal-sample"
                        if modalState then
                            Bulma.modal.isActive
                        prop.children [
                            Bulma.modalBackground []
                            Bulma.modalContent [ Bulma.box [ Html.h1 "Modal content" ] ]
                            Bulma.modalClose [ prop.onClick (fun _ -> toggleState (false)) ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """let modalState, toggleState = React.useState(false)

Bulma.button.button [
    prop.ariaHasPopup true
    prop.target "modal-sample"
    prop.text "Launch example modal"
    prop.onClick (fun _ -> toggleState(true))
]
Bulma.modal [
    prop.id "modal-sample"
    if modalState then Bulma.modal.isActive
    prop.children [
        Bulma.modalBackground []
        Bulma.modalContent [
            Bulma.box [
                Html.h1 "Modal content"
            ]
        ]
        Bulma.modalClose [ prop.onClick (fun _ -> toggleState(false))]
    ]
]"""
                ]
            ]
        ]
    ]

let view = ModalComponent()
