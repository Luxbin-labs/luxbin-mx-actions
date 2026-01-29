namespace LuxbinMxActions.Actions;

using Loupedeck;
using LuxbinMxActions.Services;

/// <summary>
/// Key 2: Generates an AI summary of the current file or selection.
/// </summary>
public class SummarizeCommand : PluginDynamicCommand
{
    private readonly AiService _ai = new();

    public SummarizeCommand()
        : base(
            displayName: "Summarize",
            description: "AI-powered content summarization",
            groupName: "Luxbin AI")
    {
    }

    protected override void RunCommand(String actionParameter)
    {
        var result = _ai.Summarize("// file content placeholder");
        OverlayNotifier.Send("Summarize", result);
    }
}
