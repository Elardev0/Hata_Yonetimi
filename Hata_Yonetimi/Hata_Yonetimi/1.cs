using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pozitif iki sayı girin (n ve m):");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine($"{n} adet pozitif sayı girin:");
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num == m || num % m == 0)
            {
                Console.WriteLine($"Eşit veya tam bölünen: {num}");
            }
        }
    }
}