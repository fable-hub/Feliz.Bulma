module Docs.Pages.Components.Card

open Feliz
open Feliz.Bulma
open Docs.Helpers

let view =
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Card"
        Html.hr []
        Html.div [
            Bulma.title "Basic"
            Bulma.columns [
                Bulma.column [
                    Bulma.card [
                        Bulma.cardImage [
                            Bulma.image [
                                Bulma.image.is4by3
                                prop.children [
                                    Html.img [
                                        prop.alt "Placeholder image"
                                        prop.src
                                            "https://bulma.io/assets/images/placeholders/1280x960.png"
                                    ]
                                ]
                            ]
                        ]
                        Bulma.cardContent [
                            Bulma.media [
                                Bulma.mediaLeft [
                                    Bulma.cardImage [
                                        Bulma.image [
                                            Bulma.image.is48x48
                                            prop.children [
                                                Html.img [
                                                    prop.alt "Placeholder image"
                                                    prop.src
                                                        "https://bulma.io/assets/images/placeholders/96x96.png"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Bulma.mediaContent [
                                    Bulma.title.p [
                                        Bulma.title.is4
                                        prop.text "Feliz Bulma"
                                    ]
                                    Bulma.subtitle.p [
                                        Bulma.title.is6
                                        prop.text "@feliz.bulma"
                                    ]
                                ]
                            ]
                            Bulma.content
                                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec iaculis mauris."
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """Bulma.card [
    Bulma.cardImage [
        Bulma.image [
            Bulma.image.is4by3
            prop.children [
                Html.img [
                    prop.alt "Placeholder image"
                    prop.src "https://bulma.io/assets/images/placeholders/1280x960.png"
                ]
            ]
        ]
    ]
    Bulma.cardContent [
        Bulma.media [
            Bulma.mediaLeft [
                Bulma.cardImage [
                    Bulma.image [
                        Bulma.image.is48x48
                        prop.children [
                            Html.img [
                                prop.alt "Placeholder image"
                                prop.src "https://bulma.io/assets/images/placeholders/96x96.png"
                            ]
                        ]
                    ]
                ]
            ]
            Bulma.mediaContent [
                Bulma.title.p [
                    Bulma.title.is4
                    prop.text "Feliz Bulma"
                ]
                Bulma.subtitle.p [
                    Bulma.title.is6
                    prop.text "@feliz.bulma"
                ]
            ]
        ]
        Bulma.content "Lorem ipsum dolor sit ... nec iaculis mauris."
    ]
]"""
                ]
            ]
        ]
        Html.div [
            Bulma.title "Card header"
            Bulma.columns [
                Bulma.column [
                    Bulma.card [
                        Bulma.cardHeader [
                            Bulma.cardHeaderTitle.p "Card header"
                            Bulma.cardHeaderIcon.span [
                                Html.i [ prop.className "fas fa-angle-down" ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """ Bulma.card [
    Bulma.cardHeader [
        Bulma.cardHeaderTitle.p "Card header"
        Bulma.cardHeaderIcon.span [
            Html.i [prop.className "fas fa-angle-down"]
        ]
    ]
]"""
                ]
            ]
        ]
        Html.div [
            Bulma.title "Card footer"
            Bulma.columns [
                Bulma.column [
                    Bulma.card [
                        Bulma.cardFooter [
                            Bulma.cardFooterItem.a [ prop.text "Save" ]
                            Bulma.cardFooterItem.a [ prop.text "Edit" ]
                            Bulma.cardFooterItem.a [ prop.text "Delete" ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """Bulma.card [
    Bulma.cardFooter [
        Bulma.cardFooterItem.a [
            prop.text "Save"
        ]
        Bulma.cardFooterItem.a [
            prop.text "Edit"
        ]
        Bulma.cardFooterItem.a [
            prop.text "Delete"
        ]
    ]
]"""
                ]
            ]
        ]
    ]
