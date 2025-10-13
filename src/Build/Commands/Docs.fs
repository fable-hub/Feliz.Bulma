module Build.Commands.Docs

open Spectre.Console.Cli
open Build.Workspace
open EasyBuild.Tools.Vite
open EasyBuild.Tools.Npm
open EasyBuild.Tools.Fable

type DocsSettings() =
    inherit CommandSettings()

    [<CommandOption("--watch")>]
    member val IsWatch = false with get, set

type DocsCommand() =
    inherit Command<DocsSettings>()
    interface ICommandLimiter<DocsSettings>

    override __.Execute(context, settings) =

        Npm.install ()

        if settings.IsWatch then
            Fable.watch (
                noCache = true,
                sourceMaps = true,
                verbose = true,
                // testMSBuildCracker = true,
                run = "npx vite",
                workingDirectory = Workspace.src.Docs.``.``
            )
            |> Async.AwaitTask
            |> Async.RunSynchronously
            |> ignore
        else
            Fable.build (
                noCache = true,
                // testMSBuildCracker = true,
                workingDirectory = Workspace.src.Docs.``.``
            )

            Vite.build (
                outDir = VirtualWorkspace.``docs-deploys``.``.``,
                workingDirectory = Workspace.src.Docs.``.``
            )

        0
