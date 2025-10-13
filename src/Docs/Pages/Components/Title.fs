module Docs.Pages.Components.Title

open Feliz
open Feliz.Bulma
open Docs.Helpers

let view =
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Title"
        Html.hr []
        Bulma.content [ Bulma.subtitle [ prop.text "Sizes" ] ]
        Bulma.columns [
            Bulma.column [
                Bulma.title.h1 [ prop.text "Title 1" ]
                Bulma.title.h2 [ prop.text "Title 2" ]
                Bulma.title.h3 [ prop.text "Title 3" ]
                Bulma.title.h4 [ prop.text "Title 4" ]
                Bulma.title.h5 [ prop.text "Title 5" ]
                Bulma.title.h6 [ prop.text "Title 6" ]
            ]
            Bulma.column [
                Code.render
                    """
Bulma.title.h1 [
    prop.text "Title 1"
]
Bulma.title.h2 [
    prop.text "Title 2"
]
Bulma.title.h3 [
    prop.text "Title 3"
]
Bulma.title.h4 [
    prop.text "Title 4"
]
Bulma.title.h5 [
    prop.text "Title 5"
]
Bulma.title.h6 [
    prop.text "Title 6"
]
                """
            ]
        ]
        Html.hr []
        Bulma.columns [
            Bulma.column [
                Bulma.subtitle.h1 [ prop.text "Subtitle 1" ]
                Bulma.subtitle.h2 [ prop.text "Subtitle 2" ]
                Bulma.subtitle.h3 [ prop.text "Subtitle 3" ]
                Bulma.subtitle.h4 [ prop.text "Subtitle 4" ]
                Bulma.subtitle.h5 [ prop.text "Subtitle 5" ]
                Bulma.subtitle.h6 [ prop.text "Subtitle 6" ]
            ]
            Bulma.column [
                Code.render
                    """
Bulma.subtitle.h1 [
    prop.text "Subtitle 1"
]
Bulma.subtitle.h2 [
    prop.text "Subtitle 2"
]
Bulma.subtitle.h3 [
    prop.text "Subtitle 3"
]
Bulma.subtitle.h4 [
    prop.text "Subtitle 4"
]
Bulma.subtitle.h5 [
    prop.text "Subtitle 5"
]
Bulma.subtitle.h6 [
    prop.text "Subtitle 6"
]
                """
            ]
        ]
        Bulma.content [ Bulma.subtitle [ prop.text "Using paragraphs" ] ]
        Bulma.columns [
            Bulma.column [
                Bulma.title.p [
                    title.is1
                    prop.text "Title 1"
                ]
                Bulma.title.p [
                    title.is2
                    prop.text "Title 2"
                ]
                Bulma.title.p [
                    title.is3
                    prop.text "Title 3"
                ]
                Bulma.title.p [
                    title.is4
                    prop.text "Title 4"
                ]
                Bulma.title.p [
                    title.is5
                    prop.text "Title 5"
                ]
                Bulma.title.p [
                    title.is6
                    prop.text "Title 6"
                ]
            ]
            Bulma.column [
                Code.render
                    """
Bulma.title.p [
    title.is1
    prop.text "Title 1"
]
Bulma.title.p [
    title.is2
    prop.text "Title 2"
]
Bulma.title.p [
    title.is3
    prop.text "Title 3"
]
Bulma.title.p [
    title.is4
    prop.text "Title 4"
]
Bulma.title.p [
    title.is5
    prop.text "Title 5"
]
Bulma.title.p [
    title.is6
    prop.text "Title 6"
]
                """
            ]
        ]
    ]
