﻿using System;
namespace degiskenler
{
    class program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("");
            byte b = 5; //1 byte
            sbyte c = 5; //1 byte

            short s = 5; //2 byte
            ushort us = 5; // 2 BYTE

            Int16 i16 = 2; //2 byte
            int i = 2;     //4byte
            Int32 int32 = 2;//4 byte
            Int64 int64 = 2;//8byte

            uint ui = 2; //4byte
            long l = 4; //8 byte
            ulong ul = 4;//8byte



         // reel sayılar

            float f = 5; //4byte
            double d = 5;//8byte
            decimal de = 5; //16 byte

            char ch = '2';//2 byte
            string str ="hatice kübra avcıoğlu ";// sınırsız

            bool b1= true;
            bool b2= false;
            DateTime dt = DateTime.Now ;
            Console.WriteLine(dt);
            */
            object o1= "x";
            object o2= 'y';
            object o3= 4;
            object o4= 4.5;
            
            //string ifadeler
            string str1 = string.Empty;
            str1="hatice kübra avcıoğlu";
            string ad ="hatice kübra";
            string soyad=" avcıoğlu ";
            string tamisim = ad + " "+ soyad;

            //interger tanımlama şekilleri
            int integer1= 5;
            int integer2 =3;
            int integer3 =integer1*integer2;

            //boolean 
            bool bool1=10>2;

            //değişken dönüşümleri
            string str20 ="20";
            int int20 =20;
            string yenideger= str20 + int20.ToString();
            Console.WriteLine(yenideger);
            
            int int21= int20+ Convert.ToInt32(str20);
            Console.WriteLine(int21);
            int int22 =int20 + int.Parse(str20);

            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

             string hour= DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}