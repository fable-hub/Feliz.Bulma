module Docs.Views.Documentation.Helpers

open Feliz
open Feliz.Bulma

[<ReactComponent>]
let HelpersColorComponent () =

    let row backgroundColor foregroundColor (bulmaClass: string) =
        Html.tableRow [
            Html.td [ Html.code bulmaClass ]
            Html.td [
                backgroundColor
                prop.children [
                    Bulma.text.span [
                        foregroundColor
                        prop.text "Hello Bulma"
                    ]
                ]
            ]
        ]

    let table (rows: seq<Fable.React.ReactElement>) =
        Bulma.table [
            table.isBordered
            prop.children [
                Html.thead [
                    Html.tableRow [
                        Html.th "Property"
                        Html.th "Example"
                    ]
                ]
                Html.tbody [ prop.children rows ]
            ]
        ]

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Color Helpers"
        Html.hr []

        Bulma.content [
            Bulma.title "Text color"
            Html.p [
                Html.text "You can set any element to one of the "
                Html.strong "10 colors "
                Html.text " or"
                Html.strong " 9 shades of grey"
                Html.text ":"
            ]
            Bulma.content [
                table [
                    row Bulma.color.hasBackgroundBlack Bulma.color.hasTextWhite "Bulma.color.hasTextWhite"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextBlack "Bulma.color.hasTextBlack"
                    row Bulma.color.hasBackgroundGrey Bulma.color.hasTextLight "Bulma.color.hasTextLight"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextDark "Bulma.color.hasTextDark"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextPrimary "Bulma.color.hasTextPrimary"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextLink "Bulma.color.hasTextLink"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextInfo "Bulma.color.hasTextInfo"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextSuccess "Bulma.color.hasTextSuccess"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextWarning "Bulma.color.hasTextWarning"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextDanger "Bulma.color.hasTextDanger"
                ]

                table [
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextBlackBis "Bulma.color.hasTextBlackBis"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextBlackTer "Bulma.color.hasTextBlackTer"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextGreyDarker "Bulma.color.hasTextGreyDarker"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextGreyDark "Bulma.color.hasTextGreyDark"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextGrey "Bulma.color.hasTextGrey"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextGreyLight "Bulma.color.hasTextGreyLight"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextGreyLighter "Bulma.color.hasTextGreyLighter"
                    row Bulma.color.hasBackgroundBlack Bulma.color.hasTextWhiteTer "Bulma.color.hasTextWhiteTer"
                    row Bulma.color.hasBackgroundBlack Bulma.color.hasTextWhiteBis "Bulma.color.hasTextWhiteBis"
                ]
            ]
            Html.p [
                Html.text "You can use each color in their "
                Html.strong "light "
                Html.text " and"
                Html.strong " dark versions"
                Html.text "."
            ]
            Bulma.content [
                table [
                    row Bulma.color.hasBackgroundDark Bulma.color.hasTextPrimaryLight "Bulma.color.hasTextPrimaryLight"
                    row Bulma.color.hasBackgroundDark Bulma.color.hasTextLinkLight "Bulma.color.hasTextLinkLight"
                    row Bulma.color.hasBackgroundDark Bulma.color.hasTextInfoLight "Bulma.color.hasTextInfoLight"
                    row Bulma.color.hasBackgroundDark Bulma.color.hasTextSuccessLight "Bulma.color.hasTextSuccessLight"
                    row Bulma.color.hasBackgroundDark Bulma.color.hasTextWarningLight "Bulma.color.hasTextWarningLight"
                    row Bulma.color.hasBackgroundDark Bulma.color.hasTextDangerLight "Bulma.color.hasTextDangerLight"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextPrimaryDark "Bulma.color.hasTextPrimaryDark"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextLinkDark "Bulma.color.hasTextLinkDark"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextInfoDark "Bulma.color.hasTextInfoDark"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextSuccessDark "Bulma.color.hasTextSuccessDark"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextWarningDark "Bulma.color.hasTextWarningDark"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextDangerDark "Bulma.color.hasTextDangerDark"
                ]
            ]
            Html.p [
                Html.text "You can also "
                Html.strong "inherit "
                Html.text "the color, or use the "
                Html.strong "current "
                Html.text "one:"
            ]
            Bulma.content [
                table [
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextCurrent "Bulma.color.hasTextCurrent"
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextInherit "Bulma.color.hasTextInherit"
                ]
            ]
        ]
        Bulma.content [
            Bulma.title "Background color"
            Html.p [
                Html.text "You can set any element to one of the "
                Html.strong "10 colors "
                Html.text " or"
                Html.strong " 9 shades of grey"
                Html.text ":"
            ]
            Bulma.content [
                table [
                    row Bulma.color.hasBackgroundWhite Bulma.color.hasTextBlack "Bulma.color.hasBackgroundWhite"
                    row Bulma.color.hasBackgroundBlack Bulma.color.hasTextWhite "Bulma.color.hasBackgroundBlack"
                    row Bulma.color.hasBackgroundLight Bulma.color.hasTextBlack "Bulma.color.hasBackgroundLight"
                    row Bulma.color.hasBackgroundDark Bulma.color.hasTextWhite "Bulma.color.hasBackgroundDark"
                    row Bulma.color.hasBackgroundPrimary Bulma.color.hasTextBlack "Bulma.color.hasBackgroundPrimary"
                    row Bulma.color.hasBackgroundLink Bulma.color.hasTextBlack "Bulma.color.hasBackgroundLink"
                    row Bulma.color.hasBackgroundInfo Bulma.color.hasTextBlack "Bulma.color.hasBackgroundInfo"
                    row Bulma.color.hasBackgroundSuccess Bulma.color.hasTextBlack "Bulma.color.hasBackgroundSuccess"
                    row Bulma.color.hasBackgroundWarning Bulma.color.hasTextBlack "Bulma.color.hasBackgroundWarning"
                    row Bulma.color.hasBackgroundDanger Bulma.color.hasTextBlack "Bulma.color.hasBackgroundDanger"
                ]

                table [
                    row Bulma.color.hasBackgroundBlackBis Bulma.color.hasTextWhite "Bulma.color.hasBackgroundBlackBis"
                    row Bulma.color.hasBackgroundBlackTer Bulma.color.hasTextWhite "Bulma.color.hasBackgroundBlackTer"
                    row
                        Bulma.color.hasBackgroundGreyDarker
                        Bulma.color.hasTextWhite
                        "Bulma.color.hasBackgroundGreyDarker"
                    row Bulma.color.hasBackgroundGreyDark Bulma.color.hasTextWhite "Bulma.color.hasBackgroundGreyDark"
                    row Bulma.color.hasBackgroundGrey Bulma.color.hasTextWhite "Bulma.color.hasBackgroundGreyDark"
                    row Bulma.color.hasBackgroundGreyLight Bulma.color.hasTextWhite "Bulma.color.hasBackgroundGreyLight"
                    row
                        Bulma.color.hasBackgroundGreyLighter
                        Bulma.color.hasTextWhite
                        "Bulma.color.hasBackgroundGreyLighter"
                    row Bulma.color.hasBackgroundWhiteTer Bulma.color.hasTextBlack "Bulma.color.hasBackgroundWhiteTer"
                    row Bulma.color.hasBackgroundWhiteBis Bulma.color.hasTextBlack "Bulma.color.hasBackgroundWhiteBis"
                ]
            ]
        ]
        Bulma.content [
            Html.p [
                Html.text "You can use each color in their "
                Html.strong "light "
                Html.text "and "
                Html.strong "dark versions. "
            ]
            Bulma.content [
                table [
                    row
                        Bulma.color.hasBackgroundPrimaryLight
                        Bulma.color.hasTextBlack
                        "Bulma.color.hasBackgroundPrimaryLight"
                    row Bulma.color.hasBackgroundLinkLight Bulma.color.hasTextBlack "Bulma.color.hasBackgroundLinkLight"
                    row Bulma.color.hasBackgroundInfoLight Bulma.color.hasTextBlack "Bulma.color.hasBackgroundInfoLight"
                    row
                        Bulma.color.hasBackgroundSuccessLight
                        Bulma.color.hasTextBlack
                        "Bulma.color.hasBackgroundSuccessLight"
                    row
                        Bulma.color.hasBackgroundWarningLight
                        Bulma.color.hasTextBlack
                        "Bulma.color.hasBackgroundWarningLight"
                    row
                        Bulma.color.hasBackgroundDangerLight
                        Bulma.color.hasTextBlack
                        "Bulma.color.hasBackgroundDangerLight"
                    row
                        Bulma.color.hasBackgroundPrimaryDark
                        Bulma.color.hasTextBlack
                        "Bulma.color.hasBackgroundPrimaryDark"
                    row Bulma.color.hasBackgroundLinkDark Bulma.color.hasTextBlack "Bulma.color.hasBackgroundLinkDark"
                    row Bulma.color.hasBackgroundInfoDark Bulma.color.hasTextBlack "Bulma.color.hasBackgroundInfoDark"
                    row
                        Bulma.color.hasBackgroundSuccessDark
                        Bulma.color.hasTextBlack
                        "Bulma.color.hasBackgroundSuccessDark"
                    row
                        Bulma.color.hasBackgroundWarningDark
                        Bulma.color.hasTextBlack
                        "Bulma.color.hasBackgroundWarningDark"
                    row
                        Bulma.color.hasBackgroundDangerDark
                        Bulma.color.hasTextBlack
                        "Bulma.color.hasBackgroundDangerDark"
                ]
                Html.p [
                    Html.text "You can also "
                    Html.strong "inherit "
                    Html.text "the background color, or use the "
                    Html.strong "current color "
                    Html.text "as background one:"
                ]
                Bulma.content [
                    table [
                        row Bulma.color.hasBackgroundCurrent Bulma.color.hasTextBlack "Bulma.color.hasBackgroundCurrent"
                        row Bulma.color.hasBackgroundInherit Bulma.color.hasTextWhite "Bulma.color.hasBackgroundInherit"
                    ]
                ]
            ]
        ]
    ]

