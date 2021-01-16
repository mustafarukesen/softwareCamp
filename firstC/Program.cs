using System;

namespace KampEng
{
    class Program
    {
        static void Main(string[] args)
        {
            string katEt = "Kategori";
            int ogrSay = 32000;
            bool sisGirYap = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış oku butonu");
            }

            else
            {
                Console.WriteLine("Eşittir oku");
            }


            if (sisGirYap == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(katEt);
        }
    }
}
