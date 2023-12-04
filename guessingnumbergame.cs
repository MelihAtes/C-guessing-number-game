using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 ile 100 arasında bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int defa = 0; Random rnd = new Random();
            int aklimdakiSayi = rnd.Next(0, 100);
            do
            {
                defa++;
                if (sayi > aklimdakiSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı girin");
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
                else if (sayi < aklimdakiSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı girin");
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
            } while (sayi != aklimdakiSayi);
            Console.WriteLine("Tebrikler. Sayıyı {0}. denemenizde buldunuz", defa);
            Console.ReadKey();
        }
    }
}