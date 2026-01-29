namespace LuxbinMxActions.Services;

/// <summary>
/// AI integration layer. For the hackathon demo, responses are mocked
/// to avoid API key requirements during judging. Swap in real OpenAI
/// or Anthropic calls for production use.
/// </summary>
public class AiService
{
    public String Refactor(String code)
    {
        // Mocked response for demo reliability
        return "Refactored: extracted method, removed dead code, improved naming.";
    }

    public String Summarize(String content)
    {
        // Mocked response for demo reliability
        return "Summary: This module handles user authentication with JWT tokens and session management.";
    }
}
