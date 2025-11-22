
namespace KacakAra.Models;

public class BlogPost
{
    public string Slug { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Author { get; set; } = "KacakAra Ekibi";
    public DateTime PublishedDate { get; set; }
    public List<string> Tags { get; set; } = new();
    public string MetaDescription { get; set; } = string.Empty;
    public string MetaKeywords { get; set; } = string.Empty;
}