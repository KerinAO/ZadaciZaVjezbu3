using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciZaVjezbu3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[] { 0, 22, 3, 1, 25, 15, 6, 7, 29, 88 };
            Sort x = new Sort();
            x.QuickSort(niz, 1, niz.Length - 2);
            for (int i = 0; i < niz.Length; i++)
                Console.WriteLine(niz[i]);
            Console.ReadKey();
        }
    }
}
