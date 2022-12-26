using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Models.Siniflar
{
    public class Faturalar
    {
        [Key]
        public int Faturalarid { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string FaturaSeriNo { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string FaturaSiraNo { get; set; }
        public DateTime Tarih { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string VergiDairesi { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(5)]
        public string Saat { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimEden { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimAlan { get; set; }
        public decimal ToplamTutar { get; set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}
