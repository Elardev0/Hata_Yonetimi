using System;
using System.Collections;
using System.Linq;

class Program
{
    static void Main()
    {
        ArrayList primeNumbers = new ArrayList();
        ArrayList nonPrimeNumbers = new ArrayList();
        int count = 0;

        Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz:");

        while (count < 20)
        {
            Console.Write($"{count + 1}. sayı: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number > 0)
            {
                if (IsPrime(number))
                    primeNumbers.Add(number);
                else
                    nonPrimeNumbers.Add(number);
                count++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı girin.");
            }
        }

        // Sıralama
        primeNumbers.Sort();
        primeNumbers.Reverse();
        nonPrimeNumbers.Sort();
        nonPrimeNumbers.Reverse();

        // Yazdırma
        Console.WriteLine("\nAsal Sayılar (Büyükten Küçüğe):");
        PrintArrayList(primeNumbers);

        Console.WriteLine("\nAsal Olmayan Sayılar (Büyükten Küçüğe):");
        PrintArrayList(nonPrimeNumbers);

        // Ortalama ve sayılar
        Console.WriteLine($"\nAsal Sayılar: Eleman Sayısı = {primeNumbers.Count}, Ortalama = {CalculateAverage(primeNumbers)}");
        Console.WriteLine($"Asal Olmayan Sayılar: Eleman Sayısı = {nonPrimeNumbers.Count}, Ortalama = {CalculateAverage(nonPrimeNumbers)}");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    static void PrintArrayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }

    static double CalculateAverage(ArrayList list)
    {
        if (list.Count == 0) return 0;
        double sum = 0;
        foreach (int num in list)
        {
            sum += num;
        }
        return sum / list.Count;
    }
}