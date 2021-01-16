using System;

namespace classHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunAdi = "Lenovo Thinkpad L13\t";
            urun1.urunOzellikleri = "13.3″ FHD IPS Ekran \tIntel Core i7 10510U 1.8GHz Up To 4.9Ghz";
            urun1.urunFiyati = 9149;
            urun1.urunDeger = "TL";
            urun1.urunSiparis = "SEPETE EKLE";

            Product urun2 = new Product();
            urun2.urunAdi = "EXA Elite 7TC3\t\t";
            urun2.urunOzellikleri = "14″ FHD 60Hz \tIntel Core i7-10510U 1.8GHz 8MB";
            urun2.urunFiyati = 9179;
            urun2.urunDeger = "TL";
            urun2.urunSiparis = "SEPETE EKLE";

            Product urun3 = new Product();
            urun3.urunAdi = "Dell Vostro 3501\t";
            urun3.urunOzellikleri = "15.6″ HD(1366×768) \tIntel Core i3 1005G1 1.2GHz Up To 3.4Ghz";
            urun3.urunFiyati = 4199;
            urun3.urunDeger = "TL";
            urun3.urunSiparis = "SEPETE EKLE";

            //Console.WriteLine(urun1.urunAdi + " " + urun1.urunOzellikleri);

            Product[] urunler = new Product[] { urun1, urun2, urun3 };


            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + " : " + urunler[i].urunOzellikleri + "\n" + urunler[i].urunFiyati + urunler[i].urunDeger + "\n" + urunler[i].urunSiparis);
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " : " + urun.urunOzellikleri + "\n" + urun.urunFiyati + urun.urunDeger + "\n" + urun.urunSiparis);
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------");

            int ud = 0;
            while (ud < urunler.Length)
            {
                Console.WriteLine(urunler[ud].urunAdi + " : " + urunler[ud].urunOzellikleri + "\n" + urunler[ud].urunFiyati + urunler[ud].urunDeger + "\n" + urunler[ud].urunSiparis);
                ud++;
            }

        }
    }

    class Product
    {
        public string urunAdi { get; set; }
        public string urunOzellikleri { get; set; }
        public int urunFiyati { get; set; }
        public string urunDeger { get; set; }
        public string urunSiparis { get; set; }
    }
}
