using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyatnashki();
            Console.ReadLine();
           
        }
        public static void Pyatnashki()
        {
            int[,] mass = new int[3,3];
            PrintMass(mass);
            initmass(mass);
            Console.WriteLine();
            PrintMass(mass);
            
        }
        public static void PrintMass(int[,] mass)
        {
            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{mass[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        static Random rand = new Random();
        public static void initmass(int[,] mass)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    mass[i, j] = rand.Next(10);
                }
            }
        }
    }
}
