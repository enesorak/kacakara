using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KacakAra.Pages;

public class HakkimizdaModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "Hakkımızda";
        ViewData["MetaDescription"] = "Kacak ara, Tekirdağ'da 10+ yıllık deneyimi ile profesyonel su kaçağı tespiti ve tesisat hizmetleri sunmaktadır. Güvenilir, hızlı ve garantili çözüm.";
        ViewData["MetaKeywords"] = "kacak ara hakkında, su kaçağı firması, tesisat firması tekirdag, profesyonel tesisatçı";
    }
}