let helpersColor = HelpersColorComponent()

[<ReactComponent>]
let HelpersColorPaletteComponent() =
    let colorswatch (color: string) =
        Bulma.text.span [
            prop.className "bd-color-swatch"
            prop.style [
                style.custom("background", $"var(%s{color})")
            ]
        ]

    let textRow swatchColor textColor (bulmaClass: string) swatchColorInvert  textColorInvert (bulmaClassInvert: string) =
        Html.tableRow [
            Html.td [ Html.code bulmaClass ]
            Html.td [
                textColor
                prop.text "Hello Bulma"
            ]
            Html.td [ colorswatch swatchColor ]
            Html.td [
                textColorInvert
                prop.text "Hello Bulma"
            ]
            Html.td [ colorswatch swatchColorInvert ]
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
                prop.children [
                    Bulma.text.span [
                        prop.className "bd-color-swatch"
                        backgroundColor
                    ]
                ]
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
                            Html.td [ colorswatch "--bulma-text" ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "primary" ]
                            Html.td [ colorswatch "--bulma-primary" ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "info" ]
                            Html.td [ colorswatch "--bulma-info" ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "link" ]
                            Html.td [ colorswatch "--bulma-link" ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "success" ]
                            Html.td [ colorswatch "--bulma-success" ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "warning" ]
                            Html.td [ colorswatch "--bulma-warning" ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "danger" ]
                            Html.td [ colorswatch "--bulma-danger" ]
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
                Html.text "equivalent, that is useful to combine in a foreground/background combination."
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
                                "Bulma.color.hasTextPrimary"
                                "--bulma-primary-invert"
                                color.hasTextPrimaryInvert
                                "Bulma.color.hasTextPrimaryInvert"
                            textRow
                                "--bulma-primary-00"
                                color.hasTextPrimary00
                                "Bulma.color.hasTextPrimary00"
                                "--bulma-primary-00-invert"
                                color.hasTextPrimary00Invert
                                "Bulma.color.hasTextPrimary00Invert"
                            textRow
                                "--bulma-primary-05"
                                color.hasTextPrimary05
                                "Bulma.color.hasTextPrimary05"
                                "--bulma-primary-05-invert"
                                color.hasTextPrimary05Invert
                                "Bulma.color.hasTextPrimary05Invert"
                            textRow
                                "--bulma-primary-10"
                                color.hasTextPrimary10
                                "Bulma.color.hasTextPrimary10"
                                "--bulma-primary-10-invert"
                                color.hasTextPrimary10Invert
                                "Bulma.color.hasTextPrimary10Invert"
                            textRow
                                "--bulma-primary-15"
                                color.hasTextPrimary15
                                "Bulma.color.hasTextPrimary15"
                                "--bulma-primary-15-invert"
                                color.hasTextPrimary15Invert
                                "Bulma.color.hasTextPrimary15Invert"
                            textRow
                                "--bulma-primary-20"
                                color.hasTextPrimary20
                                "Bulma.color.hasTextPrimary20"
                                "--bulma-primary-20-invert"
                                color.hasTextPrimary20Invert
                                "Bulma.color.hasTextPrimary20Invert"
                            textRow
                                "--bulma-primary-25"
                                color.hasTextPrimary25
                                "Bulma.color.hasTextPrimary25"
                                "--bulma-primary-25-invert"
                                color.hasTextPrimary25Invert
                                "Bulma.color.hasTextPrimary25Invert"
                            textRow
                                "--bulma-primary-30"
                                color.hasTextPrimary30
                                "Bulma.color.hasTextPrimary30"
                                "--bulma-primary-30-invert"
                                color.hasTextPrimary30Invert
                                "Bulma.color.hasTextPrimary30Invert"
                            textRow
                                "--bulma-primary-35"
                                color.hasTextPrimary35
                                "Bulma.color.hasTextPrimary35"
                                "--bulma-primary-35-invert"
                                color.hasTextPrimary35Invert
                                "Bulma.color.hasTextPrimary35Invert"
                            textRow
                                "--bulma-primary-40"
                                color.hasTextPrimary40
                                "Bulma.color.hasTextPrimary40"
                                "--bulma-primary-40-invert"
                                color.hasTextPrimary40Invert
                                "Bulma.color.hasTextPrimary40Invert"
                            textRow
                                "--bulma-primary-45"
                                color.hasTextPrimary45
                                "Bulma.color.hasTextPrimary45"
                                "--bulma-primary-45-invert"
                                color.hasTextPrimary45Invert
                                "Bulma.color.hasTextPrimary45Invert"
                            textRow
                                "--bulma-primary-50"
                                color.hasTextPrimary50
                                "Bulma.color.hasTextPrimary50"
                                "--bulma-primary-50-invert"
                                color.hasTextPrimary50Invert
                                "Bulma.color.hasTextPrimary50Invert"
                            textRow
                                "--bulma-primary-55"
                                color.hasTextPrimary55
                                "Bulma.color.hasTextPrimary55"
                                "--bulma-primary-55-invert"
                                color.hasTextPrimary55Invert
                                "Bulma.color.hasTextPrimary55Invert"
                            textRow
                                "--bulma-primary-60"
                                color.hasTextPrimary60
                                "Bulma.color.hasTextPrimary60"
                                "--bulma-primary-60-invert"
                                color.hasTextPrimary60Invert
                                "Bulma.color.hasTextPrimary60Invert"
                            textRow
                                "--bulma-primary-65"
                                color.hasTextPrimary65
                                "Bulma.color.hasTextPrimary65"
                                "--bulma-primary-65-invert"
                                color.hasTextPrimary65Invert
                                "Bulma.color.hasTextPrimary65Invert"
                            textRow
                                "--bulma-primary-70"
                                color.hasTextPrimary70
                                "Bulma.color.hasTextPrimary70"
                                "--bulma-primary-70-invert"
                                color.hasTextPrimary70Invert
                                "Bulma.color.hasTextPrimary70Invert"
                            textRow
                                "--bulma-primary-75"
                                color.hasTextPrimary75
                                "Bulma.color.hasTextPrimary75"
                                "--bulma-primary-75-invert"
                                color.hasTextPrimary75Invert
                                "Bulma.color.hasTextPrimary75Invert"
                            textRow
                                "--bulma-primary-80"
                                color.hasTextPrimary80
                                "Bulma.color.hasTextPrimary80"
                                "--bulma-primary-80-invert"
                                color.hasTextPrimary80Invert
                                "Bulma.color.hasTextPrimary80Invert"
                            textRow
                                "--bulma-primary-85"
                                color.hasTextPrimary85
                                "Bulma.color.hasTextPrimary85"
                                "--bulma-primary-85-invert"
                                color.hasTextPrimary85Invert
                                "Bulma.color.hasTextPrimary85Invert"
                            textRow
                                "--bulma-primary-90"
                                color.hasTextPrimary90
                                "Bulma.color.hasTextPrimary90"
                                "--bulma-primary-90-invert"
                                color.hasTextPrimary90Invert
                                "Bulma.color.hasTextPrimary90Invert"
                            textRow
                                "--bulma-primary-95"
                                color.hasTextPrimary95
                                "Bulma.color.hasTextPrimary95"
                                "--bulma-primary-95-invert"
                                color.hasTextPrimary95Invert
                                "Bulma.color.hasTextPrimary95Invert"
                            textRow
                                "--bulma-primary-100"
                                color.hasTextPrimary100
                                "Bulma.color.hasTextPrimary100"
                                "--bulma-primary-100-invert"
                                color.hasTextPrimary100Invert
                                "Bulma.color.hasTextPrimary100Invert"
                            textRow
                                "--bulma-primary-light"
                                color.hasTextPrimaryLight
                                "Bulma.color.hasTextPrimaryLight"
                                "--bulma-primary-light-invert"
                                color.hasTextPrimaryLightInvert
                                "Bulma.color.hasTextPrimaryLightInvert"
                            textRow
                                "--bulma-primary-dark"
                                color.hasTextPrimaryDark
                                "Bulma.color.hasTextPrimaryDark"
                                "--bulma-primary-dark-invert"
                                color.hasTextPrimaryDarkInvert
                                "Bulma.color.hasTextPrimaryDarkInvert"
                            textRow
                                "--bulma-primary-soft"
                                color.hasTextPrimarySoft
                                "Bulma.color.hasTextPrimarySoft"
                                "--bulma-primary-soft-invert"
                                color.hasTextPrimarySoftInvert
                                "Bulma.color.hasTextPrimarySoftInvert"
                            textRow
                                "--bulma-primary-bold"
                                color.hasTextPrimaryBold
                                "Bulma.color.hasTextPrimaryBold"
                                "--bulma-primary-bold-invert"
                                color.hasTextPrimaryBoldInvert
                                "Bulma.color.hasTextPrimaryBoldInvert"
                            textRow
                                "--bulma-primary-on-scheme"
                                color.hasTextPrimaryOnScheme
                                "Bulma.color.hasTextPrimaryOnScheme"
                                "--bulma-primary-on-scheme-invert"
                                color.hasTextPrimaryOnSchemeInvert
                                "Bulma.color.hasTextPrimaryOnSchemeInvert"
                        ]
                    ]
                ]
            ]

            Bulma.title "Background color"
            Html.p [
                Html.text "All 27 shades are also available as "
                Html.strong "background helpers"
                Html.text ". Combined with the invert color as foreground, it's easy to make readable elements with just 2 classes. "
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
                                Bulma.color.hasBackgroundPrimary
                                Bulma.color.hasTextPrimaryInvert
                                "Bulma.color.hasBackgroundPrimary"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary00
                                Bulma.color.hasTextPrimary00Invert
                                "Bulma.color.hasBackgroundPrimary00"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary05
                                Bulma.color.hasTextPrimary05Invert
                                "Bulma.color.hasBackgroundPrimary05"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary10
                                Bulma.color.hasTextPrimary10Invert
                                "Bulma.color.hasBackgroundPrimary10"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary15
                                Bulma.color.hasTextPrimary15Invert
                                "Bulma.color.hasBackgroundPrimary15"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary20
                                Bulma.color.hasTextPrimary20Invert
                                "Bulma.color.hasBackgroundPrimary20"

                            backgroundRow
                                Bulma.color.hasBackgroundPrimary25
                                Bulma.color.hasTextPrimary25Invert
                                "Bulma.color.hasBackgroundPrimary25"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary30
                                Bulma.color.hasTextPrimary30Invert
                                "Bulma.color.hasBackgroundPrimary30"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary35
                                Bulma.color.hasTextPrimary35Invert
                                "Bulma.color.hasBackgroundPrimary35"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary40
                                Bulma.color.hasTextPrimary40Invert
                                "Bulma.color.hasBackgroundPrimary40"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary45
                                Bulma.color.hasTextPrimary45Invert
                                "Bulma.color.hasBackgroundPrimary45"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary50
                                Bulma.color.hasTextPrimary50Invert
                                "Bulma.color.hasBackgroundPrimary50"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary55
                                Bulma.color.hasTextPrimary55Invert
                                "Bulma.color.hasBackgroundPrimary55"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary60
                                Bulma.color.hasTextPrimary60Invert
                                "Bulma.color.hasBackgroundPrimary60"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary65
                                Bulma.color.hasTextPrimary65Invert
                                "Bulma.color.hasBackgroundPrimary65"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary70
                                Bulma.color.hasTextPrimary70Invert
                                "Bulma.color.hasBackgroundPrimary70"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary75
                                Bulma.color.hasTextPrimary75Invert
                                "Bulma.color.hasBackgroundPrimary75"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary80
                                Bulma.color.hasTextPrimary80Invert
                                "Bulma.color.hasBackgroundPrimary80"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary85
                                Bulma.color.hasTextPrimary85Invert
                                "Bulma.color.hasBackgroundPrimary85"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary90
                                Bulma.color.hasTextPrimary90Invert
                                "Bulma.color.hasBackgroundPrimary90"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary95
                                Bulma.color.hasTextPrimary95Invert
                                "Bulma.color.hasBackgroundPrimary95"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimary100
                                Bulma.color.hasTextPrimary100Invert
                                "Bulma.color.hasBackgroundPrimary100"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimaryLight
                                Bulma.color.hasTextPrimaryLightInvert
                                "Bulma.color.hasBackgroundPrimaryLight"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimaryDark
                                Bulma.color.hasTextPrimaryDarkInvert
                                "Bulma.color.hasBackgroundPrimaryDark"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimarySoft
                                Bulma.color.hasTextPrimarySoftInvert
                                "Bulma.color.hasBackgroundPrimarySoft"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimaryBold
                                Bulma.color.hasTextPrimaryBoldInvert
                                "Bulma.color.hasBackgroundPrimaryBold"
                            backgroundRow
                                Bulma.color.hasBackgroundPrimaryOnScheme
                                Bulma.color.hasTextPrimaryOnSchemeInvert
                                "Bulma.color.hasBackgroundPrimaryOnScheme"
                        ]
                    ]
                ]
            ]
        ]
    ]

