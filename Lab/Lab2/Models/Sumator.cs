using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab2.Models
{
    public class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

         public int Suma()
         {
             int suma = 0;
             foreach (int liczby in Liczby)
             {
                 suma += liczby;
             }
             return suma;
         }

         public int SumaPodziel3()
         {
             int suma = 0;
             foreach (int liczby in Liczby)
             {
                if (liczby % 3 == 0)
                {
                    suma += liczby;
                }
             }
             return suma;
         }

        public int IleElementow()
        {
            return Liczby.Length;
        }

        public void WszystkieElementy()
        {
            for (var i = 0; i < Liczby.Length; i++)
            {
                Console.WriteLine(Liczby[i]);
            }
        }

        public void WWszystkieElementy(int lowIndex, int highIndex)
        {
            lowIndex = lowIndex < 0 ? 0 : lowIndex;
            highIndex = highIndex > Liczby.Length ? Liczby.Length : highIndex;

            for(var i = lowIndex; i < highIndex; i++)
            {
                Console.WriteLine(Liczby[i]);
            }
        }
    }
}
