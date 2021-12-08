using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameThreeTries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis on ta mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit ühe korra.


            Random rnd = new Random();            
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta pakutav number:");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice == cpuNumber)
                {
                    Console.WriteLine("Arvasid õigesti, oled võitnud!");
                    break;

                }
                else
                {
                    i++;
                    Console.WriteLine($"Arvasid valest. { 3 - i} katset on jäänud.");
                }
            }
        }   
    }
}
