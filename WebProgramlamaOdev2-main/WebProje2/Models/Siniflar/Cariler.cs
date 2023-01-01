using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProje2.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int CarilerID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Cari Adı En fazla 30 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez !")]
        public string CariAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Cari Soyadı En fazla 30 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage ="Soyad alanı boş geçilemez !")]
        public string CariSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(13, ErrorMessage = "Şehir en fazla 30 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Şehir alanı boş geçilemez !")]
        public string CariSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50,ErrorMessage ="Mail adresi en fazla 50 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Mail alanı boş geçilemez !")]
        public string CariMail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "Şifre en fazla 20 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Şifre alanı boş geçilemez !")]       
        public string Sifre { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(9, ErrorMessage = "Dil en fazla 9 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Dil alanı boş geçilemez !")]
        [DefaultValue("Türkçe")]
        public string? Dil { get; set; }
        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }

    }
}