let helpersColorPalette = HelpersColorPaletteComponent()

[<ReactComponent>]
let HelpersSpacingComponent() =
    let row (property: string) (extended: string) (example: string) =
        Html.tableRow [
            Html.td [
                Html.code property
                if not (System.String.IsNullOrEmpty(extended)) then
                    Html.text " and "
                    Html.code extended
            ]
            Html.td [ Html.code example ]
        ]

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Spacing Helpers"
        Html.hr []

        Bulma.content [
            Bulma.title "List of all spacing helpers"
            Html.p [
                Html.text "There are "
                Html.strong "112 spacing helpers "
                Html.text "to choose from:"
            ]
            Bulma.content [
                Bulma.table [
                    table.isBordered
                    prop.children [
                        Html.thead [
                            Html.tableRow [
                                Html.th "Property"
                                Html.th "Example"
                            ]
                        ]
                        Html.tbody [
                            row "margin" "" "Bulma.spacing.m0"
                            row "margin-top" "" "Bulma.spacing.mt0"
                            row "margin-right" "" "Bulma.spacing.mr0"
                            row "margin-bottom" "" "Bulma.spacing.mb0"
                            row "margin-left" "" "Bulma.spacing.ml0"
                            row "margin-left" "margin-right" "Bulma.spacing.mx0"
                            row "margin-top" "margin-bottom" "Bulma.spacing.my0"
                            row "padding" "" "Bulma.spacing.p0"
                            row "padding-top" "" "Bulma.spacing.pt0"
                            row "padding-right" "" "Bulma.spacing.pr0"
                            row "padding-bottom" "" "Bulma.spacing.pb0"
                            row "padding-left" "" "Bulma.spacing.pl0"
                            row "padding-left" "padding-right" "Bulma.spacing.px0"
                            row "padding-top" "padding-bottom" "Bulma.spacing.py0"
                        ]
                    ]
                ]
            ]
        ]
    ]

