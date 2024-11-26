namespace OgrenciDersYonetimSistemiMVC.Models
{
    public class Ogrenci : Kisi, ILogin
    {
        public string? OgrenciNo { get; set; }

        public override void BilgiGoster()
        {
            Console.WriteLine($"Öğrenci: {Ad} {Soyad}, No: {OgrenciNo}");
        }

        public void Login()
        {
            Console.WriteLine($"{Ad} {Soyad} öğrenci olarak giriş yaptı.");
        }
    }
}