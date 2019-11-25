using System;
using System.Collections.Generic;

namespace spel
{
    class Program
    {
        static void Main(string[] args)
        {
            // skapa objekt av klassen cSpel 
            cSpel spelare = new cSpel();

            // 
            Console.WriteLine("Vänta på texten 'Tryck' innan du trycker");

            // slumpvis fördröjning för att testa reaktionen
            spelare.SlumpvisDelay();

            // starta spelet
            spelare.StartaSpelet();

            // kontroll att spelaren inte tjuvstartat
            // läs in tecken från indata-strömmen
            if (Console.KeyAvailable) {
                Console.WriteLine("Hallå där, du försöker fuska!! Börja om.");
                ConsoleKeyInfo rensaPipen = Console.ReadKey();
                return;
            } 

            // här går startsignalen
            Console.WriteLine("TRYCK!!");
            ConsoleKeyInfo svar = Console.ReadKey();

            // stoppa spelet
            spelare.StoppaSpelet();

            // beräkna reaktionstiden
            spelare.BeraknaReaktionstid();

            // presentera resultat
            Console.WriteLine("");
            Console.WriteLine("reaktionstid i millisekunder: " + spelare.Reaktion);
        }
    }
}
