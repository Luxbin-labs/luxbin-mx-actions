namespace LuxbinMxActions.Actions;

using Loupedeck;
using LuxbinMxActions.Services;

/// <summary>
/// Key 1: Triggers AI-powered code refactoring.
/// Sends the current clipboard content to the AI service for cleanup,
/// then copies the result back to the clipboard.
/// </summary>
public class RefactorCommand : PluginDynamicCommand
{
    private readonly AiService _ai = new();

    public RefactorCommand()
        : base(
            displayName: "Refactor",
            description: "AI-powered code refactoring",
            groupName: "Luxbin AI")
    {
    }

    protected override void RunCommand(String actionParameter)
    {
        var result = _ai.Refactor("// selected code placeholder");

        // In production, this would interact with the active editor.
        // For the hackathon demo, we update the overlay via a local HTTP call.
        OverlayNotifier.Send("Refactor", result);
    }
}
