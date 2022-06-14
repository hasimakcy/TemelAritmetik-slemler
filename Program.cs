using System;

namespace Temel_Aritmetik_Islemler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 ayrı sayı girmesini isteyen.
            // Bu sayıların toplamlarını ekrana yazdıran program.

            // AÇILIŞ
            Console.WriteLine("Bu minik program kullanıcıdan aldığı\niki sayıyı toplamak için geliştirilmiştir.");
            //  \n ENTER görevi görür. Alt satıra geçmek için kullanılır.
            Console.WriteLine();


            // INPUT
            // sayi1 al
            Console.Write("İlk sayıyı giriniz: ");
            string gSayi1 = Console.ReadLine();

            // sayi2 al
            Console.Write("İkinci sayıyı giriniz: ");
            string gSayi2 = Console.ReadLine();

            // PROCESS-1 (girdileri duzenleme)
            int sayi1 = Convert.ToInt32(gSayi1);
            int sayi2 = Convert.ToInt32(gSayi2);

            // PROCESS-2 (iş)
            // sayilari topla, sonucu elde et
            int toplam = sayi1 + sayi2;
            int cıkarma = sayi1 - sayi2;
            int bölme = sayi1 / sayi2;
            int carpma = sayi1 * sayi2;

            //OUTPUT
            // Sonucu ekrana yazdir
            Console.WriteLine("Toplam: " + Convert.ToString(toplam));
            Console.WriteLine("Çıkarma: " + Convert.ToString(cıkarma));
            Console.WriteLine("Bölüm: " + Convert.ToString(bölme));
            Console.WriteLine("Çarpım: " + Convert.ToString(carpma));

            // Ondalık sonuçlar için =
            // Ondalık sayı veri tipleri (FLOAT-DECİMAL-DOUBLE) C#

        }
    }
}
