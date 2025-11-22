using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KacakAra.Pages;

public class HakkimizdaModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "Hakkımızda";
        ViewData["MetaDescription"] = "KacakAra, Tekirdağ'da 10+ yıllık deneyimi ile profesyonel su kaçağı tespiti ve tesisat hizmetleri sunmaktadır. Güvenilir, hızlı ve garantili çözüm.";
        ViewData["MetaKeywords"] = "kacakara hakkında, su kaçağı firması tekirdağ, tesisat firması tekirdağ, profesyonel tesisatçı";   }
}