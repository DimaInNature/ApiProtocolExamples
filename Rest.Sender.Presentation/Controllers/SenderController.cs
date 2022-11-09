namespace Rest.Sender.Presentation.Controllers;

[Route(template: "api/[controller]")]
[ApiController]
public class SenderController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public SenderController()
    {
        _httpClient = new HttpClient() { BaseAddress = new(uriString: "https://localhost:5003") };
    }

    [HttpPost(template: "Send")]
    [Consumes(contentType: "application/json")]
    public async Task<IActionResult> Send(
        [FromBody] string message)
    {
        var response = await _httpClient.GetAsync(
            requestUri: $"Receiver/SayMessage/{message}");

        return Ok(value: await response.Content.ReadAsStringAsync());
    }
}