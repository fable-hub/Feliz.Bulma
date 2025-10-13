module Docs.Pages.Helpers.Visibility

open Feliz
open Feliz.Bulma
open Docs.Helpers

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

let private rowShow (isFlex: bool) =
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

let private rowHide (isHidden: bool) =
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
                prop.text (
                    if isHidden then
                        "Hidden"
                    else
                        "Visible"
                )
            ]
        ]
    ]

let private row
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


let view =
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
                row
                    "Bulma.helpers.isHiddenWidescreenOnly"
                    rowHide
                    (false, false, false, true, false)
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
