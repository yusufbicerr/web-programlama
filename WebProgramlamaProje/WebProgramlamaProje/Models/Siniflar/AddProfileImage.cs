namespace WebProgramlamaProje.Models.Siniflar
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
