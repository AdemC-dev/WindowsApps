using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayi_Tahmin
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] kulsayilari = new int[6];
            int[] pcsayilari = new int[6];
            int dogrusayisi = 0;
            int x;
            int y;

            Random rndm = new Random();
            
            for (x = 0; x < pcsayilari.Length; x++)
            { 
                pcsayilari[x] = rndm.Next(1,50);
                
            }
            
            Console.Write("1 ile 50 arasında 6 tane \n");
            for (y = 0; y < kulsayilari.Length; y++)
            { 
                Console.Write("Sayı Giriniz: ");
                kulsayilari[y] = Convert.ToInt32(Console.ReadLine());
            }

            for (y = 0; y < kulsayilari.Length; y++)
            {
                for (x = 0; x < pcsayilari.Length; x++)
                {
                    if (kulsayilari[y] == pcsayilari[x])
                    {
                        dogrusayisi = dogrusayisi + 1;
                    }
                }
            }

         // Console.WriteLine("Tahminleriniz: ");
         // for (y = 0; y < kulsayilari.Length; y++)
         // {
         //   Console.WriteLine(kulsayilari[y]);
         // }
            
            Console.WriteLine("Cevaplar: ");
            for (x = 0; x < pcsayilari.Length; x++)
            {
                Console.WriteLine(pcsayilari[x]);
            }

            Console.WriteLine("Doğru Sayınız: " + dogrusayisi);
            
            Console.ReadKey();
        }
    }
}