using System;
namespace continue1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir sayı giriniz");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++) 
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);

                }

            }

            // 1 ile 100 arasındaki tek ve cıft sayıların ken içinde toplamları ekrana yazdır
            int tekToplam =0;
            int CiftToplam =0;
            for(int i=1; i<=1000;i++)
            {
                if(i%2==1)
                tekToplam+=i;
                else
                CiftToplam+=1;
            }
            Console.WriteLine("tek toplam"+ tekToplam);
            Console.WriteLine("çift tolam "+CiftToplam);
            //break continue
            for(int i= 1; i<10;i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
            }

        }
    }
}
