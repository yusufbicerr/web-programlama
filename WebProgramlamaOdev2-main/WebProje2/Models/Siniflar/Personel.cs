using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProje2.Models.Siniflar
{
    public class Personel
    {

        [Key]
        public int PersonelID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Personel Adı En fazla 30 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez !")]
        public string PersonelAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Personel Soyadı En fazla 30 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Soyad alanı boş geçilemez !")]
        public string PersonelSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string PersonelGorsel { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
        [Required(ErrorMessage = "Depertman alanı boş geçilemez !")]
        public int Departmanid { get; set; }

        public virtual Departman Departman { get; set; }

    }
}