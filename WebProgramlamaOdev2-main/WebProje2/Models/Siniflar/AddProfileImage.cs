using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje2.Models.Siniflar
{
    public class AddProfileImage
    {
        public int PersonelID { get; set; }

        public string PersonelAd { get; set; }

        public string PersonelSoyad { get; set; }

        public IFormFile PersonelGorsel { get; set; }
        public int Departmanid { get; set; }
    }
}
