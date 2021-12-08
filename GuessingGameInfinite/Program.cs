using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameInfinite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis on ta mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühe korra.

            bool loopActive = true;
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while(loopActive)
            {
                Console.WriteLine("Sisesta pakutav number:");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice == cpuNumber)
                {                    
                    loopActive = false;
                    Console.WriteLine("Arvasid õigesti, oled võitnud!");
                }
                else
                {
                    Console.WriteLine("Arvasid valest, proovi uuesti!");
                }

            }
        }
    }
}
