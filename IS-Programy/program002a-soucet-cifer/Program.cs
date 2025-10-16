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

    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte ho znovu: ");
    }
    int suma = 0;

    int numberBackup = number;
    int digit;


    //pokud je vstup záporný tímto ho změníme na kladný
    if (number < 0)
    {
        number = -number;
    }

    while (number >= 10)
    {
        digit = number % 10; //určí se nám zbytek 
        number = (number - digit) / 10;
        Console.WriteLine("Hodnota zbytku: {0}", digit);
        suma = suma + digit;
    }
    //musíme poslední cifru vypsat
    Console.WriteLine("Poslední zbytek = {0}", number);
    //Musíme poslední cifru přičíst

    suma = suma + number;

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);

    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a ");
    again = Console.ReadLine();
}