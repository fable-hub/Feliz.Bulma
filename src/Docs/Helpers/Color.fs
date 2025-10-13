module Docs.Helpers.Color

open Feliz
open Feliz.Bulma

type Color =
    | Primary
    | Danger
    | Info
    | Link
    | Success
    | Warning
    | Black
    | Dark
    | Light
    | White

    member this.Name =
        match this with
        | Primary -> "Primary"
        | Danger -> "Danger"
        | Info -> "Info"
        | Link -> "Link"
        | Success -> "Success"
        | Warning -> "Warning"
        | Black -> "Black"
        | Dark -> "Dark"
        | Light -> "Light"
        | White -> "White"

    member this.PropertyName =
        match this with
        | Primary -> color.isPrimary
        | Danger -> color.isDanger
        | Info -> color.isInfo
        | Link -> color.isLink
        | Success -> color.isSuccess
        | Warning -> color.isWarning
        | Black -> color.isBlack
        | Dark -> color.isDark
        | Light -> color.isLight
        | White -> color.isWhite

let chooseButton (color: Color) (onClick: Color -> unit) =
    Bulma.button.button [
        color.PropertyName
        prop.text (color.Name)
        prop.onClick (fun _ -> onClick color)
    ]
