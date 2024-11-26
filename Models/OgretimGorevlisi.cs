namespace OgrenciDersYonetimSistemiMVC.Models
{
    public class OgretimGorevlisi : Kisi, ILogin
    {
        public string? Unvan { get; set; }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Öğretim Görevlisi: {Unvan} {Ad} {Soyad}");
        }

        public void Login()
        {
            Console.WriteLine($"{Ad} {Soyad} öğretim görevlisi olarak giriş yaptı.");
        }
    }
}