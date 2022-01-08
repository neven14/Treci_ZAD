using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treci_Zad
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[] { 3, 2, 4, 0, 5, 1, 6, 7, 9, 8 };
            Sort x = new Sort();
            x.QuickSort(niz, 1, niz.Length - 2);
            for (int i = 0; i < niz.Length; i++)
                Console.WriteLine(niz[i]);
        }
    }
}
