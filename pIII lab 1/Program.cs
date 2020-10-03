using System;

namespace pIII_lab_1
{
    class Program
    {
        static void Funkcja(ref int liczba)
        {
            Console.WriteLine("F: "+liczba);
            liczba = 200;
            Console.WriteLine("F: " + liczba);
        }
        static void Funkcja(ref int liczba)
        {
            Console.WriteLine("F: "+tablica[0]);
            tablica[0] = 200;
            Console.WriteLine("F: " + tablica[0]);
        }
        static void Main(string[] args)
        {
            int zmienna = 100;
            float liczbazmiennoprzecinkowa1 = 2.5f;
            double liczbazmiennoprzecinkowa2 = 25;
            char litera = 'h';
            string slowo = "h";
            int[]_tablica = [1, 2, 3];

            Console.WriteLine("M")


        }

    }
}
