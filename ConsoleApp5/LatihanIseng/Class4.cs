using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.LatihanIseng
{
    class Class4
    {   /*
        Input : Masukan jumlah baris :
                Masukan jumlah kolom :

        Output :
        
            *       *       *
            *               *
            *       *       *
         */
        public void latihan4()
        {
            Console.WriteLine("Masukan Berapa banyak baris yang diinginkan");
            int m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Masukan Berapa banyak kolom yang diinginkan");
            int n = Convert.ToInt16(Console.ReadLine());
            int[,] matriks = new int[m, n];

            int nRow = matriks.GetLength(0);
            int nCol = matriks.GetLength(1);
            if (m == n)
            {

                for (int i = 0; i < nRow; i++)
                {
                    for (int j = 0; j < nCol; j++)
                    {
                        if (i == 0 || i == (nRow - 1))
                        {

                            Console.Write("* \t");
                        }
                        else if (j == 0 || j == (nCol - 1))
                        {
                            matriks[i, j] = n;
                            Console.Write("* \t");
                        }
                        else
                        {
                            Console.Write(" \t");
                        }

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Masukan jumlah baris dan kolom yang sama");
            }
        }
    }
}
