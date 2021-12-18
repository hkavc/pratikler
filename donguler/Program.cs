using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string []  renkler= new string [5];
            string []  hayvan = {"kedi"," köpek","kuş","maymun"};
            int [] dizi;
            dizi = new int[5];
             
             renkler[0]= "mavi";
             dizi[3]=10;

             Console.WriteLine(hayvan[1]);
             Console.WriteLine(dizi[3]);
             Console.WriteLine(renkler[0]);  

              Console.WriteLine("lütfen eleman sayısı giriniz");
              int diziuzunlugu = int.Parse(Console.ReadLine());
              int [] sayiDizisi = new int[diziuzunlugu];
              for (int i =0; 1< diziuzunlugu; i++)
              {
                  Console.WriteLine("lütfen {0}. sayısı giriniz",i+1);
              sayiDizisi[i] = int.Parse(Console.ReadLine());
              }
              int toplam =0;
              foreach(var sayi in sayiDizisi)
              toplam+= sayi ;
              Console.WriteLine("ortalama"+toplam/diziuzunlugu);





        }
    }

}