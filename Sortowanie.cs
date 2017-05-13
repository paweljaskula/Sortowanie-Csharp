using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_10_16Sortowanie
{
    class Sortowanie
    {
        //public static void SelectionSort(int[] tab)
        //{
        //    int pom;
        //    for (int i = 0; i < tab.Length; i++)
        //    {
        //        int min = i;
        //        for (int j = i+1; j < tab.Length; j++)
        //        {
        //            if (tab[j] <tab[min])
        //            {
        //                min = j;
        //            }
        //            pom = tab[i];
        //            tab[i] = tab[min];
        //            tab[min] = pom;
        //        }
        //    }
        //}
        public static int SelectionSort(int[] tab)
        {
            int licznik = 0;
            int pom;
            for (int i = 0; i < tab.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[min])
                    {
                        min = j;
                    }
                    pom = tab[i];
                    tab[i] = tab[min];
                    tab[min] = pom;
                    licznik++;
                }
                
            }
            return licznik;
        }
        public static int InsertionSort(int[] tab)
        {
            int licznik = 0;
            int v,j;
            for (int i = 1; i < tab.Length; i++)
			{
                j=i; v=tab[i];
                while (tab[j-1] > v)
	            {
                    tab[j] = tab[j - 1]; j = j-1;
                    licznik++;
                    if (j == 0) break;
	         
                }
                tab[j] = v;
			}
            return licznik;
        }
        public static int QuickSort(int[] tab, int d, int g)
        {
            int licznik = 0;
            int element = tab[(d + g) / 2];
            int i = d;
            int j = g;
            int pom;
            do
            {
                while (tab[i] < element)
                {
                    i++; licznik++;
                }
	            while (tab[j] > element)
                {
                    j--; licznik++;
                }
                if (i<=j)
                {
                    pom = tab[i];
                    tab[i] = tab[j];
                    tab[j] = pom;
                    j--; i++;
                }
	            
            } while (i<=j);
            if (d < j)
            {
                licznik += QuickSort(tab, d, j); 
            }
            if (g > i)
            {
                licznik += QuickSort(tab, i, g);
            }
            return licznik;
        }

    }
}
