string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("**********Výpis číselné řady * ********");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");
    Console.WriteLine("**********Výpis číselné řady **********");
    Console.WriteLine("**************2.10. 2025 * ************");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");
    Console.WriteLine();

    Console.Write("Zadejte šířku obdélníku: ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte šířku obdélníku znovu: ");
    }

    Console.Write("Zadejte výšku obdélníku: ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte výšku obdélníku znovu: ");
    }


    for (int i = 1; i <= height; i++)
        for (int j = 1; j <= width; j++)
        {
            Console.Write("*")
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(500));
        }
    Console.WriteLine();



    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a ");
    again = Console.ReadLine();
}