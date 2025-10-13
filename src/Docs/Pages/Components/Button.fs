module Docs.Pages.Components.Button

open Feliz
open Feliz.Bulma
open Docs.Helpers

let private example (buttonProps: IReactProperty list) (code: string) =
    Bulma.columns [
        Bulma.column [ Bulma.button.a buttonProps ]
        Bulma.column [ Code.render code ]
    ]

let view =
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Buttons"
        Html.hr []
        Bulma.content [
            Bulma.title "Basic"
            example [ prop.text "Button" ] """Bulma.button.button [ prop.text "Button" ]"""

        ]
        Bulma.content [
            Bulma.title "Colors"
            example
                [
                    color.isWhite
                    prop.text "White"
                ]
                """Bulma.button.button [
    color.isWhite
    prop.text "White"
]"""
            example
                [
                    color.isLight
                    prop.text "Light"
                ]
                """Bulma.button.button [
    color.isLight
    prop.text "Light"
]"""
            example
                [
                    color.isDark
                    prop.text "Dark"
                ]
                """Bulma.button.button [
    color.isDark
    prop.text "Dark"
]"""
            example
                [
                    color.isPrimary
                    prop.text "Primary"
                ]
                """Bulma.button.button [
    color.isPrimary
    prop.text "Primary"
]"""
            example
                [
                    color.isSuccess
                    prop.text "Success"
                ]
                """Bulma.button.button [
    color.isSuccess
    prop.text "Success"
]"""
            example
                [
                    color.isInfo
                    prop.text "Info"
                ]
                """Bulma.button.button [
    color.isInfo
    prop.text "Info"
]"""
            example
                [
                    color.isDanger
                    prop.text "Danger"
                ]
                """Bulma.button.button [
    color.isDanger
    prop.text "Danger"
]"""
            example
                [
                    color.isWarning
                    prop.text "Warning"
                ]
                """Bulma.button.button [
    color.isWarning
    prop.text "Warning"
]"""
            example
                [
                    color.isLink
                    prop.text "Link"
                ]
                """Bulma.button.button [
    color.isLink
    prop.text "Link"
]"""
        ]
        Bulma.content [
            Bulma.title "Sizes"
            example
                [
                    button.isSmall
                    prop.text "Small"
                ]
                """Bulma.button.button [
    Bulma.button.isSmall
    prop.text "Small"
]"""
            example
                [ prop.text "Normal (Default)" ]
                """Bulma.button.button [ prop.text "Normal (Default)" ]"""
            example
                [
                    button.isMedium
                    prop.text "Medium"
                ]
                """Bulma.button.button [
    Bulma.button.isMedium
    prop.text "Medium"
]"""
            example
                [
                    button.isLarge
                    prop.text "Large"
                ]
                """Bulma.button.button [
    Bulma.button.isLarge
    prop.text "Large"
]"""
        ]
        Bulma.content [
            Bulma.title "States"
            example
                [
                    button.isActive
                    prop.text "Active"
                ]
                """Bulma.button.button [
    Bulma.button.isActive
    prop.text "Active"
]"""
            example
                [
                    prop.disabled true
                    prop.text "Disabled"
                ]
                """Bulma.button.button [
    prop.disabled true
    prop.text "Disabled"
]"""
            example
                [
                    button.isFocused
                    prop.text "Focused"
                ]
                """Bulma.button.button [
    Bulma.button.isFocused
    prop.text "Focused"
]"""
            example
                [
                    button.isHovered
                    prop.text "Hover"
                ]
                """Bulma.button.button [
    Bulma.button.isHovered
    prop.text "Hover"
]"""
            example
                [ prop.text "Normal (Default)" ]
                """Bulma.button.button [ prop.text "Normal (Default)" ]"""
            example [ button.isLoading ] """Bulma.button.button [ Bulma.button.isLoading ]"""
        ]
        Bulma.content [
            Bulma.title "Styles"
            example
                [
                    Bulma.button.isInverted
                    color.isInfo
                    prop.text "Inverted"
                ]
                """Bulma.button.button [
    Bulma.button.isInverted
    color.isInfo
    prop.text "Inverted"
]"""
            example
                [
                    Bulma.button.isOutlined
                    color.isPrimary
                    prop.text "Outlined"
                ]
                """Bulma.button.button [
    Bulma.button.isOutlined
    color.isPrimary
    prop.text "Outlined"
]"""
            example
                [
                    Bulma.button.isRounded
                    color.isDanger
                    prop.text "Rounded"
                ]
                """Bulma.button.button [
    Bulma.button.isRounded
    color.isDanger
    prop.text "Rounded"
]"""
            example
                [
                    Bulma.button.isStatic
                    prop.text "Static"
                ]
                """Bulma.button.button [
    Bulma.button.isStatic
    prop.text "Static"
]"""
        ]
        Bulma.content [
            Bulma.title "Button group with addons"
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        field.hasAddons
                        prop.children [
                            Bulma.control.p [
                                Bulma.button.button [
                                    Bulma.icon [ Html.i [ prop.className "fas fa-align-left" ] ]
                                    Html.span [ prop.text "Left" ]
                                ]
                            ]
                            Bulma.control.p [
                                Bulma.button.button [
                                    Bulma.icon [ Html.i [ prop.className "fas fa-align-center" ] ]
                                ]
                            ]
                            Bulma.control.p [
                                Bulma.button.button [
                                    Html.span [ prop.text "Right" ]
                                    Bulma.icon [ Html.i [ prop.className "fas fa-align-right" ] ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """Bulma.field.div [
    Bulma.field.hasAddons
    prop.children [
        Bulma.control.p [
            Bulma.button.button [
                Bulma.icon [ Html.i [ prop.className "fas fa-align-left" ] ]
                Html.span [ prop.text "Left" ]
            ]
        ]
        Bulma.control.p [
            Bulma.button.button [
                Bulma.icon [ Html.i [ prop.className "fas fa-align-center" ] ]
            ]
        ]
        Bulma.control.p [
            Bulma.button.button [
                Html.span [ prop.text "Right" ]
                Bulma.icon [ Html.i [ prop.className "fas fa-align-right" ] ]
            ]
        ]
    ]
]"""
                ]
            ]
            Html.p [
                text.hasTextRight
                prop.text "Note: Icon using Font Awesome."
            ]
        ]
    ]
