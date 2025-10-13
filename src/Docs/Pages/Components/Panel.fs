module Docs.Pages.Components.Panel

open Feliz
open Feliz.Bulma
open Docs.Helpers

let view =
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Panel"
        Html.hr []
        Bulma.content [
            Bulma.columns [
                Bulma.column [
                    column.isHalf
                    prop.children [
                        Bulma.panel [
                            Bulma.panelHeading [ prop.text "Repositories" ]
                            Bulma.panelBlock.div [
                                Bulma.control.div [
                                    control.hasIconsLeft
                                    prop.children [
                                        Bulma.input.text [ prop.placeholder "Search" ]
                                        Bulma.icon [
                                            icon.isLeft
                                            prop.children [
                                                Html.i [ prop.className "fas fa-search" ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Bulma.panelTabs [
                                Html.a [
                                    prop.className "is-active"
                                    prop.text "All"
                                ]
                                Html.a [ prop.text "Public" ]
                                Html.a [ prop.text "Private" ]
                                Html.a [ prop.text "Sources" ]
                                Html.a [ prop.text "Forks" ]
                            ]
                            Bulma.panelBlock.div [
                                prop.className "is-active"
                                prop.children [
                                    Bulma.panelIcon [ Html.i [ prop.className "fas fa-book" ] ]
                                    Html.span "Feliz.Bulma"
                                ]
                            ]
                            Bulma.panelBlock.div [
                                Bulma.panelIcon [ Html.i [ prop.className "fas fa-book" ] ]
                                Html.span "Feliz"
                            ]
                            Bulma.panelBlock.div [
                                Bulma.panelIcon [ Html.i [ prop.className "fas fa-book" ] ]
                                Html.span "Fable"
                            ]
                            Bulma.panelBlock.div [
                                Bulma.panelIcon [ Html.i [ prop.className "fas fa-code-branch" ] ]
                                Html.span "dzoukr/feliz.bulma"
                            ]
                            Bulma.panelBlock.div [
                                Bulma.button.button [
                                    color.isLink
                                    button.isOutlined
                                    button.isFullWidth
                                    prop.text "Reset all filters"
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    column.isHalf
                    prop.children [
                        Code.render
                            """Bulma.panel [
    Bulma.panelHeading [ prop.text "Repositories" ]
    Bulma.panelBlock.div [
        Bulma.control.div [
            Bulma.control.hasIconsLeft
            prop.children [
                Bulma.input.text [ prop.placeholder "Search" ]
                Bulma.icon [
                    icon.isLeft
                    prop.children [ Html.i [ prop.className "fas fa-search" ] ]
                ]
            ]
        ]
    ]
    Bulma.panelTabs [
        Html.a [
            prop.className "is-active"
            prop.text "All"
        ]
        Html.a [ prop.text "Public" ]
        Html.a [ prop.text "Private" ]
        Html.a [ prop.text "Sources" ]
        Html.a [ prop.text "Forks" ]
    ]
    Bulma.panelBlock.div [
        prop.className "is-active"
        prop.children [
            Bulma.panelIcon [
                Html.i [ prop.className "fas fa-book" ]
            ]
            Html.span "Feliz.Bulma"
        ]
    ]
    Bulma.panelBlock.div [
        Bulma.panelIcon [
            Html.i [ prop.className "fas fa-book" ]
        ]
        Html.span "Feliz"
    ]
    Bulma.panelBlock.div [
        Bulma.panelIcon [
            Html.i [ prop.className "fas fa-book" ]
        ]
        Html.span "Fable"
    ]
]"""
                    ]
                ]
            ]
        ]
    ]
