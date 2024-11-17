using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.LatihanIseng
{
    class Class2
    {
        public void latihan2()
        {
            /*
            Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.
            Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable.
            arr = [1,1,0,-1,-1]
            Example
            There are  elements, two positive, two negative and one zero. Their ratios are ,  and . Results are printed as:
            positif = 2/5 = 0.4
            negatif = 2/5 = 0.2
            zero = 1/5 = 0.2
             
             */

            Console.Write("Masukan deret terdiri dari angka positif/negatif/0 : ");
            string[] deret = Console.ReadLine().Split(",");

            int[] angka = new int[deret.Length];
            decimal positif = 0;
            decimal negatif = 0;
            decimal zero = 0;
            


            for (int i = 0; i < deret.Length; i++)
            {
                angka[i] = Convert.ToInt16(deret[i]);
                if (angka[i] > 0)
                {
                    positif++;
                }
                if (angka[i] < 0)
                {
                    negatif++;
                }
                if (angka[i] == 0)
                {
                    zero++;
                }
            }
            int panjang = angka.Length;


            decimal RasioPositif = Convert.ToDecimal(positif/panjang);
            decimal RasioNegatif = Convert.ToDecimal(negatif/panjang);
            decimal RasioZero = Convert.ToDecimal(zero/panjang);

            Console.WriteLine($"\n panjang = {panjang}");
            Console.WriteLine($"\n Positif = {positif}");
            Console.WriteLine($"\n Negatif = {negatif}");
            Console.WriteLine($"\n Zero = {zero}");
            Console.WriteLine($"\n RasioPositif = {RasioPositif}");
            Console.WriteLine($"\n RasioNegatif = {RasioNegatif}");
            Console.WriteLine($"\n RasioZero = {RasioZero}");

        }
    }
}
