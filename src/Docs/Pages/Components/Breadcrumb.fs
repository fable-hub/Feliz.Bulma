module Docs.Pages.Components.Breadcrumb

open Feliz
open Feliz.Bulma
open Docs.Helpers

let private sample style =
    Bulma.breadcrumb [
        style
        prop.children [
            Html.ul [
                Html.li [
                    Html.a [
                        Bulma.icon [
                            icon.isSmall
                            prop.children [ Html.i [ prop.className "fas fa-home" ] ]
                        ]
                        Html.span "Home"
                    ]
                ]
                Html.li [
                    prop.className "is-active"
                    prop.children [
                        Html.a [
                            Bulma.icon [
                                icon.isSmall
                                prop.children [ Html.i [ prop.className "fas fa-level-up-alt" ] ]
                            ]
                            Html.span "NextLvl"
                        ]
                    ]
                ]
            ]
        ]
    ]

let private codeSample (prop: string) =
    Code.render
        $"""
Bulma.breadcrumb [
    {prop}
    prop.children [
        Html.ul [
            Html.li [
                Html.a [
                    Bulma.icon [
                        icon.isSmall
                        prop.children [
                            Html.i [ prop.className "fas fa-home" ]
                        ]
                    ]
                    Html.span "Home"
                ]
            ]

            Html.li [
                Html.a [
                    Bulma.icon [
                        icon.isSmall
                        prop.children [
                            Html.i [
                                prop.className "fas fa-level-up-alt"
                            ]
                        ]
                    ]
                    Html.span "NextLvl"
                ]
            ]
        ]
    ]
]
    """

let view =
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Breadcrumb"
        Html.hr []
        Bulma.content [
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Large Breadcrumb"
            ]
            Bulma.columns [
                Bulma.column [ sample breadcrumb.isLarge ]
                Bulma.column [ codeSample "breadcrumb.isLarge" ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Medium Breadcrumb"
            ]
            Bulma.columns [
                Bulma.column [ sample breadcrumb.isMedium ]
                Bulma.column [ codeSample "breadcrumb.isMedium" ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Centered Breadcrumb"
            ]
            Bulma.columns [
                Bulma.column [ sample breadcrumb.isCentered ]
                Bulma.column [ codeSample "breadcrumb.isCentered" ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Breadcrumb with Arrow Seperator"
            ]
            Bulma.columns [
                Bulma.column [ sample breadcrumb.hasArrowSeparator ]
                Bulma.column [ codeSample "breadcrumb.hasArrowSeparator" ]
            ]
            Bulma.subtitle [
                text.hasTextWeightLight
                prop.text "Breadcrumb with Bullet Seperator"
            ]
            Bulma.columns [
                Bulma.column [ sample breadcrumb.hasBulletSeparator ]
                Bulma.column [ codeSample "breadcrumb.hasBulletSeparator" ]
            ]
        ]
    ]
