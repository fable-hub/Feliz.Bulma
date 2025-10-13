module Docs.Pages.Overview

open Feliz
open Feliz.Bulma
open Docs.Helpers

let view =
    Html.div [
        Bulma.title [
            Html.text "Feliz.Bulma "
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.Bulma/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.svg?style=flat-square"
                    ]
                ]
            ]
        ]
        Bulma.subtitle [
            Html.text "Bulma UI wrapper for amazing "
            Html.a [
                prop.href "https://github.com/Zaid-Ajaj/Feliz"
                prop.text "Feliz DSL"
            ]
        ]
        Html.hr []
        Bulma.content [
            Html.p
                "This library brings Bulma UI elements into Zaid Ajaj's Feliz library. Instead of writing:"
            Code.render
                """Html.div [
    prop.className "columns"
    prop.children [
        Html.div [
            prop.className "column is-2"
            prop.children [
                Html.button.a [
                    prop.className "button"
                    prop.text "Click me"
                ]
            ]
        ]
    ]
]
"""
            Html.p "You just simply write:"
            Code.render
                """open Feliz.Bulma

Bulma.columns [
    Bulma.column [
        column.is2 // <-- note context helper here
        prop.children [
            Bulma.button.button "Click me"
        ]
    ]
]
"""
        ]
        Bulma.content [
            Bulma.title.h4 "Features"
            Html.ul [
                Html.li "Fully compatible with Feliz DSL syntax"
                Html.li "100% API coverage of Bulma UI (v1.0.0)"
                Html.li [
                    prop.dangerouslySetInnerHTML
                        "Compatible with <a href='https://github.com/zaid-ajaj/femto'>Femto CLI</a> "
                ]

            ]
        ]
    ]
