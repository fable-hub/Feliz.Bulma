module Docs.Helpers.Installation

open Feliz
open Feliz.Bulma

let multiple packageName yarnNames styles =
    Html.div [
        Bulma.content [
            Bulma.title.h4 "Using Femto (recommended)"
            Html.p [
                prop.dangerouslySetInnerHTML
                    "The easiest way is to use <a href='https://github.com/zaid-ajaj/femto'>Femto CLI</a> which will take care of all dependencies including npm libraries."
            ]
            Code.render (sprintf "femto install %s" packageName)
        ]
        Bulma.content [
            Bulma.title.h4 "Manual"
            Html.p "If you want to install this package manually, use usual NuGet package command"
            Code.render (sprintf "dotnet add package %s" packageName)
            Html.p "or using Paket"
            Code.render (sprintf "paket add %s" packageName)
            Html.p
                "Please don't forget that this library has also dependencies on frontend packages, so you need to add it to package.json file using yarn / npm command"
            yarnNames
            |> List.map (fun n -> sprintf "yarn add %s" n)
            |> String.concat "\n"
            |> Code.render
        ]
        Bulma.content [
            Bulma.title.h4 "CSS styles"
            Html.p
                "This component requires additional scss styles to be loaded. Please don't forget to add import into your style sheet:"
            Code.render (sprintf """@forward "%s";""" styles)
        ]
    ]

let simple packageName yarnName styles =
    multiple packageName [ yarnName ] styles
