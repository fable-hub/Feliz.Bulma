module Docs.Pages.Components.Navbar

open Feliz
open Feliz.Bulma
open Docs.Helpers

[<ReactComponent>]
let NavbarComponent () =
    let currentColor, chooseColor = React.useState Color.Primary

    let getColorChooseButtonToNavbar (color: Color.Color) = Color.chooseButton color chooseColor

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Navbar"
        Html.hr []
        Bulma.content [
            Bulma.title "Basic navbar"

            Bulma.navbar [
                Bulma.navbarBrand.div [
                    Bulma.navbarItem.a [
                        Html.img [
                            prop.src "https://bulma.io/assets/images/bulma-logo.png"
                            prop.height 28
                            prop.width 112
                        ]
                    ]
                    Bulma.navbarBurger [ Html.span [ prop.ariaHidden true ] ]
                ]
                Bulma.navbarMenu [
                    Bulma.navbarStart.div [
                        Bulma.navbarItem.a [ prop.text "Home" ]
                        Bulma.navbarItem.a [ prop.text "Documentation" ]
                        Bulma.navbarItem.div [
                            Bulma.navbarItem.hasDropdown
                            Bulma.navbarItem.isHoverable
                            prop.children [
                                Bulma.navbarLink.a [ prop.text "More" ]
                                Bulma.navbarDropdown.div [
                                    Bulma.navbarItem.a [ prop.text "About" ]
                                    Bulma.navbarItem.a [ prop.text "Jobs" ]
                                    Bulma.navbarItem.a [ prop.text "Contact" ]
                                    Bulma.navbarDivider []
                                    Bulma.navbarItem.a [ prop.text "Report an issue" ]
                                ]
                            ]
                        ]
                    ]
                    Bulma.navbarEnd.div [
                        Bulma.navbarItem.div [
                            Bulma.buttons [
                                Bulma.button.a [
                                    color.isPrimary
                                    prop.children [ Html.strong "Sign up" ]
                                ]
                                Bulma.button.a [ prop.text "Log In" ]
                            ]
                        ]
                    ]
                ]
            ]
            Code.render
                """Bulma.navbarMenu [
    Bulma.navbarStart.div [
        Bulma.navbarItem.a [ prop.text "Home" ]
        Bulma.navbarItem.a [ prop.text "Documentation" ]
        Bulma.navbarItem.div [
            Bulma.navbarItem.hasDropdown
            Bulma.navbarItem.isHoverable
            prop.children [
                Bulma.navbarLink.a [ prop.text "More" ]
                Bulma.navbarDropdown.div [
                    Bulma.navbarItem.a [ prop.text "About" ]
                    Bulma.navbarItem.a [ prop.text "Jobs" ]
                    Bulma.navbarItem.a [ prop.text "Contact" ]
                    Bulma.navbarDivider []
                    Bulma.navbarItem.a [ prop.text "Report a issue" ]
                ]
            ]
        ]
    ]
    Bulma.navbarEnd.div [
        Bulma.navbarItem.div [
            Bulma.buttons [
                Bulma.button.a [
                    color.isPrimary
                    prop.children [
                        Html.strong "Sign up"
                    ]
                ]
                Bulma.button.a [ prop.text "Log In" ]
            ]
        ]
    ]
]"""

            Bulma.title "Colors"
            Bulma.box [
                Bulma.subtitle [ prop.text "Choose a color:" ]
                Bulma.buttons [
                    getColorChooseButtonToNavbar Color.Primary
                    getColorChooseButtonToNavbar Color.Danger
                    getColorChooseButtonToNavbar Color.Info
                    getColorChooseButtonToNavbar Color.Link
                    getColorChooseButtonToNavbar Color.Success
                    getColorChooseButtonToNavbar Color.Warning
                    getColorChooseButtonToNavbar Color.Black
                    getColorChooseButtonToNavbar Color.Dark
                    getColorChooseButtonToNavbar Color.Light
                    getColorChooseButtonToNavbar Color.White
                ]
                Bulma.subtitle [
                    text.hasTextWeightLight
                    prop.text "Navbar with links"
                ]
                Bulma.navbar [
                    Color.info(currentColor).PropertyName
                    prop.children [
                        Bulma.navbarBrand.div [
                            Bulma.navbarItem.a [
                                Html.img [
                                    prop.src "https://bulma.io/assets/images/bulma-logo-white.png"
                                    prop.height 28
                                    prop.width 112
                                ]
                            ]
                        ]
                        Bulma.navbarMenu [
                            Bulma.navbarStart.div [
                                Bulma.navbarItem.a [ prop.text "Home" ]
                                Bulma.navbarItem.a [ prop.text "Documentation" ]
                                Bulma.navbarItem.a [ prop.text "Jobs" ]
                                Bulma.navbarItem.a [ prop.text "Contact" ]
                                Bulma.navbarItem.a [ prop.text "About" ]
                            ]
                        ]
                    ]
                ]
                Code.render
                    $"""Bulma.navbar [
    color.is{Color.info(currentColor).Name}
    prop.children [
        Bulma.navbarBrand.div [
            Bulma.navbarItem.a [
                Html.img [ prop.src "https://bulma.io/assets/images/bulma-logo-white.png"; prop.height 28; prop.width 112; ]
            ]
        ]
        Bulma.navbarMenu [
            Bulma.navbarStart.div [
                Bulma.navbarItem.a [ prop.text "Home" ]
                Bulma.navbarItem.a [ prop.text "Documentation" ]
                Bulma.navbarItem.a [ prop.text "Jobs" ]
                Bulma.navbarItem.a [ prop.text "Contact" ]
                Bulma.navbarItem.a [ prop.text "About" ]
            ]
        ]
    ]
]"""
                Bulma.subtitle [
                    text.hasTextWeightLight
                    prop.text "Navbar with item Start + End"
                ]
                Bulma.navbar [
                    Color.info(currentColor).PropertyName
                    prop.children [
                        Bulma.navbarBrand.div [
                            Bulma.navbarItem.a [
                                Html.img [
                                    prop.src "https://bulma.io/assets/images/bulma-logo-white.png"
                                    prop.height 28
                                    prop.width 112
                                ]
                            ]
                        ]
                        Bulma.navbarMenu [
                            Bulma.navbarStart.div [
                                Bulma.navbarItem.a [ prop.text "Home" ]
                                Bulma.navbarItem.a [ prop.text "Documentation" ]
                                Bulma.navbarItem.a [ prop.text "Jobs" ]
                            ]
                            Bulma.navbarEnd.div [
                                Bulma.navbarItem.div [
                                    Bulma.buttons [
                                        Bulma.button.a [ Html.strong "Sign up" ]
                                        Bulma.button.a [ prop.text "Log In" ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Code.render
                    $"""Bulma.navbar [
    color.is{Color.info(currentColor).Name}
    prop.children [
        Bulma.navbarBrand.div [
            Bulma.navbarItem.a [
                Html.img [ prop.src "https://bulma.io/assets/images/bulma-logo-white.png"; prop.height 28; prop.width 112; ]
            ]
        ]
        Bulma.navbarMenu [
            Bulma.navbarStart.div [
                Bulma.navbarItem.a [ prop.text "Home" ]
                Bulma.navbarItem.a [ prop.text "Documentation" ]
                Bulma.navbarItem.a [ prop.text "Jobs" ]
            ]
            Bulma.navbarEnd.div [
                Bulma.navbarItem.div [
                    Bulma.buttons [
                        Bulma.button.a [ Html.strong "Sign up" ]
                        Bulma.button.a [ prop.text "Log In" ]
                    ]
                ]
            ]
        ]
    ]
]"""
                Bulma.subtitle [
                    text.hasTextWeightLight
                    prop.text "Navbar with search and end item (user)"
                ]
                Bulma.navbar [
                    Color.info(currentColor).PropertyName
                    prop.children [
                        Bulma.navbarBrand.div [
                            Bulma.navbarItem.a [
                                Html.img [
                                    prop.src "https://bulma.io/assets/images/bulma-logo-white.png"
                                    prop.height 28
                                    prop.width 112
                                ]
                            ]
                        ]
                        Bulma.navbarMenu [
                            Bulma.navbarStart.div [
                                Bulma.navbarItem.a [ prop.text "Home" ]
                                Bulma.navbarItem.a [ prop.text "Documentation" ]
                                Bulma.navbarItem.div [
                                    Bulma.control.p [
                                        control.hasIconsRight
                                        prop.children [
                                            Bulma.input.text [
                                                prop.required true
                                                prop.placeholder "Search in navbar"
                                            ]
                                            Bulma.icon [
                                                icon.isSmall
                                                icon.isRight
                                                prop.children [
                                                    Html.i [ prop.className "fas fa-search" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                            Bulma.navbarEnd.div [
                                Bulma.navbarItem.div [
                                    Bulma.media [
                                        Bulma.mediaContent [
                                            text.hasTextRight
                                            prop.children [
                                                Bulma.title.p [
                                                    text.hasTextWeightBold
                                                    title.is6
                                                    prop.text "Feliz Bulma"
                                                ]
                                                Bulma.subtitle.p [
                                                    title.is6
                                                    text.hasTextWeightLight
                                                    color.hasTextGreyLighter
                                                    prop.text "@feliz.bulma"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Code.render
                    $"""Bulma.navbar [
    color.is{Color.info(currentColor).Name}
    prop.children [
        Bulma.navbarBrand.div [
            Bulma.navbarItem.a [
                Html.img [ prop.src "https://bulma.io/assets/images/bulma-logo-white.png"; prop.height 28; prop.width 112; ]
            ]
        ]
        Bulma.navbarMenu [
            Bulma.navbarStart.div [
                Bulma.navbarItem.a [ prop.text "Home" ]
                Bulma.navbarItem.a [ prop.text "Documentation" ]
                Bulma.navbarItem.div [
                    Bulma.control.p [
                        Bulma.control.hasIconsRight
                        prop.children [
                            Bulma.input.text [
                                prop.required true
                                prop.placeholder "Search in navbar"
                            ]
                            Bulma.icon [
                                icon.isSmall
                                icon.isRight
                                prop.children [
                                    Html.i [ prop.className "fas fa-search" ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
            Bulma.navbarEnd.div [
                Bulma.navbarItem.div [
                    Bulma.media [
                        Bulma.mediaContent [
                            text.hasTextRight
                            prop.children [
                                Bulma.title.p [
                                    text.hasTextWeightBold
                                    Bulma.title.is6
                                    prop.text "Feliz Bulma"
                                ]
                                Bulma.subtitle.p [
                                    Bulma.title.is6
                                    text.hasTextWeightLight
                                    color.hasTextGreyLighter
                                    prop.text "@feliz.bulma"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
]"""
            ]
        ]
    ]

let view = NavbarComponent()
