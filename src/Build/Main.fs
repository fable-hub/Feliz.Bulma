module Build.Main

open SimpleExec
open Build.Commands.Publish
open Build.Commands.Docs
open Spectre.Console.Cli
open EasyBuild.Tools.Husky

[<EntryPoint>]
let main args =

    Husky.install ()

    let app = CommandApp()

    app.Configure(fun config ->
        config.Settings.ApplicationName <- "./build.sh"

        config
            .AddCommand<DocsCommand>("docs")
            .WithDescription("""Commands related to the Docs project""")
        |> ignore

        config
            .AddCommand<PublishCommand>("publish")
            .WithDescription("""Publish the different packages to NuGet and NPM if needed""")
        |> ignore

    )

    app.Run(args)
