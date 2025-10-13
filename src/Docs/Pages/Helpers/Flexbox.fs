module Docs.Pages.Helpers.Flexbox

open Feliz
open Feliz.Bulma
open Docs.Helpers

let private table (rows: seq<Fable.React.ReactElement>) =
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

let private row (bulmaClass: string) (value: string) =
    Html.tableRow [
        Html.td [ Html.code bulmaClass ]
        Html.td [ Html.code value ]
    ]

let view =
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
