module Docs.View

open Feliz
open Feliz.Bulma
open Docs.Router
open Feliz.Router
open Docs.State

let menuPart (model:Model) =
    let item (t:string) p =
        let isActive =
            if model.CurrentPage = p then [ helpers.isActive; color.hasBackgroundPrimary ] else []
        Bulma.menuItem.a [
            yield! isActive
            yield prop.text t
            yield prop.href (Router.getHref p)
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
            item "Overview" DocumentationOverview
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
        Bulma.menuLabel "Extensions"
        Bulma.menuList [
            item "QuickView" QuickView
        ]
    ]

let contentPart model =
    match model.CurrentPage with
    | Overview -> Views.Bulma.overview
    | Installation -> Views.Bulma.installation
    | APIDescription -> Views.Bulma.apiDescription
    | DocumentationOverview -> Views.Documentation.overview
    | DocumentationButton -> Views.Documentation.button
    | DocumentationCard -> Views.Documentation.card
    | DocumentationForm -> Views.Documentation.form
    | DocumentationMediaObject -> Views.Documentation.mediaObject
    | DocumentationModal -> Views.Documentation.modal
    | DocumentationNavbar -> Views.Documentation.navbar
    | DocumentationPanel -> Views.Documentation.panel
    | DocumentationProgressbar -> Views.Documentation.progressbar
    | DocumentationTag -> Views.Documentation.tag
    | DocumentationTitle -> Views.Documentation.title
    | DocumentationTabs -> Views.Documentation.tabs
    | DocumentationBreadcrumb -> Views.Documentation.breadcrumb
    | DocumentationHelpersColor -> Views.Documentation.Helpers.helpersColor
    | DocumentationHelpersColorPalette -> Views.Documentation.Helpers.helpersColorPalette
    | DocumentationHelpersSpacing -> Views.Documentation.Helpers.helpersSpacing
    | DocumentationHelpersTypography -> Views.Documentation.Helpers.helpersTypography
    | DocumentationHelpersVisibility -> Views.Documentation.Helpers.helpersVisibility
    | DocumentationHelpersFlexbox -> Views.Documentation.Helpers.helpersFlexbox
    | DocumentationHelpersOther -> Views.Documentation.Helpers.helpersOther
    | QuickView -> Views.QuickView.view

let view (model : Model) (dispatch : Msg -> unit) =
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
