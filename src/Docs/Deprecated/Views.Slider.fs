module Docs.Views.Slider

open Feliz
open Feliz.Bulma
open Shared

let description =
    Html.div [
        Bulma.content [
            Bulma.title.h5 "Basic slider"
            code
                """open Feliz.Bulma

Slider.slider [
    slider.isFullWidth
    prop.onChange (fun (v:string) -> Fable.Core.JS.console.log v)
]
"""
            Slider.slider [
                slider.isFullWidth
                prop.onChange (fun (v: string) -> Fable.Core.JS.console.log v)
            ]
        ]

        Bulma.content [
            Bulma.title.h5 "Colored slider"
            code
                """Slider.slider [ slider.isFullWidth; color.isSuccess ]
Slider.slider [ slider.isFullWidth; color.isWarning ]
Slider.slider [ slider.isFullWidth; color.isPrimary ]
Slider.slider [ slider.isFullWidth; color.isInfo ]
Slider.slider [ slider.isFullWidth; color.isDanger ]
Slider.slider [ slider.isFullWidth; color.isDark ]
"""
            Slider.slider [
                slider.isFullWidth
                color.isSuccess
            ]
            Slider.slider [
                slider.isFullWidth
                color.isWarning
            ]
            Slider.slider [
                slider.isFullWidth
                color.isPrimary
            ]
            Slider.slider [
                slider.isFullWidth
                color.isInfo
            ]
            Slider.slider [
                slider.isFullWidth
                color.isDanger
            ]
            Slider.slider [
                slider.isFullWidth
                color.isDark
            ]
        ]

        Bulma.content [
            Bulma.title.h5 "Sized slider"
            code
                """Slider.slider [ slider.isFullWidth; slider.isSmall ]
Slider.slider [ slider.isFullWidth ]
Slider.slider [ slider.isFullWidth; slider.isMedium ]
Slider.slider [ slider.isFullWidth; slider.isLarge ]
"""
            Slider.slider [
                slider.isFullWidth
                slider.isSmall
            ]
            Slider.slider [ slider.isFullWidth ]
            Slider.slider [
                slider.isFullWidth
                slider.isMedium
            ]
            Slider.slider [
                slider.isFullWidth
                slider.isLarge
            ]
        ]

        Bulma.content [
            Bulma.title.h5 "Circle styled slider"
            code
                """Slider.slider [
    slider.isFullWidth
    slider.isCircle
    slider.isLarge
    color.isInfo
    prop.step 10
]
"""
            Slider.slider [
                slider.isFullWidth
                slider.isCircle
                slider.isLarge
                color.isInfo
                prop.step 10
            ]
        ]

        Bulma.content [
            Bulma.title.h5 "Vertical slider"
            code
                """Slider.slider [
    slider.isVertical
    slider.isMedium
    color.isWarning
    prop.step 10
]
"""
            Slider.slider [
                slider.isVertical
                slider.isMedium
                color.isWarning
                prop.step 10
            ]
        ]
    ]

let view =
    ComponentView
        "Slider"
        "Feliz.Bulma.Slider"
        "https://wikiki.github.io/form/slider/"
        description
        (installationView "Feliz.Bulma.Slider" "bulma-slider" "bulma-slider")
