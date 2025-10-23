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

    Console.Write("Zadej celé číslo C:");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu C:");
    }

    Console.WriteLine();


    //Tady chceme seřadit čísla vzestupně
    if (a > b)
    {
        if (a > c)
            Console.WriteLine($"Největší číslo je A = {a}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }
    else
    {
        if (b > c)
            Console.WriteLine($"Největší číslo je B = {b}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }



    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a = ano / n = ne");
    again = Console.ReadLine();
}