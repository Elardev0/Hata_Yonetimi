using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pozitif bir sayı girin (n):");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"{n} adet pozitif sayı girin:");
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"Çift sayı: {num}");
            }
        }
    }
}