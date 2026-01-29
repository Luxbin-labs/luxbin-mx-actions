namespace LuxbinMxActions;

using Loupedeck;

/// <summary>
/// Main plugin entry point for Luxbin MX Actions.
/// Registers all commands and adjustments with the Loupedeck/Options+ runtime.
/// </summary>
public class LuxbinPlugin : Plugin
{
    public override Boolean HasNoApplication => true;
    public override Boolean UsesApplicationApiOnly => true;

    public override void Load()
    {
        this.Info.Icon16x16 = EmbeddedResources.ReadImage("LuxbinMxActions.assets.icon-16.png");
        this.Info.Icon32x32 = EmbeddedResources.ReadImage("LuxbinMxActions.assets.icon-32.png");
        this.Info.Icon48x48 = EmbeddedResources.ReadImage("LuxbinMxActions.assets.icon-48.png");
        this.Info.Icon256x256 = EmbeddedResources.ReadImage("LuxbinMxActions.assets.icon-256.png");
    }

    public override void Unload()
    {
    }
}
