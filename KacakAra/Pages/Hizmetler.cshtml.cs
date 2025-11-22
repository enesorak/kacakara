using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KacakAra.Pages;

public class HizmetlerModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "Hizmetlerimiz";
        ViewData["MetaDescription"] = "KacakAra profesyonel su kaçağı tespiti, tıkanıklık açma, kamera ile kontrol ve tesisat hizmetleri. Kırmadan tespit, garantili çözüm.";
        ViewData["MetaKeywords"] = "su kaçağı tespiti, tıkanıklık açma, pimaş açma, kanal açma, kamera ile kontrol, tesisat hizmetleri";
    }
}