module Docs.Pages.Components.Tag

open Feliz
open Feliz.Bulma
open Docs.Helpers


[<ReactComponent>]
let TagComponent () =
    let selectedColor, chooseColor = React.useState Color.Primary
    let getColorChooseButtonToTag (color: Color.Color) = Color.chooseButton color chooseColor

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Tag"
        Html.hr []
        Bulma.content [
            Bulma.subtitle [ prop.text "Choose a color:" ]
            Bulma.buttons [
                getColorChooseButtonToTag Color.Primary
                getColorChooseButtonToTag Color.Danger
                getColorChooseButtonToTag Color.Info
                getColorChooseButtonToTag Color.Link
                getColorChooseButtonToTag Color.Success
                getColorChooseButtonToTag Color.Warning
                getColorChooseButtonToTag Color.Black
                getColorChooseButtonToTag Color.Dark
                getColorChooseButtonToTag Color.Light
                getColorChooseButtonToTag Color.White
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Basic"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tag [
                        Color.info(selectedColor).PropertyName
                        prop.text $"Tag basic"
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.tag [
    color.is{Color.info(selectedColor).Name}
    prop.text "Tag basic"
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Light"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tag [
                        Color.info(selectedColor).PropertyName
                        color.isLight
                        prop.text "Tag light"
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.tag [
    color.is{Color.info(selectedColor).Name}
    color.isLight
    prop.text "Tag light"
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Size medium"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tag [
                        Color.info(selectedColor).PropertyName
                        tag.isMedium
                        prop.text "Tag medium"
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.tag [
    color.is{Color.info(selectedColor).Name}
    tag.isMedium
    prop.text "Tag medium"
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Size large"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tag [
                        Color.info(selectedColor).PropertyName
                        tag.isLarge
                        prop.text "Tag large"
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.tag [
    color.is{Color.info(selectedColor).Name}
    tag.isLarge
    prop.text "Tag large"
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Rounded"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tag [
                        Color.info(selectedColor).PropertyName
                        tag.isRounded
                        prop.text "Tag rounded"
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.tag [
    color.is{Color.info(selectedColor).Name}
    tag.isRounded
    prop.text "Tag rounded"
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "List of tags"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tags [
                        Bulma.tag [
                            Color.info(selectedColor).PropertyName
                            prop.text "One"
                        ]
                        Bulma.tag [
                            Color.info(selectedColor).PropertyName
                            prop.text "Two"
                        ]
                        Bulma.tag [
                            Color.info(selectedColor).PropertyName
                            prop.text "Three"
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.column [
    Bulma.tags [
        Bulma.tag [
            color.is{Color.info(selectedColor).Name}
            prop.text "One"
        ]
        Bulma.tag [
            color.is{Color.info(selectedColor).Name}
            prop.text "Two"
        ]
        Bulma.tag [
            color.is{Color.info(selectedColor).Name}
            prop.text "Three"
        ]
    ]
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Tag addons"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tags [
                        Bulma.tags.hasAddons
                        prop.children [
                            Bulma.tag "Package"
                            Bulma.tag [
                                Color.info(selectedColor).PropertyName
                                prop.text "Feliz.Bulma"
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.tags [
    Bulma.tags.hasAddons
    prop.children [
        Bulma.tag "Package"
        Bulma.tag [
            color.is{Color.info(selectedColor).Name}
            prop.text "Feliz.Bulma"
        ]
    ]
]"""
                ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Tag with delete"
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.tags [
                        Bulma.tags.hasAddons
                        prop.children [
                            Bulma.tag [
                                Color.info(selectedColor).PropertyName
                                prop.text "Feliz.Bulma"
                            ]
                            Bulma.tag [ tag.isDelete ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        $"""Bulma.tags [
    Bulma.tags.hasAddons
    prop.children [
        Bulma.tag [
            color.is{Color.info(selectedColor).Name}
            prop.text "Feliz.Bulma"
        ]
        Bulma.tag [ tag.isDelete ]
    ]
]"""
                ]
            ]
        ]
    ]

let view = TagComponent()
