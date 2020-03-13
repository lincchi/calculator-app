﻿namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator App";
            //int a = 10;
            //int b = 6;
            
            Console.WriteLine("PILIHAN MENU CALCULATOR :");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();

            Console.Write("Input Pilihan [1..4] : ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch(p)
            {
                case 1:
                    Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                    break;
                default:
                    Console.WriteLine("Maaf, menu yang anda masukan tidak tersedia");
                    break;
            }

            
            Console.WriteLine("\n Tekan Sembarang Key Untuk Keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
