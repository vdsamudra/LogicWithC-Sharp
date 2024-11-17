using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.LatihanIseng
{
    class Class3
    {
        public void latihan3()
        {
            /*
             Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

            Example
            1,3,5,7,9
            The minimum sum is 1+3+5+7 and the maximum sum is 3+5+7+9 . The function prints
            16 24
             */

            Console.Write("Masukan deret angka : \n");
            string[] deret = Console.ReadLine().Split(",");

            int[] angka = new int[deret.Length];
            int min = angka[0];
            int max = angka[0];
            int jumlah = 0;

            for (int i = 0; i < deret.Length; i++) 
            {
                angka[i] = Convert.ToInt16(deret[i]);
                if (angka[i] > max)
                {
                    max = angka[i];
                }
                if (angka[i] <= min)
                {
                    min = angka[i];
                }

                jumlah += angka[i];
            }

            int jumlahMaksimum = jumlah - min;
            int jumlahMinimum = jumlah - max;

            Console.WriteLine(max);
            Console.WriteLine(min);

            Console.WriteLine($"\n Jumlah Maksimum {jumlahMaksimum}");
            Console.WriteLine($"\n Jumlah Minimum {jumlahMinimum}");

            


        }
    }
}