let helpersSpacing = HelpersSpacingComponent()

[<ReactComponent>]
let HelpersTypographyComponent() =
    let rowSize (property: string) (fontSize: string) bulmaClass =
        Html.tableRow [
            Html.td [ Html.code property ]
            Html.td [ Html.code fontSize ]
            Html.td [
                Bulma.text.span [
                    bulmaClass
                    prop.text "Example"
                ]
            ]
        ]

    let responsiveSize unchanged =
        Html.td [
            if unchanged then
                color.hasBackgroundDangerLight
            else
                prop.text "Unchanged"
        ]

    let responsiveAlignment leftAligned =
        Html.td [
            if leftAligned then
                color.hasBackgroundPrimaryLight
            prop.children [
                Bulma.text.span [
                    if leftAligned then
                        color.hasTextPrimary
                        prop.text "left-aligned"
                    else
                        prop.text "unchanged"
                ]
            ]
        ]

    let rowResponsive (property: string) (transform: bool -> Fable.React.ReactElement) (r1, r2, r3, r4, r5) =
        Html.tableRow [
            Html.td [ Html.code property ]
            transform r1
            transform r2
            transform r3
            transform r4
            transform r5
        ]

    let rowAlignment (property: string) (explain: string) (explainBold: string) =
        Html.tableRow [
            Html.td [ Html.code property ]
            Html.td [
                Html.text explain
                Html.strong explainBold
            ]
        ]

    let responsiveTable (rows: seq<Fable.React.ReactElement>) =
        Bulma.table [
            table.isBordered
            prop.children [
                Html.thead [
                    Html.tableRow [
                        Html.th "Property"
                        Html.th [
                            Html.strong "Mobile Up to "
                            Html.code "768px"
                        ]
                        Html.th [
                            Html.strong "Tablet Between "
                            Html.code "769px"
                            Html.strong " and "
                            Html.code "1023px"
                        ]
                        Html.th [
                            Html.strong "Desktop Between "
                            Html.code "1024px"
                            Html.strong " and "
                            Html.code "1215px"
                        ]
                        Html.th [
                            Html.strong "Widescreen Between "
                            Html.code "1216px"
                            Html.strong " and "
                            Html.code "1407px"
                        ]
                        Html.th [
                            Html.strong "Widescreen Between "
                            Html.code "1408px"
                            Html.strong " and above"
                        ]
                    ]
                ]
                Html.tbody rows
            ]
        ]

    let rowTextWeight textProperty (bulmaClass: string) (text: string) =
        Html.tableRow [
            Html.td [ Html.code bulmaClass ]
            Html.td [
                Html.text "Transforms the text weight to "
                Html.strong [
                    textProperty
                    prop.text text
                ]
            ]
        ]

    let rowFontFamily (bulmaClass: string) (code: string) =
        Html.tableRow [
            Html.td [ Html.code bulmaClass ]
            Html.td [
                Html.text "Sets the font family to "
                Html.code code
            ]
        ]

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Typography Helpers"
        Html.hr []

        Bulma.content [
            Bulma.title "Size"
            Html.p [
                Html.text "There are "
                Html.strong "7 sizes "
                Html.text "to choose from:"
            ]
            Bulma.content [
                Bulma.table [
                    table.isBordered
                    prop.children [
                        Html.thead [
                            Html.tableRow [
                                Html.th "Property"
                                Html.th "Font-size"
                                Html.th "Size"
                            ]
                        ]
                        Html.tbody [
                            rowSize "Bulma.size.isSize1" "3rem" size.isSize1
                            rowSize "Bulma.size.isSize2" "2.5rem" size.isSize2
                            rowSize "Bulma.size.isSize3" "2rem" size.isSize3
                            rowSize "Bulma.size.isSize4" "1.5rem" size.isSize4
                            rowSize "Bulma.size.isSize5" "1.25rem" size.isSize5
                            rowSize "Bulma.size.isSize6" "1rem" size.isSize6
                            rowSize "Bulma.size.isSize7" "0.75rem" size.isSize7
                        ]
                    ]
                ]
            ]

            Bulma.title "Responsive Size"
            Html.p [
                Html.text "You can choose a "
                Html.strong "specific "
                Html.text "size for "
                Html.i "each "
                Html.text "viewport width. You simply need to append the "
                Html.strong "viewport width "
                Html.text "to the size modifier."
            ]
            Html.p [
                Html.text "For example, here are the modifiers for "
                Html.code "Bulma.isSize1"
                Html.text ":"
            ]
            Bulma.content [
                responsiveTable [
                    rowResponsive "Bulma.size.isSize1Mobile" responsiveSize (true, false, false, false, false)
                    rowResponsive "Bulma.size.isSize1Touch" responsiveSize (true, true, false, false, false)
                    rowResponsive "Bulma.size.isSize1Tablet" responsiveSize (false, true, true, true, true)
                    rowResponsive "Bulma.size.isSize1Desktop" responsiveSize (false, false, true, true, true)
                    rowResponsive "Bulma.size.isSize1Widescreen" responsiveSize (false, false, false, true, true)
                    rowResponsive "Bulma.size.isSize1FullHd" responsiveSize (false, false, false, false, true)
                ]
            ]

            Bulma.title "Alignment"
            Html.p [
                Html.text "You can align the text with the use of one of "
                Html.strong "4 alignment helpers"
                Html.text ":"
            ]
            Bulma.content [
                Bulma.table [
                    table.isBordered
                    prop.children [
                        Html.thead [
                            Html.tableRow [
                                Html.td [ Html.strong "Property" ]
                                Html.td [ Html.strong "Alignment" ]
                            ]
                        ]
                        Html.tbody [
                            rowAlignment "Bulma.text.hasTextCentered" "Makes the text " "centered"
                            rowAlignment "Bulma.text.hasTextJustified" "Makes the text " "justified"
                            rowAlignment "Bulma.text.hasTextLeft" "Makes the text aligned to the " "left"
                            rowAlignment "Bulma.text.hasTextRight" "Makes the text aligned to the " "right"
                        ]
                    ]
                ]
            ]

            Bulma.title "Responsive Alignment"
            Html.p [
                Html.text "You can "
                Html.strong "align text "
                Html.text "differently for each "
                Html.strong "viewport width"
                Html.text ". Simply append the "
                Html.strong "viewport width "
                Html.text "to the alignment modifier."
            ]
            Html.p [
                Html.text "For example, here are the modifiers for "
                Html.code "text.hasTextLeft"
                Html.text ":"
            ]
            Bulma.content [
                responsiveTable [
                    rowResponsive "Bulma.text.hasTextLeftMobile" responsiveAlignment (true, false, false, false, false)
                    rowResponsive "Bulma.text.hasTextLeftTouch" responsiveAlignment (true, true, false, false, false)
                    rowResponsive "Bulma.text.hasTextLeftTabletOnly" responsiveAlignment (false, true, false, false, false)
                    rowResponsive "Bulma.text.hasTextLeftTablet" responsiveAlignment (false, true, true, true, true)
                    rowResponsive "Bulma.text.hasTextLeftDesktopOnly" responsiveAlignment (false, false, true, false, false)
                    rowResponsive "Bulma.text.hasTextLeftDesktop" responsiveAlignment (false, false, true, true, true)
                    rowResponsive "Bulma.text.hasTextLeftWidescreenOnly" responsiveAlignment (false, false, false, true, false)
                    rowResponsive "Bulma.text.hasTextLeftWidescreen" responsiveAlignment (false, false, false, true, true)
                    rowResponsive "Bulma.text.hasTextLeftFullHd" responsiveAlignment (false, false, false, false, true)
                ]
            ]
            Html.p [
                Html.text "You can use the same logic for each of the "
                Html.strong "4 alignments"
                Html.text "."
            ]

            Bulma.title "Text Transformation"
            Html.p [
                Html.text "You can transform the text with the use of one of "
                Html.strong "4 text transformation helpers"
                Html.text ":"
            ]
            Bulma.content [
                Bulma.table [
                    table.isBordered
                    prop.children [
                        Html.thead [
                            Html.tableRow [
                                Html.td [ Html.strong "Property" ]
                                Html.td [ Html.strong "Transformation" ]
                            ]
                        ]
                        Html.tbody [
                            Html.tableRow [
                                Html.td [ Html.code "Bulma.text.isCapitalized" ]
                                Html.td [
                                    Html.text "Transforms "
                                    Html.strong "the first character "
                                    Html.text "of each word to "
                                    Html.strong "Uppercase"
                                ]
                            ]
                            Html.tableRow [
                                Html.td [ Html.code "Bulma.text.isLowercase" ]
                                Html.td [
                                    Html.text "Transforms "
                                    Html.strong "all characters "
                                    Html.text "to "
                                    Html.strong "lowercase"
                                ]
                            ]
                            Html.tableRow [
                                Html.td [ Html.code "Bulma.text.isUppercase" ]
                                Html.td [
                                    Html.text "Transforms "
                                    Html.strong "all characters "
                                    Html.text "to "
                                    Html.strong "UPPERCASE"
                                ]
                            ]
                            Html.tableRow [
                                Html.td [ Html.code "Bulma.text.isItalic" ]
                                Html.td [
                                    Html.text "Transforms "
                                    Html.strong "all characters "
                                    Html.text "to "
                                    Html.strong [
                                        text.isItalic
                                        prop.text "italic"
                                    ]
                                ]
                            ]
                            Html.tableRow [
                                Html.td [ Html.code "Bulma.text.isUnderlined" ]
                                Html.td [
                                    Html.strong [
                                        text.isUnderlined
                                        prop.text "Underlines"
                                    ]
                                    Html.text " the text"
                                ]
                            ]
                        ]
                    ]
                ]
            ]

            Bulma.title "Text Weight"
            Html.p [
                Html.text "You can transform the text weight with the use of one of "
                Html.strong "6 text weight helpers"
                Html.text ":"
            ]
            Bulma.content [
                Bulma.table [
                    table.isBordered
                    prop.children [
                        Html.thead [
                            Html.tableRow [
                                Html.td [ Html.strong "Property" ]
                                Html.td [ Html.strong "Weight" ]
                            ]
                        ]
                        Html.tbody [
                            rowTextWeight text.hasTextWeightLight "Bulma.text.hasTextWeightLight" "light"
                            rowTextWeight text.hasTextWeightNormal "Bulma.text.hasTextWeightNormal" "normal"
                            rowTextWeight text.hasTextWeightMedium "Bulma.text.hasTextWeightMedium" "medium"
                            rowTextWeight text.hasTextWeightSemibold "Bulma.text.hasTextWeightSemibold" "semibold"
                            rowTextWeight text.hasTextWeightBold "Bulma.text.hasTextWeightBold" "bold"
                            rowTextWeight text.hasTextWeightExtraBold "Bulma.text.hasTextWeightExtrabold" "extrabold"
                        ]
                    ]
                ]
            ]

            Bulma.title "Font Family"
            Html.p [
                Html.text "You can change the font family with the use of one of "
                Html.strong "5 font family helpers"
                Html.text ":"
            ]
            Bulma.content [
                Bulma.table [
                    table.isBordered
                    prop.children [
                        Html.thead [
                            Html.tableRow [
                                Html.td [ Html.strong "Property" ]
                                Html.td [ Html.strong "Family" ]
                            ]
                        ]
                        Html.tbody [
                            rowFontFamily "Bulma.text.isFamilySansSerif" "$family-sans-serif"
                            rowFontFamily "Bulma.text.isFamilyMonospace" "$family-monospace"
                            rowFontFamily "Bulma.text.isFamilyPrimary" "$family-primary"
                            rowFontFamily "Bulma.text.isFamilyCode" "$family-secondary"
                            rowFontFamily "Bulma.text.isFamilyCode" "$family-code"
                        ]
                    ]
                ]
            ]
        ]
    ]

