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

type ColorType =
    {
        Type: Color
        Name: string
        PropertyName: IReactProperty
    }

let info =
    function
    | Primary ->
        {
            Type = Primary
            Name = "Primary"
            PropertyName = color.isPrimary
        }
    | Danger ->
        {
            Type = Danger
            Name = "Danger"
            PropertyName = color.isDanger
        }
    | Info ->
        {
            Type = Info
            Name = "Info"
            PropertyName = color.isInfo
        }
    | Link ->
        {
            Type = Link
            Name = "Link"
            PropertyName = color.isLink
        }
    | Success ->
        {
            Type = Success
            Name = "Success"
            PropertyName = color.isSuccess
        }
    | Warning ->
        {
            Type = Warning
            Name = "Warning"
            PropertyName = color.isWarning
        }
    | Black ->
        {
            Type = Black
            Name = "Black"
            PropertyName = color.isBlack
        }
    | Dark ->
        {
            Type = Dark
            Name = "Dark"
            PropertyName = color.isDark
        }
    | Light ->
        {
            Type = Light
            Name = "Light"
            PropertyName = color.isLight
        }
    | White ->
        {
            Type = White
            Name = "White"
            PropertyName = color.isWhite
        }

let chooseButton (color: Color) (onClick: Color -> unit) =
    Bulma.button.button [
        info(color).PropertyName
        prop.text (info(color).Name)
        prop.onClick (fun _ -> onClick color)
    ]
