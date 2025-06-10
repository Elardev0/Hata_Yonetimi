using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir cümle giriniz:");
        string sentence = Console.ReadLine().ToLower();

        char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        List<char> vowelList = new List<char>();

        foreach (char c in sentence)
        {
            if (Array.IndexOf(vowels, c) >= 0)
            {
                vowelList.Add(c);
            }
        }

        vowelList.Sort();

        Console.WriteLine("\nCümledeki sesli harfler (sıralı):");
        foreach (char vowel in vowelList)
        {
            Console.Write(vowel + " ");
        }

        Console.WriteLine($"\n\nToplam sesli harf sayısı: {vowelList.Count}");
    }
}