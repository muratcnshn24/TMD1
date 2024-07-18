using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    class Program
    {

        static void Main(string[] args)
        {
             int n =Convert.ToInt32(Console.ReadLine());

            // tekmi çiftmi
             if (Sayi.ÇiftMi(n))  // ÇiftMi TekMi yazıp kontrol et.
             Console.WriteLine("Girilen sayi = {0} sıfır tek bir sayidir!", n);

            //MutlakDeger
            Console.WriteLine("|{0}|={1}", n, Sayi.MutlakDeger(0));

            //AsalSayi
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", Sayi.AsalMi(m) ? "Asal sayi.": "Asal sayi değil!");

            //RakamlariToplami
            Console.WriteLine("{0} sayının rakamları toplamı ={1}", n, Sayi.RakamlariToplami(n));

            //NeKadarOlanSayilarinToplami 1den 10a kadar olan tek ve çift sayıların toplamı.
            Console.WriteLine("{0}", Sayi.NeKadarOlanTekSayilarinToplami(n));
            Console.WriteLine("{0}", Sayi.NeKadarOlanTekSayilarinToplamiAlternatifÇözüm(n));
            Console.WriteLine("{0}", Sayi.NeKadarOlanTekSayilarinFormülleToplami(n));

            //Çemberin Çevresi 
   
            double r = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("2*{0:F2}*{1:F2}={2:F2}", Cember.pi, r,Cember.Cevresi(r));
            //     Console.WriteLine("Alan={0:F2}", Daire.AlanHesapla(r));
            //     Console.WriteLine("Alan={0:F2}", Daire.AlanHesapla(r,60));




        }
    }
}
