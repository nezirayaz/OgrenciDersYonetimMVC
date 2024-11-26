namespace OgrenciDersYonetimSistemiMVC.Models
{
    public abstract class Kisi
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }

        public abstract void BilgiGoster();
    }
}