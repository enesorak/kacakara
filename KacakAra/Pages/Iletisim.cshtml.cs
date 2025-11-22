using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KacakAra.Data;
using KacakAra.Models;
using KacakAra.Services;

namespace KacakAra.Pages;

public class IletisimModel : PageModel
{
    private readonly ApplicationDbContext _context;
    private readonly IEmailService _emailService;
    private readonly ILogger<IletisimModel> _logger;

    public IletisimModel(
        ApplicationDbContext context,
        IEmailService emailService,
        ILogger<IletisimModel> logger)
    {
        _context = context;
        _emailService = emailService;
        _logger = logger;
    }

    [BindProperty]
    public ContactForm ContactForm { get; set; } = new();

    [TempData]
    public string? Message { get; set; }

    [TempData]
    public string? MessageType { get; set; }

    public void OnGet()
    {
        ViewData["Title"] = "İletişim";
        ViewData["MetaDescription"] = "KacakAra ile iletişime geçin. Su kaçağı tespiti, tıkanıklık açma ve tesisat hizmetleri için bize ulaşın. Tekirdağ genelinde 7/24 hizmet, hızlı dönüş.";
        ViewData["MetaKeywords"] = "iletişim, kacakara iletişim, su kaçağı randevu tekirdağ, tesisat iletişim tekirdağ, tekirdağ tesisat";   }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        try
        {
            // Form verisini kaydet
            _context.ContactForms.Add(ContactForm);
            await _context.SaveChangesAsync();

            // Email bildirimi gönder
            await _emailService.SendContactFormNotificationAsync(
                ContactForm.FullName,
                ContactForm.Phone,
                ContactForm.Message
            );

            _logger.LogInformation($"Yeni iletişim formu kaydedildi: {ContactForm.FullName}");

            Message = "Mesajınız başarıyla gönderildi! En kısa sürede size dönüş yapacağız.";
            MessageType = "success";

            return RedirectToPage();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "İletişim formu kaydedilirken hata oluştu");
            Message = "Bir hata oluştu. Lütfen tekrar deneyin veya telefon ile ulaşın.";
            MessageType = "error";
            return Page();
        }
    }
}