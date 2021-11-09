using System;
using System.Collections.Generic;

namespace Uygulama
{
    internal class Program
    {
        public static int Karsilastir(char sayi1, int sayi2)
        {
            char sayi2asci = Convert.ToChar(sayi2);
            if (sayi2asci < sayi1)
            {
                return sayi1;
            }
            else if (sayi2asci == sayi1)
            {
                Console.WriteLine("Sayılar Eşit!");
            }
            
            return sayi2;
        }

        public static List<int> ListeKarsilastir(List<int> sayi1, List<int> sayi2)
        {
            if (sayi1.Count > sayi2.Count)
            {
                return sayi2;
            }
            else if (sayi1.Count == sayi2.Count)
            {
                Console.WriteLine("Uzunluklar eşit!");
            }

            return sayi1;
        }

        public static List<int> ListeTopla(List<int> sayi1)
        {
            for (int i = 0; i < sayi1.Count; i++)
            {
                int ciftSayiToplam = 0;

                if (i % 2 == 0)
                {
                    ciftSayiToplam += i;
                }
            }
            return sayi1;
        }

        public static List<int> ListeAsal(List<int> sayi1)
        {
            for (int i = 2; i < sayi1.Count; i++)
            {
                if (sayi1.Count % 2 == 1 && sayi1.Count % 3 != 0)
                {
                    Console.WriteLine(sayi1.Count);
                }
            }
            return sayi1;
        }

        private static void Main(string[] args)
        {
            #region Uygulamalar

            //Uygulama
            //Char ve int tipinde 2 değer alan ve değerlerden büyük olanı geriye döndüren metod.
            //2 adet liste alıp bu listelerden eleman sayısının küçük olanını geriye getiren bir metod.
            //1 Liste alıp liste içerisinde çift sayıların toplamını geriye döndüren bir metod.
            //1 Liste içerisinde ki asal sayıları ekrana yazdıran bir metod.
            //3 adet int tipte parametre alıp bu değerleri büyükten küçüğe doğru sıralayıp bir liste halinde geriye değer döndüren metod.

            List<int> sayilar = new List<int>() { 81, 22, 53, 14 };
            List<int> sayilar2 = new List<int>() { 51, 32, 3, 24, 75};

            Console.WriteLine(ListeKarsilastir(sayilar, sayilar2));
            Console.WriteLine(ListeTopla(sayilar));
            Console.WriteLine(ListeAsal(sayilar));

            #endregion Uygulamalar
        }
    }
}