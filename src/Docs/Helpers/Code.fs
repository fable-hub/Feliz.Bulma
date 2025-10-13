module Docs.Helpers.Code

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type Highlight =
    static member inline highlight(properties: IReactProperty list) =
        Interop.reactApi.createElement (importDefault "react-shiki", createObj !!properties)

let render (c: string) =
    Highlight.highlight [
        prop.custom ("language", "fsharp")
        prop.custom ("theme", "catppuccin-latte")
        prop.custom ("showLineNumbers", true)
        prop.custom ("outputFormat", "html")
        prop.text (c.Trim())
    ]
