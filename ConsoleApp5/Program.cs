using System;
using ConsoleApp5.LatihanIseng;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Masukan nomer Class Latihan: ");
            string soal = Console.ReadLine();
            Console.Clear();

            switch (soal)
            {
                case "1":
                    Class1 latihan1 = new Class1();  // soal 1 biodata
                    latihan1.latihan1();
                    break;
                case "2":
                    Class2 latihan2 = new Class2();
                    latihan2.latihan2();
                    break;
                case "3":
                    Class3 latihan3 = new Class3();
                    latihan3.latihan3();
                    break;
                case "4":
                    Class4 latihan4 = new Class4();
                    latihan4.latihan4();
                    break;
                case "5":
                    Class5 latihan5 = new Class5();
                    latihan5.latihan5();
                    break;
                case "6":
                    Class6 latihan6 = new Class6();
                    latihan6.latihan6();
                    break;
                default:
                    Console.WriteLine("nomer soal tidak ditemukan");
                    break;

            }

           
        }
    }
}
