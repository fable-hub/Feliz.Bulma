module Docs.Pages.Components.ProgressBar

open Feliz
open Feliz.Bulma
open Docs.Helpers


[<ReactComponent>]
let ProgressbarComponent () =
    let color, chooseColor = React.useState Color.Primary

    let getColorChooseButtonToProgressBar (color: Color.Color) =
        Color.chooseButton color chooseColor

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Progress Bar"
        Html.hr []
        Bulma.content [
            Bulma.subtitle [ prop.text "Choose a color:" ]
            Bulma.buttons [
                getColorChooseButtonToProgressBar Color.Primary
                getColorChooseButtonToProgressBar Color.Danger
                getColorChooseButtonToProgressBar Color.Info
                getColorChooseButtonToProgressBar Color.Link
                getColorChooseButtonToProgressBar Color.Success
                getColorChooseButtonToProgressBar Color.Warning
                getColorChooseButtonToProgressBar Color.Black
                getColorChooseButtonToProgressBar Color.Dark
                getColorChooseButtonToProgressBar Color.Light
                getColorChooseButtonToProgressBar Color.White
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Basic"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.progress [
                        color.PropertyName
                        prop.value 50
                        prop.max 100
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.progress [
    color.is{color.Name}
    prop.value 50
    prop.max 100
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Small"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.progress [
                        color.PropertyName
                        progress.isSmall
                        prop.value 15
                        prop.max 100
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.progress [
    color.is{color.Name}
    progress.isSmall
    prop.value 15
    prop.max 100
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Medium"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.progress [
                        color.PropertyName
                        progress.isMedium
                        prop.value 45
                        prop.max 100
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.progress [
    color.is{color.Name}
    progress.isMedium
    prop.value 45
    prop.max 100
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Large"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.progress [
                        color.PropertyName
                        progress.isLarge
                        prop.value 75
                        prop.max 100
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.progress [
    color.is{color.Name}
    progress.isLarge
    prop.value 75
    prop.max 100
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Indeterminate"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.progress [
                        color.PropertyName
                        prop.max 100
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.column [
    Bulma.progress [
        color.is{color.Name}
        prop.max 100
    ]
]"""
                ]
            ]
        ]
    ]

let view = ProgressbarComponent()
