using System;
namespace Try_Catch_Finally_Mantıksal_Hatalar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girmiş olduğunuz sayi" + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("hata" + ex.Message.ToString());

            }
            //finally
            //{
            //   Console.WriteLine("işeleminiz tamamlandı");
            //}

            try 
            {
                //int a=int.Parse(null);
               // int a=int.Parse("test");
                int a=int.Parse("-20000000000");
            }
            catch (ArgumentException ex)
            {
Console.WriteLine("boş değer girdiniz");
Console.WriteLine(ex);

            }
            catch( FormatException ex)
            {
                Console.WriteLine("veri tipine ygun değil");
Console.WriteLine(ex);

            }
     catch( OverflowException ex)
            {
                Console.WriteLine("kücük veta buyuk değer girdiniz");
Console.WriteLine(ex);

            }


        }



    }
}