using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Models.Siniflar
{
    public class SatisHareket
    {
        [Key]
        public int Satisid { get; set; }
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }
        public int Urunid { get; set; }
        public virtual Urun Urun { get; set; }
        public int CarilerID { get; set; }
        public virtual Cariler Cariler { get; set; }
        public int Personelid { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
