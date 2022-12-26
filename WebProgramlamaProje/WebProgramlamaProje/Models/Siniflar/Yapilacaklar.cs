using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Models.Siniflar
{
    public class Yapilacaklar
    {
        [Key]
        public int YapilacaklarID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Baslik { get; set; }

        [Column(TypeName = "bit")]
        public bool Durum { get; set; }
    }
}
