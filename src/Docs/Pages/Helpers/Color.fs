module Docs.Pages.Helpers.Color

open Feliz
open Feliz.Bulma
open Docs.Helpers

let view =
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
                    row color.hasBackgroundBlack color.hasTextWhite "color.hasTextWhite"
                    row color.hasBackgroundWhite color.hasTextBlack "color.hasTextBlack"
                    row color.hasBackgroundGrey color.hasTextLight "color.hasTextLight"
                    row color.hasBackgroundWhite color.hasTextDark "color.hasTextDark"
                    row color.hasBackgroundWhite color.hasTextPrimary "color.hasTextPrimary"
                    row color.hasBackgroundWhite color.hasTextLink "color.hasTextLink"
                    row color.hasBackgroundWhite color.hasTextInfo "color.hasTextInfo"
                    row color.hasBackgroundWhite color.hasTextSuccess "color.hasTextSuccess"
                    row color.hasBackgroundWhite color.hasTextWarning "color.hasTextWarning"
                    row color.hasBackgroundWhite color.hasTextDanger "color.hasTextDanger"
                ]

                table [
                    row color.hasBackgroundWhite color.hasTextBlackBis "color.hasTextBlackBis"
                    row color.hasBackgroundWhite color.hasTextBlackTer "color.hasTextBlackTer"
                    row color.hasBackgroundWhite color.hasTextGreyDarker "color.hasTextGreyDarker"
                    row color.hasBackgroundWhite color.hasTextGreyDark "color.hasTextGreyDark"
                    row color.hasBackgroundWhite color.hasTextGrey "color.hasTextGrey"
                    row color.hasBackgroundWhite color.hasTextGreyLight "color.hasTextGreyLight"
                    row color.hasBackgroundWhite color.hasTextGreyLighter "color.hasTextGreyLighter"
                    row color.hasBackgroundBlack color.hasTextWhiteTer "color.hasTextWhiteTer"
                    row color.hasBackgroundBlack color.hasTextWhiteBis "color.hasTextWhiteBis"
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
                    row
                        color.hasBackgroundDark
                        color.hasTextPrimaryLight
                        "color.hasTextPrimaryLight"
                    row color.hasBackgroundDark color.hasTextLinkLight "color.hasTextLinkLight"
                    row color.hasBackgroundDark color.hasTextInfoLight "color.hasTextInfoLight"
                    row
                        color.hasBackgroundDark
                        color.hasTextSuccessLight
                        "color.hasTextSuccessLight"
                    row
                        color.hasBackgroundDark
                        color.hasTextWarningLight
                        "color.hasTextWarningLight"
                    row color.hasBackgroundDark color.hasTextDangerLight "color.hasTextDangerLight"
                    row color.hasBackgroundWhite color.hasTextPrimaryDark "color.hasTextPrimaryDark"
                    row color.hasBackgroundWhite color.hasTextLinkDark "color.hasTextLinkDark"
                    row color.hasBackgroundWhite color.hasTextInfoDark "color.hasTextInfoDark"
                    row color.hasBackgroundWhite color.hasTextSuccessDark "color.hasTextSuccessDark"
                    row color.hasBackgroundWhite color.hasTextWarningDark "color.hasTextWarningDark"
                    row color.hasBackgroundWhite color.hasTextDangerDark "color.hasTextDangerDark"
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
                    row color.hasBackgroundWhite color.hasTextCurrent "color.hasTextCurrent"
                    row color.hasBackgroundWhite color.hasTextInherit "color.hasTextInherit"
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
                    row color.hasBackgroundWhite color.hasTextBlack "color.hasBackgroundWhite"
                    row color.hasBackgroundBlack color.hasTextWhite "color.hasBackgroundBlack"
                    row color.hasBackgroundLight color.hasTextBlack "color.hasBackgroundLight"
                    row color.hasBackgroundDark color.hasTextWhite "color.hasBackgroundDark"
                    row color.hasBackgroundPrimary color.hasTextBlack "color.hasBackgroundPrimary"
                    row color.hasBackgroundLink color.hasTextBlack "color.hasBackgroundLink"
                    row color.hasBackgroundInfo color.hasTextBlack "color.hasBackgroundInfo"
                    row color.hasBackgroundSuccess color.hasTextBlack "color.hasBackgroundSuccess"
                    row color.hasBackgroundWarning color.hasTextBlack "color.hasBackgroundWarning"
                    row color.hasBackgroundDanger color.hasTextBlack "color.hasBackgroundDanger"
                ]

                table [
                    row color.hasBackgroundBlackBis color.hasTextWhite "color.hasBackgroundBlackBis"
                    row color.hasBackgroundBlackTer color.hasTextWhite "color.hasBackgroundBlackTer"
                    row
                        color.hasBackgroundGreyDarker
                        color.hasTextWhite
                        "color.hasBackgroundGreyDarker"
                    row color.hasBackgroundGreyDark color.hasTextWhite "color.hasBackgroundGreyDark"
                    row color.hasBackgroundGrey color.hasTextWhite "color.hasBackgroundGreyDark"
                    row
                        color.hasBackgroundGreyLight
                        color.hasTextWhite
                        "color.hasBackgroundGreyLight"
                    row
                        color.hasBackgroundGreyLighter
                        color.hasTextWhite
                        "color.hasBackgroundGreyLighter"
                    row color.hasBackgroundWhiteTer color.hasTextBlack "color.hasBackgroundWhiteTer"
                    row color.hasBackgroundWhiteBis color.hasTextBlack "color.hasBackgroundWhiteBis"
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
                        color.hasBackgroundPrimaryLight
                        color.hasTextBlack
                        "color.hasBackgroundPrimaryLight"
                    row
                        color.hasBackgroundLinkLight
                        color.hasTextBlack
                        "color.hasBackgroundLinkLight"
                    row
                        color.hasBackgroundInfoLight
                        color.hasTextBlack
                        "color.hasBackgroundInfoLight"
                    row
                        color.hasBackgroundSuccessLight
                        color.hasTextBlack
                        "color.hasBackgroundSuccessLight"
                    row
                        color.hasBackgroundWarningLight
                        color.hasTextBlack
                        "color.hasBackgroundWarningLight"
                    row
                        color.hasBackgroundDangerLight
                        color.hasTextBlack
                        "color.hasBackgroundDangerLight"
                    row
                        color.hasBackgroundPrimaryDark
                        color.hasTextBlack
                        "color.hasBackgroundPrimaryDark"
                    row color.hasBackgroundLinkDark color.hasTextBlack "color.hasBackgroundLinkDark"
                    row color.hasBackgroundInfoDark color.hasTextBlack "color.hasBackgroundInfoDark"
                    row
                        color.hasBackgroundSuccessDark
                        color.hasTextBlack
                        "color.hasBackgroundSuccessDark"
                    row
                        color.hasBackgroundWarningDark
                        color.hasTextBlack
                        "color.hasBackgroundWarningDark"
                    row
                        color.hasBackgroundDangerDark
                        color.hasTextBlack
                        "color.hasBackgroundDangerDark"
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
                        row
                            color.hasBackgroundCurrent
                            color.hasTextBlack
                            "color.hasBackgroundCurrent"
                        row
                            color.hasBackgroundInherit
                            color.hasTextWhite
                            "color.hasBackgroundInherit"
                    ]
                ]
            ]
        ]
    ]
