using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Models.Siniflar
{
    public class Departman
    {
        [Key]
        public int Departmanid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Deoartman Adı En fazla 30 karakter uzunluğunda olabilir.")]
        [Required(ErrorMessage = "Departman adı boş geçilemez !")]
        public string DepartmanAd { get; set; }
        public bool Durum { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}
