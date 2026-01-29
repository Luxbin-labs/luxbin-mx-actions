namespace LuxbinMxActions.Actions;

using Loupedeck;
using LuxbinMxActions.Services;

/// <summary>
/// Dial: Controls AI temperature (creativity) from 0.0 to 1.0.
/// This is the core "magic moment" of the demo -- turning the physical dial
/// visibly changes how the AI behaves.
/// </summary>
public class TemperatureAdjustment : PluginDynamicAdjustment
{
    private Double _temperature = 0.5;

    public TemperatureAdjustment()
        : base(
            displayName: "AI Temperature",
            description: "Adjust AI creativity level with the dial",
            groupName: "Luxbin AI",
            hasReset: true)
    {
    }

    protected override void ApplyAdjustment(String actionParameter, Int32 diff)
    {
        // Each tick adjusts by 0.05
        _temperature = Math.Clamp(_temperature + (diff * 0.05), 0.0, 1.0);
        _temperature = Math.Round(_temperature, 2);
        PluginState.Temperature = _temperature;

        OverlayNotifier.Send("Temperature", _temperature.ToString("F2"));
        AdjustmentValueChanged();
    }

    protected override void RunCommand(String actionParameter)
    {
        // Press the dial to reset to 0.5
        _temperature = 0.5;
        PluginState.Temperature = _temperature;
        OverlayNotifier.Send("Temperature", "0.50 (reset)");
        AdjustmentValueChanged();
    }

    protected override String GetAdjustmentValue(String actionParameter)
    {
        return _temperature.ToString("F2");
    }
}
