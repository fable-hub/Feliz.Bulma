module Build.Commands.Publish

open System
open System.IO
open Spectre.Console.Cli
open Build.Workspace
open Build.Commands.Docs
open EasyBuild.Tools.Femto
open EasyBuild.Tools.GhPages
open EasyBuild.Tools.DotNet
open EasyBuild.Tools.ChangelogGen
open EasyBuild.Tools.Git

let private publish (projectName: string) =
    let projectFile =
        Path.Join(Workspace.src.``.``, projectName, $"%s{projectName}.fsproj")
        |> FileInfo

    let changelogPath =
        Path.Join(Workspace.src.``.``, projectName, "CHANGELOG.md")
        |> FileInfo

    Femto.validate projectFile

    let changelogResult =
        ChangelogGen.tryRun (
            changelogPath,
            tagFilter = [ projectName ],
            config = Workspace.``commit-linter.json``,
            // Allow dirty working directory because we make a single commit for all packages
            allowDirty = true
        )

    match changelogResult with
    | ChangelogGenResult.NoVersionBump -> printfn "Nothing to deploy"
    | ChangelogGenResult.Error error -> failwithf "Error while generating changelog:\n%s" error
    | ChangelogGenResult.NewVersion newVerion ->
        printfn $"Publishing %s{projectName} version %s{newVerion}"

        let nupkgPath = DotNet.pack (projectFile = projectFile)

        DotNet.nugetPush (nupkgPath, skipDuplicate = true)

type PublishSettings() =
    inherit CommandSettings()

type PublishCommand() =
    inherit Command<PublishSettings>()
    interface ICommandLimiter<PublishSettings>

    override __.Execute(context, settings) =

        let nugetKey = Environment.GetEnvironmentVariable("NUGET_KEY")

        if isNull nugetKey then
            failwithf $"Missing NUGET_KEY environment variable"

        if Git.isDirty () then
            failwith "Working directory is dirty, please commit or stash changes before publishing"

        DocsCommand().Execute(context, DocsSettings())
        |> ignore

        [
            "Feliz.Bulma"
            "Feliz.Bulma.Badge"
            "Feliz.Bulma.Checkradio"
            "Feliz.Bulma.DateTimePicker"
            "Feliz.Bulma.Divider"
            "Feliz.Bulma.PageLoader"
            "Feliz.Bulma.Popover"
            "Feliz.Bulma.QuickView"
            "Feliz.Bulma.Slider"
            "Feliz.Bulma.Switch"
            "Feliz.Bulma.TagsInput"
            "Feliz.Bulma.Timeline"
            "Feliz.Bulma.Tooltip"
        ]
        |> List.iter publish

        Git.addAll ()
        Git.commit "chore: release"
        Git.push ()

        // Github Actions handles the gh-pages deployment
        // GhPages.run (workingDirectory = VirtualWorkspace.``docs-deploys``.``.``)

        0
