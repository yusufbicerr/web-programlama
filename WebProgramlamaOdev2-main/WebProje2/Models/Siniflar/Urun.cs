using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProje2.Models.Siniflar
{
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }
        [Column(TypeName="Varchar")]
        [StringLength(30, ErrorMessage = "Ürün Adı En fazla 30 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Ürün adı alanı boş geçilemez !")]
        public string UrunAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Marka Adı En fazla 30 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Marka alanı boş geçilemez !")]
        public string Marka { get; set; }
        [Required(ErrorMessage = "Stok alanı boş geçilemez !")]
        public short Stok { get; set; }
        [Required(ErrorMessage = "Alış Fiyat alanı boş geçilemez !")]
        public decimal AlisFiyat { get; set; }
        [Required(ErrorMessage = "Satış Fiyatı alanı boş geçilemez !")]
        public decimal SatisFiyat { get; set; }
        public bool Durum { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string UrunGorsel { get; set; }
        public int Kategoriid { get; set; }
        public virtual Kategori? Kategori { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }



    }
}