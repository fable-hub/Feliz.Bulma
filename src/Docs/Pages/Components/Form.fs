module Docs.Pages.Components.Form

open Feliz
open Feliz.Bulma
open Docs.Helpers

let view =
    Html.div [
        Bulma.title "Feliz.Bulma - Documentation"
        Bulma.subtitle "Form"
        Html.hr []
        Bulma.content [
            Bulma.title "Basic login"
            Bulma.columns [
                Bulma.column [
                    Html.form [
                        Bulma.field.div [
                            Bulma.label "Username"
                            Bulma.control.div [ Bulma.input.text [ prop.placeholder "nickname" ] ]
                        ]
                        Bulma.field.div [
                            Bulma.label "Password"
                            Bulma.control.div [ Bulma.input.password [ prop.placeholder "*****" ] ]
                        ]
                        Bulma.field.div [
                            Bulma.field.isGrouped
                            Bulma.field.isGroupedCentered
                            prop.children [
                                Bulma.control.div [
                                    Bulma.button.a [
                                        color.isLink
                                        prop.text "Submit"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """Html.form [
    Bulma.field.div [
        Bulma.label "Username"
        Bulma.control.div [
            Bulma.input.text [
                prop.placeholder "nickname"
            ]
        ]
    ]
    Bulma.field.div [
        Bulma.label "Password"
        Bulma.control.div [
            Bulma.input.password [
                prop.placeholder "*****"
            ]
        ]
    ]
    Bulma.field.div [
        Bulma.field.isGrouped
        Bulma.field.isGroupedCentered
        prop.children [
            Bulma.control.div [
                Bulma.button.button [
                    color.isLink
                    prop.text "Submit"
                ]
            ]
        ]
    ]
]"""
                ]
            ]
        ]
        Bulma.content [
            Bulma.title "Form field"
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label "Label"
                        Bulma.control.div [
                            Bulma.input.text [
                                prop.required true
                                prop.placeholder "Placeholder"
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """Bulma.field.div [
    Bulma.label "Label"
    Bulma.control.div [
        Bulma.input.text [
            prop.required true
            prop.placeholder "Placeholder"
        ]
    ]
]"""
                ]
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label "Label with help"
                        Bulma.control.div [
                            Bulma.input.text [
                                prop.required true
                                prop.placeholder "Placeholder"
                            ]
                        ]
                        Bulma.help "This is a help text"
                    ]
                ]
                Bulma.column [
                    Code.render
                        """Bulma.field.div [
    Bulma.label "Label with help"
    Bulma.control.div [
        Bulma.input.text [
            prop.required true
            prop.placeholder "Placeholder"
        ]
    ]
    Bulma.help "This is a help text"
]"""
                ]
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label "Label with left icon"
                        Bulma.control.p [
                            Bulma.control.hasIconsLeft
                            prop.children [
                                Bulma.input.text [
                                    prop.required true
                                    prop.placeholder "Placeholder with left icon"
                                ]
                                Bulma.icon [
                                    icon.isSmall
                                    icon.isLeft
                                    prop.children [ Html.i [ prop.className "fas fa-envelope" ] ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """Bulma.field.div [
    Bulma.label "Label with left icon"
    Bulma.control.p [
        Bulma.control.hasIconsLeft
        prop.children [
            Bulma.input.text [
                prop.required true
                prop.placeholder "Placeholder with left icon"
            ]
            Bulma.icon [
                icon.isSmall
                icon.isLeft
                prop.children [
                    Html.i [
                        prop.className "fas fa-envelope"
                    ]
                ]
            ]
        ]
    ]
]"""
                ]
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label "Label with right icon"
                        Bulma.control.p [
                            Bulma.control.hasIconsRight
                            prop.children [
                                Bulma.input.text [
                                    prop.required true
                                    prop.placeholder "Placeholder with right icon"
                                ]
                                Bulma.icon [
                                    icon.isSmall
                                    icon.isRight
                                    prop.children [ Html.i [ prop.className "fas fa-check" ] ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """Bulma.field.div [
    Bulma.label "Label with right icon"
    Bulma.control.p [
        Bulma.control.hasIconsRight
        prop.children [
            Bulma.input.text [
                prop.required true
                prop.placeholder "Placeholder with right icon"
            ]
            Bulma.icon [
                icon.isSmall
                icon.isRight
                prop.children [
                    Html.i [
                        prop.className "fas fa-check"
                    ]
                ]
            ]
        ]
    ]
]"""
                ]
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label "Dropdown"
                        Bulma.control.p [
                            Bulma.control.hasIconsLeft
                            prop.children [
                                Bulma.select [
                                    Html.option "Country"
                                    Html.option "Select dropdown"
                                    Html.option "With options"
                                ]
                                Bulma.icon [
                                    icon.isSmall
                                    icon.isLeft
                                    prop.children [ Html.i [ prop.className "fas fa-globe" ] ]
                                ]
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """Bulma.field.div [
    Bulma.label "Dropdown"
    Bulma.control.p [
        Bulma.control.hasIconsLeft
        prop.children [
            Bulma.select [
                Html.option "Country"
                Html.option "Select dropdown"
                Html.option "With options"
            ]
            Bulma.icon [
                icon.isSmall
                icon.isLeft
                prop.children [
                    Html.i [
                        prop.className "fas fa-globe"
                    ]
                ]
            ]
        ]
    ]
]"""
                ]
            ]
            Bulma.columns [
                Bulma.column [
                    Bulma.field.div [
                        Bulma.label [
                            Bulma.input.checkbox [ prop.value "remember" ]
                            Bulma.text.span "Remember me" // ToDo - need a element like <>Remember me</>
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """Bulma.field.div [
    Bulma.label [
        Bulma.input.checkbox [ prop.value "remember" ]
        Bulma.text.span "Remember me" // ToDo - need a element like <>Remember me</>
    ]
]"""
                ]
            ]

            Bulma.columns [
                Bulma.column [
                    Bulma.control.div [
                        Bulma.input.labels.radio [
                            prop.children [
                                Bulma.input.radio [
                                    prop.name "options"
                                    prop.value "1"
                                ]
                                Bulma.text.span "Option 1" // ToDo - need a element like <>Remember me</>
                            ]
                        ]
                        Bulma.input.labels.radio [
                            prop.children [
                                Bulma.input.radio [
                                    prop.name "options"
                                    prop.value "2"
                                ]
                                Bulma.text.span "Option 2" // ToDo - need a element like <>Remember me</>
                            ]
                        ]
                    ]
                ]
                Bulma.column [
                    Code.render
                        """Bulma.input.labels.radio [
        prop.children [
            Bulma.input.radio [
                prop.name "options"
                prop.value "1"
            ]
            Bulma.text.span "Option 1" // ToDo - need a element like <>Remember me</>
        ]
    ]
    Bulma.input.labels.radio [
        prop.children [
            Bulma.input.radio [
                prop.name "options"
                prop.value "2"
            ]
            Bulma.text.span "Option 2" // ToDo - need a element like <>Remember me</>
        ]
    ]
]"""
                ]
            ]
        ]
    ]
