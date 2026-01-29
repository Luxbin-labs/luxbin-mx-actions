namespace LuxbinMxActions.Actions;

using Loupedeck;

/// <summary>
/// Key 3: Triggers a preview build / deploy pipeline.
/// For the hackathon demo, this is mocked with a success notification.
/// </summary>
public class PreviewBuildCommand : PluginDynamicCommand
{
    public PreviewBuildCommand()
        : base(
            displayName: "Preview Build",
            description: "Trigger a preview build pipeline",
            groupName: "Luxbin AI")
    {
    }

    protected override void RunCommand(String actionParameter)
    {
        OverlayNotifier.Send("Preview Build", "Build started... Done. Preview ready.");
    }
}
