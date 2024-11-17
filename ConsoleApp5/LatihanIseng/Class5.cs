using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.LatihanIseng
{
    class Class5
    {
        /*
         soal
        keterngan soal
        input : menginput angka, yang nantinya akan menjadi matriks nxn
        output : - menampilkan baris angka berbentuk segitiga, 
                 - dimana angkanya dengan selisih 3
                 - dan setiap deret kelipatan 4 maka akan menampilan 3^n
        
         contoh output:
              
	        							17		
	        						14	9		
	        					11		20		
	        				3			23		
	        			8				26		
	        		5					27		
	        	2	41	38	81	35	32	29
										


        *coret coretan:
										
		        0	1	2	3	4	5	6       -> baris		
	        0							17		
	        1						14	9		
	        2					11		20		
	        3				3			23		
	        4			8				26		
	        5		5					27		
	        6	2	41	38	81	35	32	29	
        

        jika kalo n nya 8
        		        N = 8					i+j+(2*(i-j))= 6+5+(2*(6-5))=11+2=13
                                                    = 6+4+(2*(6-4))=10+4= 14
                                                    = 6+3+(2*(6-3))=9+6=15
         */
        public void latihan5()
        {
            Console.Write("input : ");
            int n = Convert.ToInt16(Console.ReadLine());

            //membuat deretnya dulu
            int[] pola = new int[(n - 1) + (n - 2) + (n - 3)];
            int count = 0;
            int kelipatanTiga = 1;
            int angka = 1;

            for (int i = 0; i < (n - 1) + (n - 2) + (n - 3); i++)
            {

                if (angka % 4 == 0)
                {
                    pola[i] = Convert.ToInt16(Math.Pow(3, kelipatanTiga));
                    kelipatanTiga++;
                    angka++;
                }
                else
                {
                    pola[i] = 2 + (3 * count);
                    count++;
                    angka++;
                }
            }


            int[,] matrix = new int[n - 1, n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (j == n - 2)
                    {
                        matrix[i, j] = pola[i + j];  // 6 7 8 9 10 11 12

                    }
                    else if (i == n - 2 && j != 0)
                    {
                        matrix[i, j] = pola[i + j + (2 * (i - j))];  // 13 14 15 16 17
                    }
                    else if (i + j == n - 2)
                    {
                        matrix[i, j] = pola[j];  // 0 1 2 3 4 5 
                    }
                }
            }

            for (int i = 0; i < n - 1; i++) // loop baris
            {
                Console.Write("\n\n\t");
                for (int j = 0; j < n - 1; j++) // loop kolom
                {

                    if (matrix[i, j] == 0)
                    {
                        string o = string.Format("{0,4}", " ");
                        Console.Write(o);
                    }
                    else
                    {
                        string o = string.Format("{0,4}", matrix[i, j]);
                        Console.Write(o);
                    }



                }

            }
        }
    }
}
