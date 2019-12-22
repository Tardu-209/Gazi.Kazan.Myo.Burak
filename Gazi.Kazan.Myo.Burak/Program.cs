using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.Kazan.Myo.Burak
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rastgele = (int)rnd.Next(1, 25);
            Console.WriteLine(rastgele);
            Console.WriteLine("Sayıyı tahmin edin");
            byte puan = 0;
            byte oyun = 1;
            for (int i = 4; i > 1; i--)
            {
                Console.WriteLine(i!=0?$"{i-1}hakkınız var":"oyun bitti");
                int tahmin = int.Parse(Console.ReadLine());
                if (tahmin==rastgele)
                {
                    Console.WriteLine("Bildiniz");
                    if (i==4)
                    {
                        puan += 100;
                        Console.WriteLine("100 puan aldınız");
                    }
                    else if (i==3)
                    {
                        puan += 70;
                        Console.WriteLine("70 puan aldınız");
                    }
                    else if (i==1)
                    {
                        puan += 50;
                        Console.WriteLine("50 puan aldınız");
                    }
                    Console.WriteLine("Tekrar Oynamak istiyor musunuz? e/h");
                    string cevap = (Console.ReadLine());
                    if (cevap == "e")
                    {
                        oyun++;
                        i += 3;
                    }
                    else if (cevap == "h")
                    {
                        Console.WriteLine(puan / oyun);
                        break;
                    }
                }
             
                if (tahmin!=rastgele)
                {
                    Console.WriteLine("bilemediniz");
                    if (i==2)
                    {
                        Console.WriteLine("Tekrar Oynamak istiyor musunuz? e/h");
                        string cevap = (Console.ReadLine());
                        if (cevap == "e")
                        {
                            oyun++;
                            i += 3;
                        }
                        else if (cevap == "h")
                        {
                            Console.WriteLine(puan / oyun);
                            break;
                        } 
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
