string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("**********Výpis číselné řady * **********");
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
    Console.Write("Zadejte první číslo řady (celé): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last) || last < first)
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
    }
    Console.Write("zadejte diferenci (celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte diferenci znovu: ");
    }

    //výstup zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================== ");
    Console.WriteLine("Zadali jste tyto hodnoty: ");
    Console.WriteLine("První číslo řady: {0}", first);
    Console.WriteLine("První číslo řady: {0}", last);
    Console.WriteLine("Diference: {0}", step);
    Console.WriteLine("====================================== ");
    Console.WriteLine("První číslo: {0}; Poslední číslo: {1}; Diference: {2}", first, last, step);
    Console.WriteLine("====================================== ");


    //Výpis číselné řady
    Console.WriteLine();
    Console.WriteLine("====================================== ");
    Console.WriteLine("Výpis číselné řady: ");

    int current = first;
    while (current <= last)
    {
        Console.WriteLine(current);
        current = current + step; // přičtení diference k aktutuální vypisované hodnotě

    }



    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a");



}