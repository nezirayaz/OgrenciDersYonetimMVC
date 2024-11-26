using System;
using System.Collections.Generic;

namespace OgrenciDersYonetimSistemiMVC.Models
{
    public class Ders
    {
        public string? Ad { get; set; }
        public int Kredi { get; set; }
        public OgretimGorevlisi? OgretimGorevlisi { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();

        public void OgrenciKaydet(Ogrenci ogrenci)
        {
            Ogrenciler.Add(ogrenci);
            Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} dersi kaydoldu.");
        }

        public void DersBilgisiGoster()
        {
            Console.WriteLine($"Ders: {Ad}, Kredi: {Kredi}, Öğretim Görevlisi: {OgretimGorevlisi?.Ad} {OgretimGorevlisi?.Soyad}");
            Console.WriteLine("Kayıtlı Öğrenciler:");
            foreach (var ogrenci in Ogrenciler)
            {
                Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad}");
            }
        }
    }
}