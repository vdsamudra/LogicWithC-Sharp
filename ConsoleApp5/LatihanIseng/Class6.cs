using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.LatihanIseng
{
    class Class6
    {

        /*
         Diagonal Difference																								
																								
        Contoh Input  n =3
        
        0   1   2
      0 11	2	4		input ke 1																				
      1 4	5	6		input ke 2																				
      2 10	8	-12		input ke 3																				
																								
        Contoh Output																								
        15																								
																								
        Penjelasan																								
        Diagonal Pertama adalah:																								
        11																								
	        5																							
		        -12																						
        Lakukan penjumlahan terhadap angka didiagonal tersebut																								
        11 + 5 - 12 = 4																								
																								
        Diagonal ke dua adalah:																								
		        4																						
	        5																							
        10																								
        Lakukan penjumlahan terhadap angka didiagonal tersebut																								
        4 + 5 + 10 = 19																								
																								
        Lakukan pengurangan diagonal ke satu terhadap didiagonal ke dua, dan jadikan bilangan mutlak																								
        |4 - 19| = 15	
        
        *coret-coretan:
        untuk diagonal kanan: cari saja yang index baris dan kolom sama

        cara mendapatkan kolom untuk diagonal kanan :

        contoh untuk matriks 3x3
        untuk diagonal kiri berarti index
        (0,2),(1,1),(2,0)

        didapat sebuah formula
        n - 1 - i = j


        cek untuk (0,2) = 3 - 1 - 0 maka sama dengan 2
                  (1,1) = 3 - 1 - 1 maka sama dengan 1
                  (2,0) = 3 - 1 - 2 maka sama dengan 0

         */

        public void latihan6()
        {
            Console.Write("Masukan mau matrik persegi ukuran berapa : ");
            int n = Convert.ToInt16(Console.ReadLine());
            int[,] matrix = new int[n, n];
            string[] baris = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("inputan ke {0} : ", i + 1);
                baris[i] = Console.ReadLine();

            }

            for (int i = 0; i < n; i++)
            {
                string[] baris1 = baris[i].Split(" ");
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Convert.ToInt16(baris1[j]);
                }
            }


            // menghitung diagonal kiri
            int sum = 0;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (j == i)
                    {
                        sum = sum + matrix[i, j];
                    }

                }
            }
            Console.Write("penjumlahan diagonal kiri : {0}\n", sum);


            // menghitung diagonal kanan
            int sum2 = 0;
            int m = n;
            for (int i = 0; i < n; i++)
            {
                m = n - 1 - i;
                for (int j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        sum2 += matrix[i, j];
                    }
                }
            }
            Console.Write("penjumlahan diagonal kanan : {0}\n", sum2);
            int jumlah = Math.Abs(sum - sum2);
            Console.Write("Hasil penjumlahan mutlak diagonal kiri dan kanan :" + jumlah);
        }
    }
}
