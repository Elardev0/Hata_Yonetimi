using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.WriteLine("Bir sayı girin: ");
				int sayi = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Girdiğiniz sayı: " + sayi);
            }
			catch (Exception ex)
			{
				Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
			//finally
			//{
			//    Console.WriteLine("İşlem Tamamlandı.");
			//}

			try
			{
				//int a = int.Parse(null);
				//int a = int.Parse("test");
				int a = int.Parse("-20000000000");
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Format hatası: " + ex.Message);
			}
			catch (OverflowException ex)
			{
				Console.WriteLine("Taşma hatası: " + ex.Message);
			}
			catch (ArgumentNullException ex)
			{
				Console.WriteLine("Boş değer hatası: " + ex.Message);
			}
			finally 
			{
				Console.WriteLine("İşlem tamamlandı.");
            }
            

			//---------------------------------------------------------------
			//  IF ELSE Karar yapıları...

			int time = DateTime.Now.Hour;
            if (time >= 6 && time< 11)
				Console.WriteLine("Günaydın");
			else if (time <= 18)
				Console.WriteLine("İyi Günler");
			else
				Console.WriteLine("İyi Geceler");
			string sonuc = time <= 11 ? "İyi Günler!" : "İyi Geceler!";
			sonuc = time>6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);

        }
    }
}
