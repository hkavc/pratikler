using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("ocak ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("şubat ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("mart ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("nisanayındasınız");
                    break;
                default:
                    Console.WriteLine("Yanlış  veri girişi");
                    break;

            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış ayındayız");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındayız");
                    break;

                    

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz ayındayız");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonabahar ayındayız");
                    break;
                default:
                    break;


            }


        }
    }
}