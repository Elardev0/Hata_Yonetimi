using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[20];
        Console.WriteLine("Lütfen 20 adet sayı giriniz:");

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"{i + 1}. sayı: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numbers[i]))
                    break;
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
            }
        }

        Array.Sort(numbers);

        int[] smallestThree = new int[3];
        int[] largestThree = new int[3];

        Array.Copy(numbers, smallestThree, 3);
        Array.Copy(numbers, numbers.Length - 3, largestThree, 0, 3);

        double smallestAvg = CalculateAverage(smallestThree);
        double largestAvg = CalculateAverage(largestThree);

        Console.WriteLine("\nEn küçük 3 sayı:");
        PrintArray(smallestThree);
        Console.WriteLine($"Ortalama: {smallestAvg}");

        Console.WriteLine("\nEn büyük 3 sayı:");
        PrintArray(largestThree);
        Console.WriteLine($"Ortalama: {largestAvg}");

        Console.WriteLine($"\nOrtalama toplamları: {smallestAvg + largestAvg}");
    }

    static double CalculateAverage(int[] arr)
    {
        double sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum / arr.Length;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}