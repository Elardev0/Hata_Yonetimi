using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir cümle yazın:");
        string sentence = Console.ReadLine();

        // Kelime sayısı (boşluklara göre ayır)
        string[] words = sentence.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        // Harf sayısı (boşlukları hariç tut)
        int letterCount = 0;
        foreach (char c in sentence)
        {
            if (!char.IsWhiteSpace(c))
            {
                letterCount++;
            }
        }

        Console.WriteLine($"Toplam kelime sayısı: {wordCount}");
        Console.WriteLine($"Toplam harf sayısı: {letterCount}");
    }
}