using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KacakAra.Services;
using KacakAra.Models;

namespace KacakAra.Pages.Blog;

public class DetailModel : PageModel
{
    private readonly BlogService _blogService;

    public DetailModel(BlogService blogService)
    {
        _blogService = blogService;
    }

    public BlogPost? Post { get; set; }
    public List<BlogPost> RelatedPosts { get; set; } = new();

    public IActionResult OnGet(string slug)
    {
        Post = _blogService.GetPostBySlug(slug);

        if (Post == null)
        {
            return NotFound();
        }

        ViewData["Title"] = Post.Title;
        ViewData["MetaDescription"] = Post.MetaDescription;
        ViewData["MetaKeywords"] = Post.MetaKeywords;

        // İlgili yazılar (aynı yazı hariç son 3)
        RelatedPosts = _blogService.GetAllPosts()
            .Where(p => p.Slug != slug)
            .Take(3)
            .ToList();

        return Page();
    }
}