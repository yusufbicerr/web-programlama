using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Models.Siniflar
{
    public class Mesajlar
    {
        [Key]
        public int MesajlarID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Gonderici { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Alici { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Konu { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public string Icerik { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Tarih { get; set; }
    }
}
