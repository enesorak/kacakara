namespace KacakAra.Services;

public interface IEmailService
{
    Task SendContactFormNotificationAsync(string fullName, string phone, string message);
}