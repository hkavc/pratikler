﻿using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {

            //ımplicit conversion (bilinçsiz dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d" + d);

            long h = d;
            Console.WriteLine("h" + h);

            float i = h;
            Console.WriteLine("i" + i);

            string e = "hatice  kübra";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g" + g);


            //explicit conversion (bilinçli dönüşüm)
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            float z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w= 100;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            // tostring methodu
            int xx= 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:"+yy);

   
          //system.convert 
          string s1= "10",s2="20";
          int sayi1 , sayi2;
          int toplam;

          sayi1= Convert.ToInt32(s1);
          sayi2= Convert.ToInt32(s2);
           toplam=sayi1 +sayi2;
           Console.WriteLine("toplam"+toplam);

           //parse
           Console.WriteLine("parse method");
           ParseMethod();
       
        }
        public static void ParseMethod()
        {
            string metin1= "10";
             string metin2= "10.25";
             int rakam1;
             double double1;
             rakam1 =Int32.Parse(metin1);
             double1= Double.Parse(metin2);
             Console.WriteLine("rakam1"+rakam1);
             Console.WriteLine("rakam1"+double1);
        }

    }
}
