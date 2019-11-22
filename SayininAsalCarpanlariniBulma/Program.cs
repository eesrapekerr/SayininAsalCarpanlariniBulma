using System;

namespace SayininAsalCarpanlariniBulma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int asal = 2;
            //int kontrol = 0;

            //Console.Write("1'den büyük tam sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //while (sayi > 1)
            //{
            //    if (sayi % asal == 0)
            //    {
            //        if (asal != kontrol)
            //        {
            //            kontrol = asal;
            //            Console.Write(asal + "-");
            //            sayi = sayi / asal;
            //        }
            //        else
            //        {
            //            sayi = sayi / asal;
            //        }
            //    }
            //    else
            //    {
            //        asal++;
            //    }

            //}
            //Console.ReadKey();

            int asal = 2;
            int kontrol = 0;
            int sayi = 15;

            while (sayi > 1)
            {

                if (sayi % asal == 0)
                {
                    if (asal != kontrol)
                    {
                        kontrol = asal;
                        Console.Write(asal + " - ");
                        sayi = sayi / asal;
                    }
                    else
                    {
                        sayi = sayi / asal;
                    }
                }
                else
                {
                    asal++;
                }

            }
            Console.ReadLine();
            
            
        }
    }
}

