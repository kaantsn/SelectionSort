using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 9, 0, 7, -6, -8 };
            int temp = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = i; j < dizi.Length; j++)
                {
                    if (dizi[i] > dizi[j])
                    {
                        temp = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = temp;
                    }
                }
            }
            foreach (int i in dizi)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
