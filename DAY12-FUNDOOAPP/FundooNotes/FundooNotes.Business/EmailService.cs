using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FundooNotes.Business
{
    public interface IEmailService
    {
        Task SendPasswordResetEmailAsync(string toEmail, string resetToken);
    }

    /// <summary>
    /// Consumes an external transactional email API (e.g. SendGrid) via HttpClient.
    /// The HttpClient here is injected via IHttpClientFactory (registered as a named/typed
    /// client in Program.cs) rather than "new HttpClient()", to avoid socket exhaustion.
    /// </summary>
    public class EmailService : IEmailService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly ILogger<EmailService> _logger;

        public EmailService(HttpClient httpClient, IConfiguration configuration, ILogger<EmailService> logger)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _logger = logger;
        }

        public async Task SendPasswordResetEmailAsync(string toEmail, string resetToken)
        {
            var apiKey = _configuration["EmailApi:ApiKey"];
            var resetUrlBase = _configuration["EmailApi:ResetPasswordUrl"];
            var resetLink = $"{resetUrlBase}?token={Uri.EscapeDataString(resetToken)}";

            var payload = new
            {
                personalizations = new[]
                {
                    new { to = new[] { new { email = toEmail } } }
                },
                from = new { email = _configuration["EmailApi:FromAddress"] ?? "no-reply@fundoonotes.com" },
                subject = "FundooNotes - Password Reset Request",
                content = new[]
                {
                    new
                    {
                        type = "text/plain",
                        value = $"Click the link to reset your password: {resetLink}\nThis link expires in 30 minutes."
                    }
                }
            };

            var request = new HttpRequestMessage(HttpMethod.Post, "mail/send")
            {
                Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json")
            };
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            try
            {
                var response = await _httpClient.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();
                    _logger.LogWarning("Email API call failed: {Status} {Body}", response.StatusCode, body);
                }
            }
            catch (Exception ex)
            {
                // Don't let a failed email provider take down the password-recovery flow;
                // log it and let the caller decide how to respond to the user.
                _logger.LogError(ex, "Error while calling external email API");
            }
        }
    }
}