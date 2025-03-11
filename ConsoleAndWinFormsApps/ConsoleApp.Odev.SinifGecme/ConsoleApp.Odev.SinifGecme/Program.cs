namespace ConsoleApp.Odev.SinifGecme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////// Girilen 2 sınav notunun ortalamasını hesaplayıp geçme derecesini gösteren uygulamayı yazınız.( AND-OR kullanılmayacak)
            ////// 0-49 Kaldı
            ////50-59 CC
            ////60-69 CB
            ////70-79 BB
            ////80-89 BA
            ////90-100 AA
            ///


            Console.WriteLine("1. sınav notunu girin: ");
            int s1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sınav notunu girin: ");
            int s2 = int.Parse(Console.ReadLine());

            double ortalama = (s1 + s2) / 2.0;

            string derece = "Kaldı";

            if (ortalama >= 90)
            {
                derece = "AA";
            }
            else if (ortalama >= 80)
            {
                derece = "BA";
            }
            else if (ortalama >= 70)
            {
                derece = "BB";
            }
            else if (ortalama >= 60)
            {
                derece = "CB";
            }
            else if (ortalama >= 50)
            {
                derece = "CC";
            }

            if (derece == "Kaldı")
            {
                Console.WriteLine("Ortalama: " + ortalama);
                Console.WriteLine("Geçme Durumu: Kaldı");
            }
            else
            {
                Console.WriteLine("Ortalama: " + ortalama);
                Console.WriteLine("Geçme Durumu: Geçti");
                Console.WriteLine("Geçme Derecesi: " + derece);
            }

            Console.ReadKey();
        }
    }
}