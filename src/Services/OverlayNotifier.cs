namespace LuxbinMxActions.Services;

/// <summary>
/// Sends action results to the visual overlay via a local HTTP endpoint.
/// The overlay (overlay/index.html) listens on localhost:9210 for updates.
/// </summary>
public static class OverlayNotifier
{
    private static readonly HttpClient Client = new();
    private const String OverlayUrl = "http://localhost:9210/update";

    public static void Send(String action, String value)
    {
        try
        {
            var payload = new StringContent(
                $"{{\"action\":\"{action}\",\"value\":\"{value}\",\"timestamp\":\"{DateTime.UtcNow:O}\"}}",
                System.Text.Encoding.UTF8,
                "application/json");

            // Fire and forget -- overlay updates are non-critical
            _ = Client.PostAsync(OverlayUrl, payload);
        }
        catch
        {
            // Overlay not running -- silently ignore
        }
    }
}
