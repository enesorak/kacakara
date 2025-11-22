using System.ComponentModel.DataAnnotations;

namespace KacakAra.Models;

public class ContactForm
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Ad Soyad zorunludur")]
    [StringLength(100)]
    public string FullName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Telefon numarası zorunludur")]
    [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz")]
    [StringLength(20)]
    public string Phone { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Mesaj zorunludur")]
    [StringLength(1000)]
    public string Message { get; set; } = string.Empty;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public bool IsRead { get; set; } = false;
}