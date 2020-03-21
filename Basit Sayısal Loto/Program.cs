using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basit_Sayısal_Loto
{
    class Program
    {
        static void Main(string[] args)
        {
            //-Dizilerin Tanımlanması
            int[] Loto = new int[6];
            int[] Tahmin = new int[6];

            //-Loto Dizisinin elemanlarını rastgele oluşturma-------------------
            Random r = new Random();
            for (int i = 0; i < Loto.Length; i++)
            {
                Loto[i] = r.Next(1, 50);
            }
            Array.Sort(Loto);//Döngü dışında Loto dizisinin elemalarını sıralama
            //------------------------------------------------------------------

            //-Tahmin Dizisinin elemanlarını oluşturma-------------------------
            for (int i = 0; i < Tahmin.Length; i++)
            {
                Console.Write((i + 1) + ". Sayı giriniz: ");
                Tahmin[i] = int.Parse(Console.ReadLine());
            }
            //------------------------------------------------------------------
            int DogruTahmin = 0;

            //-Loto Dizisini kullanıcıya gösterme ve Doğru Tahmin Sayısını Bulma
            Console.WriteLine("ÇEKİLEN SAYISAL LOTO SONUÇLARI");
            for (int i = 0; i < Loto.Length; i++)
            {
                Console.WriteLine(Loto[i]);
                for (int j = 0; j < Tahmin.Length; j++)
                {
                    if (Loto[i] == Tahmin[j])
                        DogruTahmin++;
                }
            }
            //------------------------------------------------------------------
            Console.WriteLine("DĞRU TAHMİNLERİN SAYISI: " + DogruTahmin);
        }
    }
}
