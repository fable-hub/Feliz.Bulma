module Docs.Pages.APIDescription

open Feliz
open Feliz.Bulma
open Feliz.Bulma.Operators
open Docs.Helpers

let view =
    Html.div [
        Bulma.title "Feliz.Bulma - API"
        Html.hr []
        Bulma.content [
            Html.p [
                prop.dangerouslySetInnerHTML
                    "Feliz.Bulma fully covers <a href='https://bulma.io'>Bulma UI</a> in version 1.0.0."
            ]
        ]
        Bulma.content [
            Bulma.title.h4 "Example"
            Code.render
                """open Feliz.Bulma

Bulma.button.a [
    color.isWarning
    prop.onClick (fun _ -> Fable.Core.JS.eval "alert('Hello Feliz.Bulma')" |> ignore)
    prop.text "Amazing button, ain't it?"
]
"""
            Html.p "Code above will generate this button:"
            Bulma.button.a [
                color.isWarning
                prop.onClick (fun _ ->
                    Fable.Core.JS.eval "alert('Hello Feliz.Bulma')"
                    |> ignore
                )
                prop.text "Amazing button, ain't it?"
            ]
        ]
        Bulma.content [
            Html.p [
                prop.dangerouslySetInnerHTML
                    "API was designed to be more less 1:1 with Bulma. To see what elements are available in Feliz.Bulma, please check <a href='https://bulma.io/documentation/'>official Bulma documentation</a>."
            ]
        ]

        Bulma.content [
            Bulma.title "Using Bulma props in Feliz elements"
            Html.p [
                prop.dangerouslySetInnerHTML
                    "Feliz.Bulma contains some helpers that could be handy to combine with <i>classic</i> Feliz API. Unfortunately this is not supported out of the box - <a href='https://github.com/Zaid-Ajaj/Feliz/issues/128'>see this issue.</a>"
            ]
            Html.p [
                prop.dangerouslySetInnerHTML
                    "To allow this behavior, there is new <code>Feliz.Bulma.Operators</code> module with <code>++</code> operator"
            ]
            Code.render
                """open Feliz.Bulma.Operators

Html.p [
    text.isUppercase
    ++ text.isItalic
    ++ color.hasTextSuccess
    prop.text "Hello Feliz"
]
"""

            Html.p "Code above will work as expected:"
            Html.p [
                text.isUppercase
                ++ text.isItalic
                ++ color.hasTextSuccess
                prop.text "Hello Feliz"
            ]
        ]
    ]
