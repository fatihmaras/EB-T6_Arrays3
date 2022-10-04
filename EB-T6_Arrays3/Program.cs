using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            int TekAdetToplam = 0;
            int CiftAdetToplam = 0;

            int TekSayilarinToplami = 0;
            int CiftSayilarinToplami = 0;

            int KullaniciDeger;


            for (int i = 0; i < 10; i++)
            {

                Console.Write((i + 1) + ". sayı değerini giriniz :");
                KullaniciDeger = int.Parse(Console.ReadLine());

                sayilar[i] = KullaniciDeger;
            }
            for (int j = 0; j < 10; j++)
            {

                if (sayilar[j] % 2 == 0)
                {
                    CiftAdetToplam++;

                    CiftSayilarinToplami += sayilar[j];

                }
                else
                {
                    TekAdetToplam++;
                    TekSayilarinToplami += sayilar[j];
                }

            }
            if (CiftSayilarinToplami > TekSayilarinToplami)
            {
                Console.WriteLine("Çift Sayıların Toplamı Tek Sayıların Toplamından Büyüktür");
            }
            else
            {
                Console.WriteLine("Tek Sayıların Toplamı Çift Sayıların Toplamından Büyüktür");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Çift Sayıların Toplamı : " + CiftSayilarinToplami);
            Console.WriteLine("Çift Sayıların Adedi : " + CiftAdetToplam);

            Console.WriteLine("\n");

            Console.WriteLine("Tek Sayıların Toplamı : " + TekSayilarinToplami);
            Console.WriteLine("Tek Sayıların Adedi : " + TekAdetToplam);
            Console.ReadLine();

        }

    }
}













