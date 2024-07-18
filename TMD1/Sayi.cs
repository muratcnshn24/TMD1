using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    public class Sayi
    {


        ///<summary>
        /// Parametre olarak aldığı sayının tek mi yoksa çift mi olduğunu kontrol eder.
        ///</summary>
        ///<param name="n"></param>param>
        ///<returns> Tek ise true aksi durumda false dönüş yapar </returns>

        public static bool TekMi(int n)
        {

            if (n % 2 == 1) return true ;
            return false;

        }

        ///<summary>
        /// Parametre olarak aldığı sayının  çift olup olmadığını kontrol eder.
        ///</summary>
        ///<param name="n">Girilen Sayi</param>param>
        ///<returns>n değeri Çift ise true aksi durumda false dönüş yapar </returns>
        public static bool ÇiftMi(int n)
        {
            if (n % 2 == 0) return true;
            return false;

        }

        ///<summary>
        /// Parametre olarak aldığı sayının mutlak değerini döner.
        ///</summary>
        ///<param name="n">Girilen sayıyı temsil eder</param>param>
        ///<returns>Girilen sayının mutlak değeri dönüş ifadesidir.</returns>
        public static int MutlakDeger(int n)
        {
            if (n > 0)
                return n;
            else if (n < 0)
                return -1 * n;
            else 
                return 0;


        }

        public static bool AsalMi(int m)
        {
            if( m <=1)
            {
                Console.WriteLine("En küçük asal sayı 2'dir");
                return false;
            }

            bool kontrol = true;
            for (int i = 2; i < m; i++)
         
                if (m % i == 0)
                {
                    kontrol = false;
                    break;
                }
      

            return kontrol;
        }



        ///<summary>
        /// Parametre olarak aldığı sayının rakamlarının toplamını döner.
        ///</summary>
        ///<param name="n">Sayi</param>param>
        ///<returns>Rakamların toplamıdır.</returns>
        public static int RakamlariToplami(int n)
        {
            int toplam = 0, rakam = 0;
            while (n>0)
            {
                rakam = n % 10;
                toplam += rakam;
                n = n / 10;


            }

            return toplam;
        }

        public static int NeKadarOlanSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 1; i < n; i++)
            {
                t += i;
            }
            return t;
        }

        public static int NeKadarOlanSayilarinFormülleToplami(int n)
        {
            return n * (n + 1) / 2;
        }


        public static int NeKadarOlanTekSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1) 
                t += i;
            }
            return t;

        }

        public static int NeKadarOlanTekSayilarinToplamiAlternatifÇözüm(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i += 2)
                t += i;
            return t;


        }

        public static int NeKadarOlanTekSayilarinFormülleToplami(int n)
        {
            n = n + 1;
            n = n / 2;
            return n * n;

        }

        public static int NeKadarOlanÇiftSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                    t += i;
            }
            return t;
        }

        public static int NeKadarOlanÇiftSayilarinToplamiAlternatifÇözüm(int n)
        {
            int t = 0;
            for (int i = 2; i <= n; i += 2)
                t += i;

            return t;
        }

        public static int NeKadarOlanÇiftSayilarinFormülleToplami(int n)
        {
            n = n / 2;

            return n*(n+1);
        }


    }
}
