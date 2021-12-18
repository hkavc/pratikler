using System;

namespace If_ElseIf_Ternary_If
{
    class Program 
    {
        static void Main (string[] args)
        {
int time = DateTime.Now.Hour;
if (time>=6 && time <11)
Console.WriteLine("Günaydın");
else if (time <= 18)
Console.WriteLine("İyi Geceler");
else 
Console.WriteLine("İyi Geceler");
string sonuc = time<=18 ? "iyi günler": "iyi Geceler";
sonuc = time >=6 &&  time<11 ? "günyadın" : time <=18? "iyi günler" : "iyi günler";
Console.WriteLine(sonuc)

        }
    }
}