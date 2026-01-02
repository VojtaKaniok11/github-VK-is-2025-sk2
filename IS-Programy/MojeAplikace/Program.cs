using System;

namespace KamenNuzkyPapir
{
    class Program
    {
        // Proměnné pro skóre
        static int wins = 0;
        static int losses = 0;
        static int ties = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("Vítejte ve hře Kámen, nůžky, papír!");
            Console.WriteLine("================================================");
            bool hratDal = true;

            while (hratDal)
            {
                Console.WriteLine("\nZadej svůj tah (kamen, nuzky, papir) nebo 'r' pro skóre, 'k' pro ukončení:");
                string playerMove = Console.ReadLine().ToLower().Trim();

                if (playerMove == "k")
                {
                    hratDal = false;
                    continue;
                }

                if (playerMove == "r")
                {
                    wins = 0; losses = 0; ties = 0;
                    Console.WriteLine("Skóre bylo vynulováno.");
                    continue;
                }

                // Kontrola validity vstupu
                if (playerMove != "kamen" && playerMove != "nuzky" && playerMove != "papir")
                {
                    Console.WriteLine("Neplatný vstup, zkus to znovu.");
                    continue;
                }

                PlayGame(playerMove);
            }

            Console.WriteLine("Díky za hru!");
        }

        static void PlayGame(string playerMove)
        {
            string computerMove = PickComputerMove();
            string result = "";

            // Logika porovnávání (stejná jako ve tvém JS)
            if (playerMove == "nuzky")
            {
                if (computerMove == "kamen") result = "Prohrál jsi.";
                else if (computerMove == "papir") result = "Vyhrál jsi!";
                else result = "Remíza.";
            }
            else if (playerMove == "papir")
            {
                if (computerMove == "kamen") result = "Vyhrál jsi!";
                else if (computerMove == "papir") result = "Remíza.";
                else result = "Prohrál jsi.";
            }
            else if (playerMove == "kamen")
            {
                if (computerMove == "kamen") result = "Remíza.";
                else if (computerMove == "papir") result = "Prohrál jsi.";
                else result = "Vyhrál jsi!";
            }

            // Aktualizace skóre
            if (result == "Vyhrál jsi!") wins++;
            else if (result == "Prohrál jsi.") losses++;
            else ties++;

            // Výpis výsledku
            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine($"Tvůj tah: {playerMove}. Tah počítače: {computerMove}. {result}");
            Console.WriteLine($"Skóre - Výhry: {wins}, Prohry: {losses}, Remízy: {ties}");
            Console.WriteLine("=============================================");
        }

        static string PickComputerMove()
        {
            Random random = new Random();
            double randomNumber = random.NextDouble(); // Generuje číslo od 0.0 do 1.0

            if (randomNumber < 1.0 / 3.0) return "kamen";
            if (randomNumber < 2.0 / 3.0) return "papir";
            return "nuzky";
        }
    }
}