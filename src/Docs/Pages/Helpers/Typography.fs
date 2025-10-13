module Docs.Pages.Helpers.Typography

open Feliz
open Feliz.Bulma
open Docs.Helpers

let private rowSize (property: string) (fontSize: string) bulmaClass =
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

let private responsiveSize unchanged =
    Html.td [
        if unchanged then
            color.hasBackgroundDangerLight
        else
            prop.text "Unchanged"
    ]

let private responsiveAlignment leftAligned =
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

let private rowResponsive
    (property: string)
    (transform: bool -> Fable.React.ReactElement)
    (r1, r2, r3, r4, r5)
    =
    Html.tableRow [
        Html.td [ Html.code property ]
        transform r1
        transform r2
        transform r3
        transform r4
        transform r5
    ]

let private rowAlignment (property: string) (explain: string) (explainBold: string) =
    Html.tableRow [
        Html.td [ Html.code property ]
        Html.td [
            Html.text explain
            Html.strong explainBold
        ]
    ]

let private responsiveTable (rows: seq<Fable.React.ReactElement>) =
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
                        Html.strong "Tablet private Between "
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

let private rowTextWeight textProperty (bulmaClass: string) (text: string) =
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

let private rowFontFamily (bulmaClass: string) (code: string) =
    Html.tableRow [
        Html.td [ Html.code bulmaClass ]
        Html.td [
            Html.text "Sets the font family to "
            Html.code code
        ]
    ]


let view =
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
                    rowResponsive
                        "Bulma.size.isSize1Mobile"
                        responsiveSize
                        (true, false, false, false, false)
                    rowResponsive
                        "Bulma.size.isSize1Touch"
                        responsiveSize
                        (true, true, false, false, false)
                    rowResponsive
                        "Bulma.size.isSize1Tablet"
                        responsiveSize
                        (false, true, true, true, true)
                    rowResponsive
                        "Bulma.size.isSize1Desktop"
                        responsiveSize
                        (false, false, true, true, true)
                    rowResponsive
                        "Bulma.size.isSize1Widescreen"
                        responsiveSize
                        (false, false, false, true, true)
                    rowResponsive
                        "Bulma.size.isSize1FullHd"
                        responsiveSize
                        (false, false, false, false, true)
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
                            rowAlignment "text.hasTextCentered" "Makes the text " "centered"
                            rowAlignment "text.hasTextJustified" "Makes the text " "justified"
                            rowAlignment "text.hasTextLeft" "Makes the text aligned to the " "left"
                            rowAlignment
                                "text.hasTextRight"
                                "Makes the text aligned to the "
                                "right"
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
                    rowResponsive
                        "text.hasTextLeftMobile"
                        responsiveAlignment
                        (true, false, false, false, false)
                    rowResponsive
                        "text.hasTextLeftTouch"
                        responsiveAlignment
                        (true, true, false, false, false)
                    rowResponsive
                        "text.hasTextLeftTabletOnly"
                        responsiveAlignment
                        (false, true, false, false, false)
                    rowResponsive
                        "text.hasTextLeftTablet"
                        responsiveAlignment
                        (false, true, true, true, true)
                    rowResponsive
                        "text.hasTextLeftDesktopOnly"
                        responsiveAlignment
                        (false, false, true, false, false)
                    rowResponsive
                        "text.hasTextLeftDesktop"
                        responsiveAlignment
                        (false, false, true, true, true)
                    rowResponsive
                        "text.hasTextLeftWidescreenOnly"
                        responsiveAlignment
                        (false, false, false, true, false)
                    rowResponsive
                        "text.hasTextLeftWidescreen"
                        responsiveAlignment
                        (false, false, false, true, true)
                    rowResponsive
                        "text.hasTextLeftFullHd"
                        responsiveAlignment
                        (false, false, false, false, true)
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
                                Html.td [ Html.code "text.isCapitalized" ]
                                Html.td [
                                    Html.text "Transforms "
                                    Html.strong "the first character "
                                    Html.text "of each word to "
                                    Html.strong "Uppercase"
                                ]
                            ]
                            Html.tableRow [
                                Html.td [ Html.code "text.isLowercase" ]
                                Html.td [
                                    Html.text "Transforms "
                                    Html.strong "all characters "
                                    Html.text "to "
                                    Html.strong "lowercase"
                                ]
                            ]
                            Html.tableRow [
                                Html.td [ Html.code "text.isUppercase" ]
                                Html.td [
                                    Html.text "Transforms "
                                    Html.strong "all characters "
                                    Html.text "to "
                                    Html.strong "UPPERCASE"
                                ]
                            ]
                            Html.tableRow [
                                Html.td [ Html.code "text.isItalic" ]
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
                                Html.td [ Html.code "text.isUnderlined" ]
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
                            rowTextWeight text.hasTextWeightLight "text.hasTextWeightLight" "light"
                            rowTextWeight
                                text.hasTextWeightNormal
                                "text.hasTextWeightNormal"
                                "normal"
                            rowTextWeight
                                text.hasTextWeightMedium
                                "text.hasTextWeightMedium"
                                "medium"
                            rowTextWeight
                                text.hasTextWeightSemibold
                                "text.hasTextWeightSemibold"
                                "semibold"
                            rowTextWeight text.hasTextWeightBold "text.hasTextWeightBold" "bold"
                            rowTextWeight
                                text.hasTextWeightExtraBold
                                "text.hasTextWeightExtrabold"
                                "extrabold"
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
                            rowFontFamily "text.isFamilySansSerif" "$family-sans-serif"
                            rowFontFamily "text.isFamilyMonospace" "$family-monospace"
                            rowFontFamily "text.isFamilyPrimary" "$family-primary"
                            rowFontFamily "text.isFamilyCode" "$family-secondary"
                            rowFontFamily "text.isFamilyCode" "$family-code"
                        ]
                    ]
                ]
            ]
        ]
    ]
