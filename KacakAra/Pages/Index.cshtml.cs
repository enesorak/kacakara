using Microsoft.AspNetCore.Mvc.RazorPages;
using KacakAra.Services;
using KacakAra.Models;

namespace KacakAra.Pages;

public class IndexModel : PageModel
{
    private readonly BlogService _blogService;

    public IndexModel(BlogService blogService)
    {
        _blogService = blogService;
    }

    public List<BlogPost> RecentPosts { get; set; } = new();

    public void OnGet()
    {
        ViewData["Title"] = "Ana Sayfa";
        ViewData["MetaDescription"] = "Tekirdag'da profesyonel su kaçağı tespiti hizmeti. Kırmadan, dökmeden teknolojik cihazlarla kaçak tespiti. Tıkanıklık açma, kanal açma ve tesisat hizmetleri. 7/24 hizmet, uygun fiyat.";
        ViewData["MetaKeywords"] = "su kaçağı tespiti tekirdağ,su kaçağı yeniçiftlik,su kacağı marmara ereğlisi, su kaçağı, su kacagı,kırma dokme yok, tesisat bulma, termal kamera, akustik dinleme, kırmadan kaçak bulma, tıkanıklık açma, pimaş açma, kanal açma, su tesisatı, yer tespiti, su kaçağı";

        RecentPosts = _blogService.GetRecentPosts(3);
    }
}