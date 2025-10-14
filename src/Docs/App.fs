module Docs.App

open Elmish
open Elmish.React
open Fable.Core.JsInterop
open Docs.Router
open Feliz
open Feliz.Router
open Feliz.Bulma

type Model =
    {
        CurrentPage: Router.Page
    }

type Msg = | UrlChanged of Router.Page

let private init () =
    let nextPage = Router.currentUrl () |> parseUrl

    {
        CurrentPage = nextPage
    },
    Cmd.none

let private update (msg: Msg) (currentModel: Model) : Model * Cmd<Msg> =
    match msg with
    | UrlChanged p ->
        { currentModel with
            CurrentPage = p
        },
        Cmd.none

let private menuPart (model: Model) =
    let item (label: string) page =
        let isActive =
            if model.CurrentPage = page then
                [
                    helpers.isActive
                    color.hasBackgroundPrimary
                ]
            else
                []

        Bulma.menuItem.a [
            yield! isActive
            yield prop.text label
            yield prop.href (getHref page)
        ]

    Bulma.menu [
        Bulma.menuLabel "General"
        Bulma.menuList [
            item "Overview" Overview
            item "Installation" Installation
            item "API description" APIDescription
        ]
        Bulma.menuLabel "Documentation"
        Bulma.menuList [
            item "Button" DocumentationButton
            item "Card" DocumentationCard
            item "Form" DocumentationForm
            item "Media Object" DocumentationMediaObject
            item "Modal" DocumentationModal
            item "Navbar" DocumentationNavbar
            item "Panel" DocumentationPanel
            item "Progress Bar" DocumentationProgressbar
            item "Tag" DocumentationTag
            item "Title" DocumentationTitle
            item "Tabs" DocumentationTabs
            item "Breadcrumb" DocumentationBreadcrumb
        ]
        Bulma.menuLabel "Helpers"
        Bulma.menuList [
            item "Color" DocumentationHelpersColor
            item "Color Palette" DocumentationHelpersColorPalette
            item "Spacing" DocumentationHelpersSpacing
            item "Typography" DocumentationHelpersTypography
            item "Visibility" DocumentationHelpersVisibility
            item "Flexbox" DocumentationHelpersFlexbox
            item "Other" DocumentationHelpersOther
        ]
    // Bulma.menuLabel "Extensions"
    // Bulma.menuList [
    //     item "QuickView" QuickView
    // ]
    ]

let contentPart model =
    match model.CurrentPage with
    | Overview -> Pages.Overview.view
    | Installation -> Pages.Installation.view
    | APIDescription -> Pages.APIDescription.view
    | DocumentationButton -> Pages.Components.Button.view
    | DocumentationCard -> Pages.Components.Card.view
    | DocumentationForm -> Pages.Components.Form.view
    | DocumentationMediaObject -> Pages.Components.MediaObject.view
    | DocumentationModal -> Pages.Components.Modal.view
    | DocumentationNavbar -> Pages.Components.Navbar.view
    | DocumentationPanel -> Pages.Components.Panel.view
    | DocumentationProgressbar -> Pages.Components.ProgressBar.view
    | DocumentationTag -> Pages.Components.Tag.view
    | DocumentationTitle -> Pages.Components.Title.view
    | DocumentationTabs -> Pages.Components.Tabs.view
    | DocumentationBreadcrumb -> Pages.Components.Breadcrumb.view
    | DocumentationHelpersColor -> Pages.Helpers.Color.view
    | DocumentationHelpersColorPalette -> Pages.Helpers.ColorPalette.view
    | DocumentationHelpersSpacing -> Pages.Helpers.Spacing.view
    | DocumentationHelpersTypography -> Pages.Helpers.Typography.view
    | DocumentationHelpersVisibility -> Pages.Helpers.Visibility.view
    | DocumentationHelpersFlexbox -> Pages.Helpers.Flexbox.view
    | DocumentationHelpersOther -> Pages.Helpers.Other.view

let view (model: Model) (dispatch: Msg -> unit) =
    let render =
        Bulma.container [
            Bulma.section [
                Bulma.columns [
                    Bulma.column [
                        column.is2
                        prop.children (menuPart model)
                    ]
                    Bulma.column (contentPart model)
                ]
            ]
        ]

    React.router [
        router.onUrlChanged (parseUrl >> UrlChanged >> dispatch)
        router.children render
    ]


#if DEBUG
open Elmish.HMR
#endif

// Program.mkProgram init update view
// |> Program.withReactBatched "elmish-app"
// |> Program.run

open Fable.Core

// let documentationFiles : JS.Promise<unit -> string> array =
//     emitJsExpr () """
// import.meta.glob("./Pages/**/*.fs", { as: "raw"})
// """

// promise {
//     let resized = ResizeArray()

//     let documentationFiles = documentationFiles |> Promise.all

//     for docFile in documentationFiles do
//         let! content = docFile()
//         resized.Add(content)

// }
// |> Promise.start

// let documentationMap : JS.Map<string, string> =
//     emitJsStatement () """
//     """

[<ImportMember("./js/get-sources.js")>]
let getSources () : JS.Promise<JS.Map<string, string>> = jsNative

promise {
    let! sources = getSources ()

    sources.keys ()
    |> Seq.iter (fun key -> printfn $"{key}")

    Program.mkProgram init update view
    |> Program.withReactBatched "elmish-app"
    |> Program.run
}
|> Promise.start
