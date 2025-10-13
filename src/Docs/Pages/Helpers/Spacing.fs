module Docs.Pages.Helpers.Spacing

open Feliz
open Feliz.Bulma
open Docs.Helpers

let private row (property: string) (extended: string) (example: string) =
    Html.tableRow [
        Html.td [
            Html.code property
            if not (System.String.IsNullOrEmpty(extended)) then
                Html.text " and "
                Html.code extended
        ]
        Html.td [ Html.code example ]
    ]

let view =
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
