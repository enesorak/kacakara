using MailKit.Net.Smtp;
using MimeKit;

namespace KacakAra.Services;

public class EmailService : IEmailService
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<EmailService> _logger;

    public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }

    public async Task SendContactFormNotificationAsync(string fullName, string phone, string message)
    {
        try
        {
            var emailMessage = new MimeMessage();
            
            // SMTP ayarları configuration'dan gelecek
            var fromEmail = _configuration["Email:FromAddress"] ?? "noreply@kacakara.com";
            var toEmail = _configuration["Email:ToAddress"] ?? "info@kacakara.com";
            var smtpHost = _configuration["Email:SmtpHost"] ?? "localhost";
            var smtpPort = int.Parse(_configuration["Email:SmtpPort"] ?? "587");
            var smtpUser = _configuration["Email:SmtpUser"] ?? "";
            var smtpPass = _configuration["Email:SmtpPassword"] ?? "";

            emailMessage.From.Add(new MailboxAddress("KacakAra İletişim Formu", fromEmail));
            emailMessage.To.Add(new MailboxAddress("KacakAra", toEmail));
            emailMessage.Subject = $"Yeni İletişim Formu - {fullName}";

            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = $@"
                    <html>
                    <body style='font-family: Arial, sans-serif;'>
                        <h2 style='color: #0066cc;'>Yeni İletişim Formu Mesajı</h2>
                        <div style='background-color: #f5f5f5; padding: 20px; border-radius: 5px;'>
                            <p><strong>Ad Soyad:</strong> {fullName}</p>
                            <p><strong>Telefon:</strong> {phone}</p>
                            <p><strong>Mesaj:</strong></p>
                            <p style='background-color: white; padding: 15px; border-left: 4px solid #ffd700;'>{message}</p>
                            <p style='color: #666; font-size: 12px; margin-top: 20px;'>
                                Gönderim Zamanı: {DateTime.Now:dd.MM.yyyy HH:mm}
                            </p>
                        </div>
                    </body>
                    </html>
                "
            };

            emailMessage.Body = bodyBuilder.ToMessageBody();

            // SMTP yapılandırması yapılmadıysa sadece log'la
            if (string.IsNullOrEmpty(smtpUser))
            {
                _logger.LogWarning("SMTP yapılandırması bulunamadı. Email gönderilemiyor.");
                _logger.LogInformation($"Form: {fullName} - {phone} - {message}");
                return;
            }

            using var client = new SmtpClient();
            await client.ConnectAsync(smtpHost, smtpPort, MailKit.Security.SecureSocketOptions.StartTls);
            await client.AuthenticateAsync(smtpUser, smtpPass);
            await client.SendAsync(emailMessage);
            await client.DisconnectAsync(true);

            _logger.LogInformation($"Email başarıyla gönderildi: {fullName}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Email gönderilirken hata oluştu");
            // Email gönderilemese bile form kaydedilecek
        }
    }
}