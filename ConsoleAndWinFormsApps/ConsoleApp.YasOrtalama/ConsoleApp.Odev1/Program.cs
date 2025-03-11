using System;

namespace ConsoleApp.Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int kizSayisi = 0;
            int kizYasToplami = 0;
            int erkekSayisi = 0;
            int erkekYasToplami = 0;

            Console.WriteLine("Cinsiyet (kız/erkek), çıkmak için 'x' tuşuna basın");
            string cinsiyet = Console.ReadLine().ToLower();

            if (cinsiyet != "x")
            {
                Console.WriteLine("Yaş: ");
                int yas = int.Parse(Console.ReadLine());

                if (cinsiyet == "kız")
                {
                    kizSayisi = kizSayisi + 1;
                    kizYasToplami += yas;
                }
                else if (cinsiyet == "erkek")
                {
                    erkekSayisi = erkekSayisi + 1;
                    erkekYasToplami += yas;
                }

            }

            double kizYasOrtalama = kizSayisi > 0 ? kizYasToplami / (double)kizSayisi : 0;
            double erkekYasOrtalamasi = erkekSayisi > 0 ? erkekYasToplami / (double)erkekSayisi : 0;

            Console.WriteLine("Kızların sayısı: " + kizSayisi);
            Console.WriteLine("Kızların yaş ortalaması: " + kizYasOrtalama);
            Console.WriteLine("Erkeklerin sayısı: " + erkekSayisi);
            Console.WriteLine("Erkeklerin yaş ortalaması: " + erkekYasOrtalamasi);



            Console.ReadKey();
        }
    }
}