using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_10_16Sortowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj rozmiar tablicy do sortowania: ");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            Random rnd = new Random();
            int licznik;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(-99, 999);
            }
            Console.WriteLine("Tablica przed sortowaniem");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            //licznik = Sortowanie.SelectionSort(tab);
            licznik = Sortowanie.InsertionSort(tab);
            //licznik = Sortowanie.QuickSort(tab, 0, tab.Length - 1);
            Console.WriteLine("\nTablica po sortowaniu");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
