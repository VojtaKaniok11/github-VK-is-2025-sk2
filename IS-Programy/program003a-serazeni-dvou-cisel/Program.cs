using System.Runtime.InteropServices.Marshalling;

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

    Console.Write("Zadej celé číslo A:");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu A:");
    }

    Console.Write("Zadej celé číslo B:");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu B:");
    }

    Console.WriteLine();

    int pom;
    //Tady chceme seřadit čísla vzestupně
    if (a > b)
    {
        pom = a;
        a = b;
        b = pom;
        Console.WriteLine("Došlo k prohození proměnných");
    }


    Console.WriteLine("=====================================");
    Console.WriteLine($"Seřazení čísla: {a}, {b}");
    Console.WriteLine("=====================================");
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a = ano / n = ne");
    again = Console.ReadLine();
}