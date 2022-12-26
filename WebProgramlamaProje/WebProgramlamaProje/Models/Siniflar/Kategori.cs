using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Kategori Adı En fazla 30 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Kategori Ad alanı boş geçilemez !")]
        public string KategoriAd { get; set; }
        public ICollection<Urun> Uruns { get; set; }
    }
}
