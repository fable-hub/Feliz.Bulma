module Docs.Router

open Feliz.Router

type Page =
    | Overview
    | Installation
    | APIDescription
    | DocumentationButton
    | DocumentationCard
    | DocumentationForm
    | DocumentationMediaObject
    | DocumentationModal
    | DocumentationNavbar
    | DocumentationPanel
    | DocumentationProgressbar
    | DocumentationTag
    | DocumentationTitle
    | DocumentationTabs
    | DocumentationBreadcrumb
    | DocumentationHelpersColor
    | DocumentationHelpersColorPalette
    | DocumentationHelpersSpacing
    | DocumentationHelpersTypography
    | DocumentationHelpersVisibility
    | DocumentationHelpersFlexbox
    | DocumentationHelpersOther

let defaultPage = Overview

let parseUrl =
    function
    | [ "" ] -> Overview
    | [ "installation" ] -> Installation
    | [ "api-description" ] -> APIDescription
    | [ "documentation"; "button" ] -> DocumentationButton
    | [ "documentation"; "card" ] -> DocumentationCard
    | [ "documentation"; "form" ] -> DocumentationForm
    | [ "documentation"; "media-object" ] -> DocumentationMediaObject
    | [ "documentation"; "modal" ] -> DocumentationModal
    | [ "documentation"; "navbar" ] -> DocumentationNavbar
    | [ "documentation"; "panel" ] -> DocumentationPanel
    | [ "documentation"; "progressbar" ] -> DocumentationProgressbar
    | [ "documentation"; "tag" ] -> DocumentationTag
    | [ "documentation"; "title" ] -> DocumentationTitle
    | [ "documentation"; "tabs" ] -> DocumentationTabs
    | [ "documentation"; "breadcrumb" ] -> DocumentationBreadcrumb
    | [ "documentation"; "helpers"; "color-helpers" ] -> DocumentationHelpersColor
    | [ "documentation"; "helpers"; "palette-helpers" ] -> DocumentationHelpersColorPalette
    | [ "documentation"; "helpers"; "spacing-helpers" ] -> DocumentationHelpersSpacing
    | [ "documentation"; "helpers"; "typography-helpers" ] -> DocumentationHelpersTypography
    | [ "documentation"; "helpers"; "visibility-helpers" ] -> DocumentationHelpersVisibility
    | [ "documentation"; "helpers"; "flexbox-helpers" ] -> DocumentationHelpersFlexbox
    | [ "documentation"; "helpers"; "other-helpers" ] -> DocumentationHelpersOther
    | _ -> defaultPage

let getHref =
    function
    | Overview -> Router.format ("")
    | Installation -> Router.format ("installation")
    | APIDescription -> Router.format ("api-description")
    | DocumentationButton ->
        Router.format (
            [
                "documentation"
                "button"
            ]
        )
    | DocumentationCard ->
        Router.format (
            [
                "documentation"
                "card"
            ]
        )
    | DocumentationForm ->
        Router.format (
            [
                "documentation"
                "form"
            ]
        )
    | DocumentationModal ->
        Router.format (
            [
                "documentation"
                "modal"
            ]
        )
    | DocumentationMediaObject ->
        Router.format (
            [
                "documentation"
                "media-object"
            ]
        )
    | DocumentationNavbar ->
        Router.format (
            [
                "documentation"
                "navbar"
            ]
        )
    | DocumentationPanel ->
        Router.format (
            [
                "documentation"
                "panel"
            ]
        )
    | DocumentationProgressbar ->
        Router.format (
            [
                "documentation"
                "progressbar"
            ]
        )
    | DocumentationTag ->
        Router.format (
            [
                "documentation"
                "tag"
            ]
        )
    | DocumentationTitle ->
        Router.format (
            [
                "documentation"
                "title"
            ]
        )
    | DocumentationTabs ->
        Router.format (
            [
                "documentation"
                "tabs"
            ]
        )
    | DocumentationBreadcrumb ->
        Router.format (
            [
                "documentation"
                "breadcrumb"
            ]
        )
    | DocumentationHelpersColor ->
        Router.format (
            [
                "documentation"
                "helpers"
                "color-helpers"
            ]
        )
    | DocumentationHelpersColorPalette ->
        Router.format (
            [
                "documentation"
                "helpers"
                "palette-helpers"
            ]
        )
    | DocumentationHelpersSpacing ->
        Router.format (
            [
                "documentation"
                "helpers"
                "spacing-helpers"
            ]
        )
    | DocumentationHelpersTypography ->
        Router.format (
            [
                "documentation"
                "helpers"
                "typography-helpers"
            ]
        )
    | DocumentationHelpersVisibility ->
        Router.format (
            [
                "documentation"
                "helpers"
                "visibility-helpers"
            ]
        )
    | DocumentationHelpersFlexbox ->
        Router.format (
            [
                "documentation"
                "helpers"
                "flexbox-helpers"
            ]
        )
    | DocumentationHelpersOther ->
        Router.format (
            [
                "documentation"
                "helpers"
                "other-helpers"
            ]
        )
