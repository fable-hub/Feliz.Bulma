module Docs.Pages.Helpers.ColorPalette

open Feliz
open Feliz.Bulma
open Docs.Helpers

type private Swatch =
    [<ReactComponent>]
    static member WithColor(color: string) =
        Bulma.text.span [
            prop.style [
                style.custom ("--background", $"var(%s{color})")
                style.backgroundColor "var(--background)"
                style.borderRadius (length.em 0.25)
                style.custom (
                    "boxShadow",
                    "0 .125em .25em 0 rgba(0,0,0,.1),inset 0 0 0 1px rgba(0,0,0,.1)"
                )
                style.minHeight (length.rem 1.5)
                style.minWidth (length.rem 1.5)
                style.padding (length.rem 0.5)
                style.verticalAlign.top
                style.display.inlineFlex
            ]
        ]

    [<ReactComponent>]
    static member WithProperty(property: IReactProperty) =
        Bulma.text.span [
            property
            prop.style [
                style.borderRadius (length.em 0.25)
                style.custom (
                    "boxShadow",
                    "0 .125em .25em 0 rgba(0,0,0,.1),inset 0 0 0 1px rgba(0,0,0,.1)"
                )
                style.minHeight (length.rem 1.5)
                style.minWidth (length.rem 1.5)
                style.padding (length.rem 0.5)
                style.verticalAlign.top
                style.display.inlineFlex
            ]
        ]

