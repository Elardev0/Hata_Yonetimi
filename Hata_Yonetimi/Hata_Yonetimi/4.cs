using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pozitif bir sayı girin (n):");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];
        Console.WriteLine($"{n} adet kelime girin:");
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("Kelimeler sondan başa:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(words[i]);
        }
    }
}