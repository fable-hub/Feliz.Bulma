module Docs.Pages.Components.Tabs

open Feliz
open Feliz.Bulma
open Docs.Helpers

let view =
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Tabs"
        Html.hr []
        Bulma.content [
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Centered Tabs"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tabs [
                        tabs.isCentered
                        prop.children [
                            Html.ul [
                                Bulma.tab [
                                    Html.a [
                                        prop.text "Tab1"
                                        prop.href "#"
                                    ]
                                ]
                                Bulma.tab [
                                    Html.a [
                                        prop.text "Tab2"
                                        prop.href "#"
                                    ]
                                ]
                                Bulma.tab [
                                    Html.a [
                                        prop.text "Tab3"
                                        prop.href "#"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.tabs [
    tabs.isCentered
    prop.children [
        Html.ul [
            Bulma.tab [
                Html.a [
                    prop.text "Tab1"
                    prop.href "#"
                ]
            ]
            Bulma.tab [
                Html.a [
                    prop.text "Tab2"
                    prop.href "#"
                ]
            ]
            Bulma.tab [
                Html.a [
                    prop.text "Tab3"
                    prop.href "#"
                ]
            ]
        ]
    ]
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Boxed Tabs"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tabs [
                        tabs.isBoxed
                        prop.children [
                            Html.ul [
                                Bulma.tab [
                                    Html.a [
                                        prop.text "Tab1"
                                        prop.href "#"
                                    ]
                                ]
                                Bulma.tab [
                                    Html.a [
                                        prop.text "Tab2"
                                        prop.href "#"
                                    ]
                                ]
                                Bulma.tab [
                                    Html.a [
                                        prop.text "Tab3"
                                        prop.href "#"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.tabs [
    tabs.isBoxed
    prop.children [
        Html.ul [
            Bulma.tab [
                Html.a [
                    prop.text "Tab1"
                    prop.href "#"
                ]
            ]
            Bulma.tab [
                Html.a [
                    prop.text "Tab2"
                    prop.href "#"
                ]
            ]
            Bulma.tab [
                Html.a [
                    prop.text "Tab3"
                    prop.href "#"
                ]
            ]
        ]
    ]
]
]"""
                ]
            ]


        ]
    ]