let view =
    let textRow
        swatchColor
        textColor
        (bulmaClass: string)
        swatchColorInvert
        textColorInvert
        (bulmaClassInvert: string)
        =
        Html.tableRow [
            Html.td [ Html.code bulmaClass ]
            Html.td [
                textColor
                prop.text "Hello Bulma"
            ]
            Html.td [ Swatch.WithColor(swatchColor) ]
            Html.td [
                textColorInvert
                prop.text "Hello Bulma"
            ]
            Html.td [ Swatch.WithColor(swatchColorInvert) ]
        ]

    let backgroundRow backgroundColor textColor (bulmaClass: string) =
        Html.tableRow [
            Html.td [ Html.code bulmaClass ]
            Html.td [
                backgroundColor
                prop.children [
                    Bulma.text.span [
                        textColor
                        prop.text "Hello Bulma"
                    ]
                ]
            ]
            Html.td [
                text.hasTextCentered
                prop.children [ Swatch.WithProperty(backgroundColor) ]
            ]
        ]

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Color Palette Helpers"
        Html.hr []

        Bulma.content [
            Html.p "Bulma comes with 7 primary colors:"
            Bulma.table [
                table.isBordered
                prop.children [
                    Html.tbody [
                        Html.tableRow [
                            Html.td [ Html.code "text" ]
                            Html.td [ Swatch.WithColor("--bulma-text") ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "primary" ]
                            Html.td [ Swatch.WithColor("--bulma-primary") ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "info" ]
                            Html.td [ Swatch.WithColor("--bulma-info") ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "link" ]
                            Html.td [ Swatch.WithColor("--bulma-link") ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "success" ]
                            Html.td [ Swatch.WithColor("--bulma-success") ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "warning" ]
                            Html.td [ Swatch.WithColor("--bulma-warning") ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "danger" ]
                            Html.td [ Swatch.WithColor("--bulma-danger") ]
                        ]
                    ]
                ]
            ]

            Bulma.title "Text color"
            Html.p [
                Html.text "Bulma comes with CSS classes for "
                Html.strong "27 shades "
                Html.text "of each color. Each shade also comes with an "
                Html.strong "invert "
                Html.text
                    "equivalent, that is useful to combine in a foreground/background combination."
            ]
            Bulma.content [
                Bulma.table [
                    table.isBordered
                    prop.children [
                        Html.thead [
                            Html.tableRow [
                                Html.th "Property"
                                Html.th [
                                    prop.colSpan 2
                                    prop.text "Example"
                                ]
                                Html.th [
                                    prop.colSpan 2
                                    prop.text "Invert"
                                ]
                            ]
                        ]
                        Html.tbody [
                            textRow
                                "--bulma-primary"
                                color.hasTextPrimary
                                "color.hasTextPrimary"
                                "--bulma-primary-invert"
                                color.hasTextPrimaryInvert
                                "color.hasTextPrimaryInvert"
                            textRow
                                "--bulma-primary-00"
                                color.hasTextPrimary00
                                "color.hasTextPrimary00"
                                "--bulma-primary-00-invert"
                                color.hasTextPrimary00Invert
                                "color.hasTextPrimary00Invert"
                            textRow
                                "--bulma-primary-05"
                                color.hasTextPrimary05
                                "color.hasTextPrimary05"
                                "--bulma-primary-05-invert"
                                color.hasTextPrimary05Invert
                                "color.hasTextPrimary05Invert"
                            textRow
                                "--bulma-primary-10"
                                color.hasTextPrimary10
                                "color.hasTextPrimary10"
                                "--bulma-primary-10-invert"
                                color.hasTextPrimary10Invert
                                "color.hasTextPrimary10Invert"
                            textRow
                                "--bulma-primary-15"
                                color.hasTextPrimary15
                                "color.hasTextPrimary15"
                                "--bulma-primary-15-invert"
                                color.hasTextPrimary15Invert
                                "color.hasTextPrimary15Invert"
                            textRow
                                "--bulma-primary-20"
                                color.hasTextPrimary20
                                "color.hasTextPrimary20"
                                "--bulma-primary-20-invert"
                                color.hasTextPrimary20Invert
                                "color.hasTextPrimary20Invert"
                            textRow
                                "--bulma-primary-25"
                                color.hasTextPrimary25
                                "color.hasTextPrimary25"
                                "--bulma-primary-25-invert"
                                color.hasTextPrimary25Invert
                                "color.hasTextPrimary25Invert"
                            textRow
                                "--bulma-primary-30"
                                color.hasTextPrimary30
                                "color.hasTextPrimary30"
                                "--bulma-primary-30-invert"
                                color.hasTextPrimary30Invert
                                "color.hasTextPrimary30Invert"
                            textRow
                                "--bulma-primary-35"
                                color.hasTextPrimary35
                                "color.hasTextPrimary35"
                                "--bulma-primary-35-invert"
                                color.hasTextPrimary35Invert
                                "color.hasTextPrimary35Invert"
                            textRow
                                "--bulma-primary-40"
                                color.hasTextPrimary40
                                "color.hasTextPrimary40"
                                "--bulma-primary-40-invert"
                                color.hasTextPrimary40Invert
                                "color.hasTextPrimary40Invert"
                            textRow
                                "--bulma-primary-45"
                                color.hasTextPrimary45
                                "color.hasTextPrimary45"
                                "--bulma-primary-45-invert"
                                color.hasTextPrimary45Invert
                                "color.hasTextPrimary45Invert"
                            textRow
                                "--bulma-primary-50"
                                color.hasTextPrimary50
                                "color.hasTextPrimary50"
                                "--bulma-primary-50-invert"
                                color.hasTextPrimary50Invert
                                "color.hasTextPrimary50Invert"
                            textRow
                                "--bulma-primary-55"
                                color.hasTextPrimary55
                                "color.hasTextPrimary55"
                                "--bulma-primary-55-invert"
                                color.hasTextPrimary55Invert
                                "color.hasTextPrimary55Invert"
                            textRow
                                "--bulma-primary-60"
                                color.hasTextPrimary60
                                "color.hasTextPrimary60"
                                "--bulma-primary-60-invert"
                                color.hasTextPrimary60Invert
                                "color.hasTextPrimary60Invert"
                            textRow
                                "--bulma-primary-65"
                                color.hasTextPrimary65
                                "color.hasTextPrimary65"
                                "--bulma-primary-65-invert"
                                color.hasTextPrimary65Invert
                                "color.hasTextPrimary65Invert"
                            textRow
                                "--bulma-primary-70"
                                color.hasTextPrimary70
                                "color.hasTextPrimary70"
                                "--bulma-primary-70-invert"
                                color.hasTextPrimary70Invert
                                "color.hasTextPrimary70Invert"
                            textRow
                                "--bulma-primary-75"
                                color.hasTextPrimary75
                                "color.hasTextPrimary75"
                                "--bulma-primary-75-invert"
                                color.hasTextPrimary75Invert
                                "color.hasTextPrimary75Invert"
                            textRow
                                "--bulma-primary-80"
                                color.hasTextPrimary80
                                "color.hasTextPrimary80"
                                "--bulma-primary-80-invert"
                                color.hasTextPrimary80Invert
                                "color.hasTextPrimary80Invert"
                            textRow
                                "--bulma-primary-85"
                                color.hasTextPrimary85
                                "color.hasTextPrimary85"
                                "--bulma-primary-85-invert"
                                color.hasTextPrimary85Invert
                                "color.hasTextPrimary85Invert"
                            textRow
                                "--bulma-primary-90"
                                color.hasTextPrimary90
                                "color.hasTextPrimary90"
                                "--bulma-primary-90-invert"
                                color.hasTextPrimary90Invert
                                "color.hasTextPrimary90Invert"
                            textRow
                                "--bulma-primary-95"
                                color.hasTextPrimary95
                                "color.hasTextPrimary95"
                                "--bulma-primary-95-invert"
                                color.hasTextPrimary95Invert
                                "color.hasTextPrimary95Invert"
                            textRow
                                "--bulma-primary-100"
                                color.hasTextPrimary100
                                "color.hasTextPrimary100"
                                "--bulma-primary-100-invert"
                                color.hasTextPrimary100Invert
                                "color.hasTextPrimary100Invert"
                            textRow
                                "--bulma-primary-light"
                                color.hasTextPrimaryLight
                                "color.hasTextPrimaryLight"
                                "--bulma-primary-light-invert"
                                color.hasTextPrimaryLightInvert
                                "color.hasTextPrimaryLightInvert"
                            textRow
                                "--bulma-primary-dark"
                                color.hasTextPrimaryDark
                                "color.hasTextPrimaryDark"
                                "--bulma-primary-dark-invert"
                                color.hasTextPrimaryDarkInvert
                                "color.hasTextPrimaryDarkInvert"
                            textRow
                                "--bulma-primary-soft"
                                color.hasTextPrimarySoft
                                "color.hasTextPrimarySoft"
                                "--bulma-primary-soft-invert"
                                color.hasTextPrimarySoftInvert
                                "color.hasTextPrimarySoftInvert"
                            textRow
                                "--bulma-primary-bold"
                                color.hasTextPrimaryBold
                                "color.hasTextPrimaryBold"
                                "--bulma-primary-bold-invert"
                                color.hasTextPrimaryBoldInvert
                                "color.hasTextPrimaryBoldInvert"
                            textRow
                                "--bulma-primary-on-scheme"
                                color.hasTextPrimaryOnScheme
                                "color.hasTextPrimaryOnScheme"
                                "--bulma-primary-on-scheme-invert"
                                color.hasTextPrimaryOnSchemeInvert
                                "color.hasTextPrimaryOnSchemeInvert"
                        ]
                    ]
                ]
            ]

            Bulma.title "Background color"
            Html.p [
                Html.text "All 27 shades are also available as "
                Html.strong "background helpers"
                Html.text
                    ". Combined with the invert color as foreground, it's easy to make readable elements with just 2 classes. "
            ]
            Bulma.content [
                Bulma.table [
                    table.isBordered
                    prop.children [
                        Html.thead [
                            Html.tableRow [
                                Html.th "Property"
                                Html.th "Example"
                                Html.th "Swatch"
                            ]
                        ]
                        Html.tbody [
                            backgroundRow
                                color.hasBackgroundPrimary
                                color.hasTextPrimaryInvert
                                "color.hasBackgroundPrimary"
                            backgroundRow
                                color.hasBackgroundPrimary00
                                color.hasTextPrimary00Invert
                                "color.hasBackgroundPrimary00"
                            backgroundRow
                                color.hasBackgroundPrimary05
                                color.hasTextPrimary05Invert
                                "color.hasBackgroundPrimary05"
                            backgroundRow
                                color.hasBackgroundPrimary10
                                color.hasTextPrimary10Invert
                                "color.hasBackgroundPrimary10"
                            backgroundRow
                                color.hasBackgroundPrimary15
                                color.hasTextPrimary15Invert
                                "color.hasBackgroundPrimary15"
                            backgroundRow
                                color.hasBackgroundPrimary20
                                color.hasTextPrimary20Invert
                                "color.hasBackgroundPrimary20"

                            backgroundRow
                                color.hasBackgroundPrimary25
                                color.hasTextPrimary25Invert
                                "color.hasBackgroundPrimary25"
                            backgroundRow
                                color.hasBackgroundPrimary30
                                color.hasTextPrimary30Invert
                                "color.hasBackgroundPrimary30"
                            backgroundRow
                                color.hasBackgroundPrimary35
                                color.hasTextPrimary35Invert
                                "color.hasBackgroundPrimary35"
                            backgroundRow
                                color.hasBackgroundPrimary40
                                color.hasTextPrimary40Invert
                                "color.hasBackgroundPrimary40"
                            backgroundRow
                                color.hasBackgroundPrimary45
                                color.hasTextPrimary45Invert
                                "color.hasBackgroundPrimary45"
                            backgroundRow
                                color.hasBackgroundPrimary50
                                color.hasTextPrimary50Invert
                                "color.hasBackgroundPrimary50"
                            backgroundRow
                                color.hasBackgroundPrimary55
                                color.hasTextPrimary55Invert
                                "color.hasBackgroundPrimary55"
                            backgroundRow
                                color.hasBackgroundPrimary60
                                color.hasTextPrimary60Invert
                                "color.hasBackgroundPrimary60"
                            backgroundRow
                                color.hasBackgroundPrimary65
                                color.hasTextPrimary65Invert
                                "color.hasBackgroundPrimary65"
                            backgroundRow
                                color.hasBackgroundPrimary70
                                color.hasTextPrimary70Invert
                                "color.hasBackgroundPrimary70"
                            backgroundRow
                                color.hasBackgroundPrimary75
                                color.hasTextPrimary75Invert
                                "color.hasBackgroundPrimary75"
                            backgroundRow
                                color.hasBackgroundPrimary80
                                color.hasTextPrimary80Invert
                                "color.hasBackgroundPrimary80"
                            backgroundRow
                                color.hasBackgroundPrimary85
                                color.hasTextPrimary85Invert
                                "color.hasBackgroundPrimary85"
                            backgroundRow
                                color.hasBackgroundPrimary90
                                color.hasTextPrimary90Invert
                                "color.hasBackgroundPrimary90"
                            backgroundRow
                                color.hasBackgroundPrimary95
                                color.hasTextPrimary95Invert
                                "color.hasBackgroundPrimary95"
                            backgroundRow
                                color.hasBackgroundPrimary100
                                color.hasTextPrimary100Invert
                                "color.hasBackgroundPrimary100"
                            backgroundRow
                                color.hasBackgroundPrimaryLight
                                color.hasTextPrimaryLightInvert
                                "color.hasBackgroundPrimaryLight"
                            backgroundRow
                                color.hasBackgroundPrimaryDark
                                color.hasTextPrimaryDarkInvert
                                "color.hasBackgroundPrimaryDark"
                            backgroundRow
                                color.hasBackgroundPrimarySoft
                                color.hasTextPrimarySoftInvert
                                "color.hasBackgroundPrimarySoft"
                            backgroundRow
                                color.hasBackgroundPrimaryBold
                                color.hasTextPrimaryBoldInvert
                                "color.hasBackgroundPrimaryBold"
                            backgroundRow
                                color.hasBackgroundPrimaryOnScheme
                                color.hasTextPrimaryOnSchemeInvert
                                "color.hasBackgroundPrimaryOnScheme"
                        ]
                    ]
                ]
            ]
        ]
    ]
