using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje2.Models.Siniflar
{
    public class KargoDetay
    {
        [Key]
        public int KargoDetayID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(300, ErrorMessage = "Açıklama En fazla 300 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Açıklama alanı boş geçilemez !")]
        public string Aciklama { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10, ErrorMessage = "Takip Kodu En fazla 10 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Takip Kodu boş geçilemez !")]
        public string TakipKodu { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "Personel adı En fazla 20 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Personel alanı boş geçilemez !")]
        public string Personel { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(25, ErrorMessage = "Alıcı adı En fazla 25 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Alıcı alanı boş geçilemez !")]
        public string Alici { get; set; }
        [Required(ErrorMessage = "Tarih alanı boş geçilemez !")]
        public DateTime Tarih { get; set; }
    }
}
