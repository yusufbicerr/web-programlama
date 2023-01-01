using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProje2.Models.Siniflar
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