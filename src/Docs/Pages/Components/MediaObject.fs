module Docs.Pages.Components.MediaObject

open Feliz
open Feliz.Bulma
open Docs.Helpers

let view =
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Media Object"
        Html.hr []
        Bulma.content [
            Bulma.title "Basic"
            Bulma.columns [
                Bulma.column [
                    Bulma.column.isHalf
                    prop.children [
                        Bulma.media [
                            Bulma.mediaLeft [
                                Bulma.image [
                                    Bulma.image.is64x64
                                    prop.children [
                                        Html.img [ prop.src "https://picsum.photos/64/64" ]
                                    ]
                                ]
                            ]
                            Bulma.mediaContent [
                                Bulma.content [
                                    Html.p [
                                        Html.strong "John Smith"
                                        Html.small "@johnsmith"
                                        Html.br []
                                        Html.span
                                            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ornare magna eros, eu pellentesque tortor vestibulum ut."
                                    ]
                                ]
                                Bulma.level [
                                    Bulma.levelLeft [
                                        Bulma.levelItem [
                                            Bulma.icon [
                                                icon.isSmall
                                                prop.children [
                                                    Html.i [ prop.className "fas fa-reply" ]
                                                ]
                                            ]
                                        ]
                                        Bulma.levelItem [
                                            Bulma.icon [
                                                icon.isSmall
                                                prop.children [
                                                    Html.i [ prop.className "fas fa-retweet" ]
                                                ]
                                            ]
                                        ]
                                        Bulma.levelItem [
                                            Bulma.icon [
                                                icon.isSmall
                                                prop.children [
                                                    Html.i [ prop.className "fas fa-heart" ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    column.isHalf
                    prop.children [
                        Code.render
                            """Bulma.media [
    Bulma.mediaLeft [
        Bulma.image [
            Bulma.image.is64x64
            prop.children[
                Html.img [
                    prop.src "https://picsum.photos/64/64"
                ]
            ]
        ]
    ]
    Bulma.mediaContent [
        Bulma.content [
            Html.p [
                Html.strong "John Smith"
                Html.small "@johnsmith"
                Html.br []
                Html.span "Lorem ipsum ... vestibulum ut."
            ]
        ]
        Bulma.level [
            Bulma.levelLeft [
                Bulma.levelItem [
                    Bulma.icon [
                        icon.isSmall
                        prop.children [
                            Html.i [ prop.className "fas fa-reply" ]
                        ]
                    ]
                ]
                Bulma.levelItem [
                    Bulma.icon [
                        icon.isSmall
                        prop.children [
                            Html.i [ prop.className "fas fa-retweet" ]
                        ]
                    ]
                ]
                Bulma.levelItem [
                    Bulma.icon [
                        icon.isSmall
                        prop.children [
                            Html.i [ prop.className "fas fa-heart" ]
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
        ]
        Bulma.content [
            Bulma.title "Nesting"
            Bulma.subtitle.h5 [ prop.text "You can nest media objects up to 3 levels deep." ]
            Bulma.media [
                Bulma.mediaLeft [
                    Bulma.image [
                        Bulma.image.is64x64
                        prop.children [ Html.img [ prop.src "https://picsum.photos/64/64" ] ]
                    ]
                ]
                Bulma.mediaContent [
                    Bulma.content [
                        Html.p [
                            Html.strong "Barbara Middleton"
                            Html.br []
                            Html.span
                                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ornare magna eros, eu pellentesque tortor vestibulum ut."
                            Html.br []
                            Html.small [
                                Html.a [ prop.text "Like" ]
                                Html.span " · "
                                Html.a [ prop.text "Reply" ]
                                Html.span " · "
                                Html.span "3hrs ago"
                            ]
                        ]
                    ]
                    Bulma.media [
                        Bulma.mediaLeft [
                            Bulma.image [
                                Bulma.image.is64x64
                                prop.children [
                                    Html.img [ prop.src "https://picsum.photos/64/64" ]
                                ]
                            ]
                        ]
                        Bulma.mediaContent [
                            Bulma.content [
                                Html.p [
                                    Html.strong "Sean Brown"
                                    Html.br []
                                    Html.span
                                        "Donec sollicitudin urna eget eros malesuada sagittis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aliquam blandit nisl a nulla sagittis, a lobortis leo feugiat."
                                    Html.br []
                                    Html.small [
                                        Html.a [ prop.text "Like" ]
                                        Html.span " · "
                                        Html.a [ prop.text "Reply" ]
                                        Html.span " · "
                                        Html.span "3hrs ago"
                                    ]
                                ]
                            ]
                        ]
                    ]
                    Bulma.media [
                        Bulma.mediaLeft [
                            Bulma.image [
                                Bulma.image.is64x64
                                prop.children [
                                    Html.img [ prop.src "https://picsum.photos/64/64" ]
                                ]
                            ]
                        ]
                        Bulma.mediaContent [
                            Bulma.content [
                                Html.p [
                                    Html.strong "Kayli Eunice"
                                    Html.br []
                                    Html.span
                                        "Sed convallis scelerisque mauris, non pulvinar nunc mattis vel. Maecenas varius felis sit amet magna vestibulum euismod malesuada cursus libero."
                                    Html.br []
                                    Html.small [
                                        Html.a [ prop.text "Like" ]
                                        Html.span " · "
                                        Html.a [ prop.text "Reply" ]
                                        Html.span " · "
                                        Html.span "3hrs ago"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
            Bulma.media [
                Bulma.mediaLeft [
                    Bulma.image [
                        Bulma.image.is64x64
                        prop.children [ Html.img [ prop.src "https://picsum.photos/64/64" ] ]
                    ]
                ]
                Bulma.mediaContent [
                    Bulma.field.div [
                        Bulma.control.p [ Bulma.textarea [ prop.placeholder "Add a comment..." ] ]
                    ]
                    Bulma.field.div [
                        Bulma.control.p [ Bulma.button.button [ prop.text "Post comment" ] ]
                    ]
                ]
            ]
            Code.render
                """Bulma.media [
    Bulma.mediaLeft [
        Bulma.image [
            Bulma.image.is64x64
            prop.children[
                Html.img [ prop.src "https://picsum.photos/64/64" ]
            ]
        ]
    ]
    Bulma.mediaContent [
        Bulma.content [
            Html.p [
                Html.strong "Barbara Middleton"
                Html.br []
                Html.span "Lorem ipsum dolor sit ... vestibulum ut."
                Html.br []
                Html.small [
                    Html.a [ prop.text "Like"]
                    Html.span " · "
                    Html.a [ prop.text "Reply" ]
                    Html.span " · "
                    Html.span "3hrs ago"
                ]
            ]
        ]
        Bulma.media [
            Bulma.mediaLeft [
                Bulma.image [
                    Bulma.image.is64x64
                    prop.children[
                        Html.img [ prop.src "https://picsum.photos/64/64" ]
                    ]
                ]
            ]
            Bulma.mediaContent [
                Bulma.content [
                    Html.p [
                        Html.strong "Sean Brown"
                        Html.br []
                        Html.span "Donec sollicitudin urna ... leo feugiat."
                        Html.br []
                        Html.small [
                            Html.a [ prop.text "Like"]
                            Html.span " · "
                            Html.a [ prop.text "Reply" ]
                            Html.span " · "
                            Html.span "3hrs ago"
                        ]
                    ]
                ]
            ]
        ]
        Bulma.media [
            Bulma.mediaLeft [
                Bulma.image [
                    Bulma.image.is64x64
                    prop.children[
                        Html.img [ prop.src "https://picsum.photos/64/64" ]
                    ]
                ]
            ]
            Bulma.mediaContent [
                Bulma.content [
                    Html.p [
                        Html.strong "Kayli Eunice"
                        Html.br []
                        Html.span "Sed convallis scelerisque ... cursus libero."
                        Html.br []
                        Html.small [
                            Html.a [ prop.text "Like"]
                            Html.span " · "
                            Html.a [ prop.text "Reply" ]
                            Html.span " · "
                            Html.span "3hrs ago"
                        ]
                    ]
                ]
            ]
        ]
    ]
]
Bulma.media [
    Bulma.mediaLeft [
        Bulma.image [
            Bulma.image.is64x64
            prop.children[
                Html.img [ prop.src "https://picsum.photos/64/64" ]
            ]
        ]
    ]
    Bulma.mediaContent [
        Bulma.field.div [
            Bulma.control.p [
                Bulma.textarea [ prop.placeholder "Add a comment..."]
            ]
        ]
        Bulma.field.div [
            Bulma.control.p [
                Bulma.button.button [ prop.text "Post comment" ]
            ]
        ]
    ]
]"""
        ]
    ]
