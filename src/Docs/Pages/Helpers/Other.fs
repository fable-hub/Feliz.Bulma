module Docs.Pages.Helpers.Other

open Feliz
open Feliz.Bulma
open Docs.Helpers

let view =
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Other Helpers"
        Html.hr []

        Bulma.content [
            Html.p [ Html.text "Here are some other helpers shipped with Bulma:" ]

            Bulma.table [
                table.isBordered
                prop.children [
                    Html.tbody [
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isClearfix" ]
                            Html.td [ Html.text "Fixes an element's floating children" ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isPulledLeft" ]
                            Html.td [
                                Html.text "Moves an element to the "
                                Html.strong "left"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isPulledRight" ]
                            Html.td [
                                Html.text "Moves an element to the "
                                Html.strong "right"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isOverlay" ]
                            Html.td [
                                Html.text "Completely "
                                Html.strong "covers"
                                Html.text " the first positioned parent"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isClipped" ]
                            Html.td [
                                Html.text "Adds overflow "
                                Html.strong "hidden"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isRadiusless" ]
                            Html.td [
                                Html.text "Removes any "
                                Html.strong "radius"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isShadowless" ]
                            Html.td [
                                Html.text "Removes any "
                                Html.strong "shadow"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isUnselectable" ]
                            Html.td [
                                Html.text "Prevents the text from being "
                                Html.strong "selectable"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isClickable" ]
                            Html.td [
                                Html.text "Applies "
                                Html.code "cursor: pointer !important"
                                Html.text " to the element"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isRelative" ]
                            Html.td [
                                Html.text "Applies "
                                Html.code "position: relative"
                                Html.text " to the element"
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
