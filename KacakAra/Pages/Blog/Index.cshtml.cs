using Microsoft.AspNetCore.Mvc.RazorPages;
using KacakAra.Services;
using KacakAra.Models;

namespace KacakAra.Pages.Blog;

public class IndexModel : PageModel
{
    private readonly BlogService _blogService;

    public IndexModel(BlogService blogService)
    {
        _blogService = blogService;
    }

    public List<BlogPost> BlogPosts { get; set; } = new();

    public void OnGet()
    {
        ViewData["Title"] = "Blog";
        ViewData["MetaDescription"] = "Su kaçağı tespiti, tıkanıklık açma ve tesisat hakkında faydalı bilgiler, ipuçları ve uzman tavsiyeleri.";
        ViewData["MetaKeywords"] = "su kaçağı blog, tesisat blog, tıkanıklık açma ipuçları, su kaçağı önleme";

        BlogPosts = _blogService.GetAllPosts();
    }
}