let helpersTypography = HelpersTypographyComponent()

[<ReactComponent>]
let HelpersVisibilityComponent () =
    let responsiveTable (rows: seq<Fable.React.ReactElement>) =
        Bulma.table [
            table.isBordered
            prop.children [
                Html.thead [
                    Html.tableRow [
                        Html.th "Property"
                        Html.th [
                            Html.strong "Mobile Up to "
                            Html.code "768px"
                        ]
                        Html.th [
                            Html.strong "Tablet Between "
                            Html.code "769px"
                            Html.strong " and "
                            Html.code "1023px"
                        ]
                        Html.th [
                            Html.strong "Desktop Between "
                            Html.code "1024px"
                            Html.strong " and "
                            Html.code "1215px"
                        ]
                        Html.th [
                            Html.strong "Widescreen Between "
                            Html.code "1216px"
                            Html.strong " and "
                            Html.code "1407px"
                        ]
                        Html.th [
                            Html.strong "Widescreen Between "
                            Html.code "1408px"
                            Html.strong " and above"
                        ]
                    ]
                ]
                Html.tbody rows
            ]
        ]

    let rowShow (isFlex: bool) =
        Html.td [
            if isFlex then
                color.hasBackgroundPrimaryLight
                prop.children [
                    Bulma.text.span [
                        color.hasTextPrimary
                        prop.text "Flex"
                    ]
                ]
            else
                prop.text "Unchanged"
        ]

    let rowHide (isHidden: bool) =
        Html.td [
            if isHidden then
                color.hasBackgroundDangerLight
            else
                color.hasBackgroundPrimaryLight

            prop.children [
                Bulma.text.span [
                    if isHidden then
                        color.hasTextDanger
                    else
                        color.hasTextPrimary
                    prop.text (if isHidden then "Hidden" else "Visible")
                ]
            ]
        ]

    let row (property: string) (transform: bool -> Fable.React.ReactElement) (r1, r2, r3, r4, r5) =
        Html.tableRow [
            Html.td [ Html.code property ]
            transform r1
            transform r2
            transform r3
            transform r4
            transform r5
        ]

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Responsive Helpers"
        Html.hr []

        Bulma.content [
            Bulma.title "Show"
            Html.p [
                Html.text "You can use one of the following "
                Html.code "display"
                Html.text " classes:"
            ]
            Html.ul [
                Html.li [ Html.code "Bulma.helpers.isBlock" ]
                Html.li [ Html.code "Bulma.helpers.isFlex" ]
                Html.li [ Html.code "Bulma.helpers.isInline" ]
                Html.li [ Html.code "Bulma.helpers.isInlineBlock" ]
                Html.li [ Html.code "Bulma.helpers.isInlineFlex" ]
            ]
            Html.p [
                Html.text "For example, here's how the "
                Html.code "Bulma.helpers.isFlex"
                Html.text " helper works:"
            ]
            responsiveTable [
                row "Bulma.helpers.isFlexMobile" rowShow (true, false, false, false, false)
                row "Bulma.helpers.isFlexTabletOnly" rowShow (false, true, false, false, false)
                row "Bulma.helpers.isFlexDesktopOnly" rowShow (false, false, true, false, false)
                row "Bulma.helpers.isFlexWidescreenOnly" rowShow (false, false, false, true, false)
                Html.tableRow [
                    Html.th [
                        prop.colSpan 6
                        prop.children [
                            Html.strong "Classes to display up to or from a specific breakpoint"
                        ]
                    ]
                ]
                row "Bulma.helpers.isFlexTouch" rowShow (true, true, false, false, false)
                row "Bulma.helpers.isFlexTablet" rowShow (false, true, true, true, true)
                row "Bulma.helpers.isFlexDesktop" rowShow (false, false, true, true, true)
                row "Bulma.helpers.isFlexWidescreen" rowShow (false, false, false, true, true)
                row "Bulma.helpers.isFlexFullhd" rowShow (false, false, false, false, true)
            ]
            Html.p [
                Html.text "For the other display options, just replace "
                Html.code "Bulma.helpers.isFlex"
                Html.text " with "
                Html.code "Bulma.helpers.isBlock"
                Html.text " "
                Html.code "Bulma.helpers.isInline"
                Html.text " "
                Html.code "Bulma.helpers.isInlineBlock"
                Html.text " or "
                Html.code "Bulma.helpers.isInlineFlex"
            ]

            Bulma.title "Hide"
            responsiveTable [
                row "Bulma.helpers.isHiddenMobile" rowHide (true, false, false, false, false)
                row "Bulma.helpers.isHiddenTabletOnly" rowHide (false, true, false, false, false)
                row "Bulma.helpers.isHiddenDesktopOnly" rowHide (false, false, true, false, false)
                row "Bulma.helpers.isHiddenWidescreenOnly" rowHide (false, false, false, true, false)
                Html.tableRow [
                    Html.th [
                        prop.colSpan 6
                        prop.children [
                            Html.strong "Classes to hide up to or from a specific breakpoint "
                        ]
                    ]
                ]
                row "Bulma.helpers.isHiddenTouch" rowHide (true, true, false, false, false)
                row "Bulma.helpers.isHiddenTablet" rowHide (false, true, true, true, true)
                row "Bulma.helpers.isHiddenDesktop" rowHide (false, false, true, true, true)
                row "Bulma.helpers.isHiddenWidescreen" rowHide (false, false, false, true, true)
                row "Bulma.helpers.isHiddenFullhd" rowHide (false, false, false, false, true)
            ]

            Bulma.title "Other visibility helpers"
            Bulma.table [
                table.isBordered
                prop.children [
                    Html.tbody [
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isInvisible" ]
                            Html.td [
                                Html.text "Adds visibility "
                                Html.strong "hidden"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isHidden" ]
                            Html.td [ Html.text "Hides element" ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isSrOnly" ]
                            Html.td [
                                Html.text "Hide elements "
                                Html.strong "visually"
                                Html.text " but keep the element available to be announced by a "
                                Html.strong "screen reader"
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

let helpersVisibility = HelpersVisibilityComponent()

[<ReactComponent>]
let HelpersFlexboxComponent () =
    let table (rows: seq<Fable.React.ReactElement>) =
        Bulma.table [
            table.isBordered
            prop.children [
                Html.thead [
                    Html.tableRow [
                        Html.td [ Html.strong "Property" ]
                        Html.td [ Html.strong "Property: Value" ]
                    ]
                ]
                Html.tbody rows
            ]
        ]

    let row (bulmaClass: string) (value: string) =
        Html.tableRow [
            Html.td [ Html.code bulmaClass ]
            Html.td [ Html.code value ]
        ]

    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Flexbox Helpers"
        Html.hr []

        Bulma.content [
            Html.p [
                Html.text "Combined with "
                Html.code "Bulma.helpers.isFlex"
                Html.text ", all of the Flexbox CSS properties are available as Bulma helpers:"
            ]
            Html.ul [
                Html.li [ Html.code "flex-direction" ]
                Html.li [ Html.code "flex-wrap" ]
                Html.li [ Html.code "justify-content" ]
                Html.li [ Html.code "align-content" ]
                Html.li [ Html.code "align-items" ]
                Html.li [ Html.code "align-self" ]
                Html.li [ Html.code "flex-grow" ]
                Html.li [ Html.code "flex-shrink" ]
            ]

            Bulma.title "Flex Direction"
            table [
                row "Bulma.helpers.isFlexDirectionRow" "flex-direction: row"
                row "Bulma.helpers.isFlexDirectionRowReverse" "flex-direction: row-reverse"
                row "Bulma.helpers.isFlexDirectionColumn" "flex-direction: column"
                row "Bulma.helpers.isFlexDirectionColumnReverse" "flex-direction: column-reverse"
            ]

            Bulma.title "Flex Wrap"
            table [
                row "Bulma.helpers.isFlexWrapNoWrap" "flex-wrap: nowrap"
                row "Bulma.helpers.isFlexWrapWrap" "flex-wrap: wrap"
                row "Bulma.helpers.isFlexWrapWrapReverse" "flex-wrap: wrap-reverse"
            ]

            Bulma.title "Justify Content"
            table [
                row "Bulma.helpers.isJustifyContentFlexStart" "justify-content: flex-start"
                row "Bulma.helpers.isJustifyContentFlexEnd" "justify-content: flex-end"
                row "Bulma.helpers.isJustifyContentCenter" "justify-content: center"
                row "Bulma.helpers.isJustifyContentSpaceBetween" "justify-content: space-between"
                row "Bulma.helpers.isJustifyContentSpaceAround" "justify-content: space-around"
                row "Bulma.helpers.isJustifyContentSpaceEvenly" "justify-content: space-evenly"
                row "Bulma.helpers.isJustifyContentStart" "justify-content: start"
                row "Bulma.helpers.isJustifyContentEnd" "justify-content: end"
                row "Bulma.helpers.isJustifyContentLeft" "justify-content: left"
                row "Bulma.helpers.isJustifyContentRight" "justify-content: right"
            ]

            Bulma.title "Align Content"
            table [
                row "Bulma.helpers.isAlignContentFlexStart" "align-content: flex-start"
                row "Bulma.helpers.isAlignContentFlexEnd" "align-content: flex-end"
                row "Bulma.helpers.isAlignContentCenter" "align-content: center"
                row "Bulma.helpers.isAlignContentSpaceBetween" "align-content: space-between"
                row "Bulma.helpers.isAlignContentSpaceAround" "align-content: space-around"
                row "Bulma.helpers.isAlignContentSpaceEvenly" "align-content: space-evenly"
                row "Bulma.helpers.isAlignContentStretch" "align-content: stretch"
                row "Bulma.helpers.isAlignContentStart" "align-content: start"
                row "Bulma.helpers.isAlignContentEnd" "align-content: end"
                row "Bulma.helpers.isAlignContentBaseline" "align-content: baseline"
            ]

            Bulma.title "Align Items"
            table [
                row "Bulma.helpers.isAlignItemsStretch" "align-items: stretch"
                row "Bulma.helpers.isAlignItemsFlexStart" "align-items: flex-start"
                row "Bulma.helpers.isAlignItemsFlexEnd" "align-items: flex-end"
                row "Bulma.helpers.isAlignItemsCenter" "align-items: center"
                row "Bulma.helpers.isAlignItemsBaseline" "align-items: baseline"
                row "Bulma.helpers.isAlignItemsStart" "align-items: start"
                row "Bulma.helpers.isAlignItemsEnd" "align-items: end"
                row "Bulma.helpers.isAlignItemsSelfStart" "align-items: self-start"
                row "Bulma.helpers.isAlignItemsSelfEnd" "align-items: self-end"
            ]

            Bulma.title "Align Self"
            table [
                row "Bulma.helpers.isAlignSelfAuto" "align-self: auto"
                row "Bulma.helpers.isAlignSelfFlexStart" "align-self: flex-start"
                row "Bulma.helpers.isAlignSelfFlexEnd" "align-self: flex-end"
                row "Bulma.helpers.isAlignSelfCenter" "align-self: center"
                row "Bulma.helpers.isAlignSelfBaseline" "align-self: baseline"
                row "Bulma.helpers.isAlignSelfStretch" "align-self: stretch"
            ]

            Bulma.title "Flex Grow"
            table [
                row "Bulma.helpers.isFlexGrow0" "flex-grow: 0"
                row "Bulma.helpers.isFlexGrow1" "flex-grow: 1"
                row "Bulma.helpers.isFlexGrow2" "flex-grow: 2"
                row "Bulma.helpers.isFlexGrow3" "flex-grow: 3"
                row "Bulma.helpers.isFlexGrow4" "flex-grow: 4"
                row "Bulma.helpers.isFlexGrow5" "flex-grow: 5"
            ]

            Bulma.title "Flex Shrink"
            table [
                row "Bulma.helpers.isFlexShrink0" "flex-shrink: 0"
                row "Bulma.helpers.isFlexShrink1" "flex-shrink: 1"
                row "Bulma.helpers.isFlexShrink2" "flex-shrink: 2"
                row "Bulma.helpers.isFlexShrink3" "flex-shrink: 3"
                row "Bulma.helpers.isFlexShrink4" "flex-shrink: 4"
                row "Bulma.helpers.isFlexShrink5" "flex-shrink: 5"
            ]
        ]
    ]

let helpersFlexbox = HelpersFlexboxComponent ()

[<ReactComponent>]
let HelpersOtherComponent () =
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Other Helpers"
        Html.hr []

        Bulma.content [
            Html.p [
                Html.text "Here are some other helpers shipped with Bulma:"
            ]

            Bulma.table [
                table.isBordered
                prop.children [
                    Html.tbody [
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isClearfix" ]
                            Html.td [
                                Html.text "Fixes an element's floating children"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isPulledLeft" ]
                            Html.td [
                                Html.text "Moves an element to the "
                                Html.strong "left"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isPulledRight" ]
                            Html.td [
                                Html.text "Moves an element to the "
                                Html.strong "right"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isOverlay" ]
                            Html.td [
                                Html.text "Completely "
                                Html.strong "covers"
                                Html.text " the first positioned parent"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isClipped" ]
                            Html.td [
                                Html.text "Adds overflow "
                                Html.strong "hidden"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isRadiusless" ]
                            Html.td [
                                Html.text "Removes any "
                                Html.strong "radius"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isShadowless" ]
                            Html.td [
                                Html.text "Removes any "
                                Html.strong "shadow"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isUnselectable" ]
                            Html.td [
                                Html.text "Prevents the text from being "
                                Html.strong "selectable"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isClickable" ]
                            Html.td [
                                Html.text "Applies "
                                Html.code "cursor: pointer !important"
                                Html.text " to the element"
                            ]
                        ]
                        Html.tableRow [
                            Html.td [ Html.code "Bulma.helpers.isRelative" ]
                            Html.td [
                                Html.text "Applies "
                                Html.code "position: relative"
                                Html.text " to the element"
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

let helpersOther = HelpersOtherComponent ()
