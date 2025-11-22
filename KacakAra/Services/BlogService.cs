using KacakAra.Models;

namespace KacakAra.Services;

public class BlogService
{
    private static readonly List<BlogPost> _blogPosts = new()
    {
        new BlogPost
        {
            Slug = "su-kacagi-tespiti-nasil-yapilir",
            Title = "Su Kaçağı Tespiti Nasıl Yapılır? Kırmadan Kaçak Bulma Yöntemleri",
            Description = "Modern teknolojilerle kırmadan, dökmeden su kaçağı tespiti nasıl yapılır? Profesyonel yöntemler ve püf noktaları.",
            Content = @"
                <p>Su kaçakları ev ve işyerlerinde ciddi hasarlara yol açabilen, fark edilmediğinde büyük su faturaları oluşturan önemli bir sorundur. Modern teknoloji sayesinde artık kırmadan, dökmeden su kaçaklarını tespit etmek mümkün.</p>
                
                <h2>Su Kaçağı Belirtileri</h2>
                <ul>
                    <li>Su faturasında anormal artışlar</li>
                    <li>Duvarlarda nem ve küf oluşumu</li>
                    <li>Zeminde ıslaklık veya su birikintileri</li>
                    <li>Su sayacının sürekli dönmesi</li>
                    <li>Musluklar kapalıyken su sesi duyulması</li>
                </ul>

                <h2>Kırmadan Su Kaçağı Tespiti Yöntemleri</h2>
                
                <h3>1. Akustik Dinleme Yöntemi</h3>
                <p>Özel mikrofonlar ve sensörler kullanılarak boruların içinden gelen su sızıntısı sesleri tespit edilir. Bu yöntem en hassas ve etkili yöntemlerden biridir.</p>

                <h3>2. Termal Kamera Yöntemi</h3>
                <p>Kızılötesi termal kameralar ile sıcaklık farklılıkları görüntülenir. Su kaçağı olan bölgeler daha soğuk görünür.</p>

                <h3>3. Basınç Testi</h3>
                <p>Tesisat sistemine basınç verilerek kaçak noktalar belirlenir. Basınç düşüşü kaçak olduğunu gösterir.</p>

                <h3>4. Gaz Detektörü Yöntemi</h3>
                <p>Sisteme özel gaz verilerek, gazın çıkış noktası tespit edilir. Hassas sensörler ile kaçak nokta belirlenir.</p>

                <h2>Profesyonel Tespit Neden Önemli?</h2>
                <p>Su kaçaklarının erken tespit edilmesi:</p>
                <ul>
                    <li>Büyük hasarları önler</li>
                    <li>Su israfını engeller</li>
                    <li>Yüksek faturaları azaltır</li>
                    <li>Yapısal hasarları minimize eder</li>
                    <li>Sağlık sorunlarını (küf, nem) önler</li>
                </ul>

                <h2>Ne Zaman Uzman Çağırmalısınız?</h2>
                <p>Aşağıdaki durumlarda mutlaka profesyonel yardım almalısınız:</p>
                <ul>
                    <li>Su faturanız normalden %30'dan fazla arttıysa</li>
                    <li>Duvarlarda veya tavanda nem lekeleri görüyorsanız</li>
                    <li>Su sayacı sürekli dönüyorsa</li>
                    <li>Yerlerde açıklanamayan ıslaklık varsa</li>
                </ul>

                <p><strong>KacakAra olarak</strong>, son teknoloji cihazlarımız ve uzman ekibimizle kırmadan, dökmeden su kaçaklarınızı tespit ediyor, hızlı ve etkili çözümler sunuyoruz.</p>
            ",
            ImageUrl = "/images/blog/su-kacagi-tespit.jpg",
            PublishedDate = DateTime.Now.AddDays(-15),
            Tags = new List<string> { "su kaçağı", "kaçak tespiti", "kırmadan tespit", "su tesisatı" },
            MetaDescription = "Kırmadan su kaçağı tespiti nasıl yapılır? Modern yöntemler, püf noktaları ve profesyonel çözümler hakkında detaylı bilgi.",
            MetaKeywords = "su kaçağı tespiti, kırmadan kaçak bulma, su kaçağı tespiti nasıl yapılır, su sızıntısı tespiti"
        },
        new BlogPost
        {
            Slug = "tikaniklik-acma-yontemleri",
            Title = "Tıkanıklık Açma Yöntemleri: Etkili ve Hızlı Çözümler",
            Description = "Lavabo, tuvalet ve kanal tıkanıklıklarını açmak için profesyonel ve ev yapımı yöntemler.",
            Content = @"
                <p>Tıkanıklıklar ev ve işyerlerinde karşılaşılan en yaygın tesisat sorunlarından biridir. Doğru yöntemlerle hızlıca çözülebilen bu sorunlar, yanlış müdahalelerle daha da kötüleşebilir.</p>

                <h2>Tıkanıklık Nedenleri</h2>
                <ul>
                    <li>Saç ve sabun kalıntıları</li>
                    <li>Yağ ve gres birikimi</li>
                    <li>Yabancı maddeler (mendil, pamuk vb.)</li>
                    <li>Kireç ve tortu birikimi</li>
                    <li>Kök penetrasyonu (dış kanallarda)</li>
                </ul>

                <h2>Ev Yapımı Çözümler</h2>
                
                <h3>1. Sıcak Su + Soda Yöntemi</h3>
                <p>Hafif tıkanıklıklarda etkilidir:</p>
                <ul>
                    <li>1 litre kaynar su</li>
                    <li>1 yemek kaşığı karbonat</li>
                    <li>Karıştırıp yavaşça dökün</li>
                    <li>15 dakika bekleyin</li>
                </ul>

                <h3>2. Vakum Yöntemi (Pompa)</h3>
                <p>Mekanik tıkanıklıklar için idealdir. Pompayı giderin üzerine sıkıca bastırıp itip çekin.</p>

                <h3>3. Tel Spirali</h3>
                <p>Derin tıkanıklıklarda kullanılır. Teli yavaşça döndürerek ilerletin.</p>

                <h2>Profesyonel Çözümler</h2>

                <h3>1. Basınçlı Su ile Açma (Hidrojet)</h3>
                <p>Yüksek basınçlı su ile boru içi tamamen temizlenir. En etkili yöntemdir.</p>

                <h3>2. Spiral Makinesi</h3>
                <p>Elektrikli spiral makinalar ile uzun mesafeli tıkanıklıklar açılır.</p>

                <h3>3. Kamera ile Kontrol</h3>
                <p>Tıkanıklık nedeni görüntülenir ve en uygun çözüm belirlenir.</p>

                <h2>Tıkanıklıktan Korunma</h2>
                <ul>
                    <li>Giderlere ızgara takın</li>
                    <li>Yağları lavaboya dökmeyin</li>
                    <li>Düzenli temizlik yapın</li>
                    <li>Yabancı madde atmayın</li>
                    <li>Ayda bir sıcak su ile yıkayın</li>
                </ul>

                <h2>Uzman Yardımı Ne Zaman Gerekir?</h2>
                <p>Şu durumlarda profesyonel yardım alın:</p>
                <ul>
                    <li>Ev yöntemleri işe yaramadıysa</li>
                    <li>Tıkanıklık sık tekrar ediyorsa</li>
                    <li>Birden fazla nokta tıkalıysa</li>
                    <li>Kötü koku geliyorsa</li>
                    <li>Su geri geliyorsa</li>
                </ul>

                <p><strong>KacakAra</strong> olarak, modern cihazlarımız ve deneyimli ekibimizle her türlü tıkanıklık sorununa hızlı ve kalıcı çözümler üretiyoruz.</p>
            ",
            ImageUrl = "/images/blog/tikaniklik-acma.jpg",
            PublishedDate = DateTime.Now.AddDays(-8),
            Tags = new List<string> { "tıkanıklık açma", "lavabo tıkanıklığı", "kanal açma", "pimaş açma" },
            MetaDescription = "Tıkanıklık açma yöntemleri, ev yapımı çözümler ve profesyonel teknikler hakkında detaylı rehber.",
            MetaKeywords = "tıkanıklık açma, lavabo açma, tuvalet tıkanıklığı, kanal açma yöntemleri"
        },
        new BlogPost
        {
            Slug = "su-tesisati-bakim-onerileri",
            Title = "Su Tesisatı Bakım Önerileri: Uzun Ömürlü Tesisat İçin İpuçları",
            Description = "Su tesisatınızın uzun ömürlü olması için yapmanız gerekenler ve düzenli bakım önerileri.",
            Content = @"
                <p>Düzenli bakım yapılan su tesisatları hem uzun ömürlü olur hem de beklenmedik sorunları önler. İşte profesyonel bakım önerileri.</p>

                <h2>Düzenli Kontrol Edilmesi Gerekenler</h2>

                <h3>1. Musluklar ve Armatürler</h3>
                <ul>
                    <li>Damlayan muslukları hemen tamir edin</li>
                    <li>Havalandırıcıları (perlator) temizleyin</li>
                    <li>Conta ve keçeleri kontrol edin</li>
                    <li>Kireç temizliği yapın</li>
                </ul>

                <h3>2. Sıcak Su Sistemleri</h3>
                <ul>
                    <li>Kombileri yılda bir kez bakıma verin</li>
                    <li>Emniyet supaplarını kontrol edin</li>
                    <li>Genleşme deposunu kontrol edin</li>
                    <li>Radyatörlerin havasını alın</li>
                </ul>

                <h3>3. Kanalizasyon ve Giderler</h3>
                <ul>
                    <li>Ayda bir sıcak su ile yıkayın</li>
                    <li>Sifonları temizleyin</li>
                    <li>Yabancı madde atmayın</li>
                    <li>Koku gelmiyorsa sifonları kontrol edin</li>
                </ul>

                <h2>Mevsimsel Bakım</h2>

                <h3>Kış Hazırlığı</h3>
                <ul>
                    <li>Dış borulara yalıtım yapın</li>
                    <li>Bahçe musluklarını kapatın</li>
                    <li>Boş binalarda tesisatı boşaltın</li>
                    <li>Kombi basıncını kontrol edin</li>
                </ul>

                <h3>Yaz Bakımı</h3>
                <ul>
                    <li>Klima drenaj borularını temizleyin</li>
                    <li>Bahçe sulamasını ayarlayın</li>
                    <li>Açık hava tesisatını kontrol edin</li>
                </ul>

                <h2>Su Tasarrufu İçin Öneriler</h2>
                <ul>
                    <li>Ekonomik başlıklı duş kullanın</li>
                    <li>Çift kademe rezervuarlar tercih edin</li>
                    <li>Damlayan muslukları tamir edin</li>
                    <li>Su sayacını düzenli okuyun</li>
                    <li>Fotoselli musluk sistemleri kullanın</li>
                </ul>

                <h2>Yapılmaması Gerekenler</h2>
                <ul>
                    <li>Aşırı kimyasal kullanmayın</li>
                    <li>Ağır cisimler asılmayın</li>
                    <li>Yabancı madde atmayın</li>
                    <li>Amatörce müdahale etmeyin</li>
                    <li>Kalitesiz malzeme kullanmayın</li>
                </ul>

                <h2>Profesyonel Bakım Zamanı</h2>
                <p>Şu durumlarda mutlaka uzman çağırın:</p>
                <ul>
                    <li>Su basıncında düşüş varsa</li>
                    <li>Renkli su geliyorsa</li>
                    <li>Sık tıkanıklık yaşanıyorsa</li>
                    <li>Nem ve küf oluşuyorsa</li>
                    <li>Anormal sesler duyuluyorsa</li>
                </ul>

                <h2>Tesisatın Ömrünü Uzatan Faktörler</h2>
                <ul>
                    <li>Kaliteli malzeme kullanımı</li>
                    <li>Profesyonel montaj</li>
                    <li>Düzenli bakım</li>
                    <li>Doğru su sertliği</li>
                    <li>Uygun basınç ayarları</li>
                </ul>

                <p><strong>KacakAra</strong> olarak tesisat bakımı, tamir ve yenileme işlemlerinizde uzman ekibimizle yanınızdayız. Düzenli bakım sözleşmeleri için bizimle iletişime geçebilirsiniz.</p>
            ",
            ImageUrl = "/images/blog/tesisat-bakim.jpg",
            PublishedDate = DateTime.Now.AddDays(-3),
            Tags = new List<string> { "su tesisatı", "tesisat bakımı", "tesisat tamiri", "su tasarrufu" },
            MetaDescription = "Su tesisatı bakım önerileri, düzenli kontrol listesi ve uzun ömürlü tesisat için yapmanız gerekenler.",
            MetaKeywords = "su tesisatı bakımı, tesisat kontrolü, su tasarrufu, tesisat tamiri"
        }
    };

    public List<BlogPost> GetAllPosts()
    {
        return _blogPosts.OrderByDescending(p => p.PublishedDate).ToList();
    }

    public BlogPost? GetPostBySlug(string slug)
    {
        return _blogPosts.FirstOrDefault(p => p.Slug == slug);
    }

    public List<BlogPost> GetRecentPosts(int count = 3)
    {
        return _blogPosts.OrderByDescending(p => p.PublishedDate).Take(count).ToList();
    }
}