using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_pratik
{
    public abstract class SirketCalisanlari
    {
        //çalışanların ortak özellikleri
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        //kurucu metot
        public SirketCalisanlari(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }

        public abstract void Gorev();

    }

    public class YazilimGelistirici : SirketCalisanlari
    {
        public YazilimGelistirici(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($" {Ad} {Soyad} yazılım geliştirici olarak çalışıyorsunuz.");
        }

    }

    public class ProjeYoneticisi : SirketCalisanlari
    {
        public ProjeYoneticisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($" {Ad} {Soyad} proje yöneticisi olarak çalışıyorsunuzz.");

        }
    }
    public class SatisDanismani : SirketCalisanlari
    {
        public SatisDanismani(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} satış danışmanı olarak çalışıyorsunuz.");
        }
    }


}