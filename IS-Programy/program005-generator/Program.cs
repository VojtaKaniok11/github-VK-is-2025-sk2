string again = "a";
while (again == "a")
{

    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("**********Generátor náhodných čísel*********");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");
    Console.WriteLine("**********Výpis číselné řady ************");
    Console.WriteLine("**************2.10. 2025 * **************");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");

    //Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound; //Dolní mez
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound; //Horní mez
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine("zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("===============================");
    Console.WriteLine();

    //Deklarace pole (array)
    int[] myRandNumbs = new int[n];

    //Příprava pro využití třídy Random
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
    }
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a = ano / n = ne");
    again = Console.ReadLine();
}


