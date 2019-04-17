using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    class Program
    {
        class Neighbor
        {
            public string fullname;
            public int flatNumber;
            public int phoneNumber;
        }
        static void Main(string[] args)
        {
           /// Pyatnashki();
            ///ArrayListExample();
            ArrayListExample1();
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
        public static void ArrayListExample()
        {
            ArrayList myAL = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                string s =Console.ReadLine();
                myAL.Add(s);
            }
            myAL.Sort();
            myAL.RemoveAt(myAL.Count - 1);
            foreach (string item in myAL)
            {
                Console.WriteLine(item);
            }
        }

        public static void ArrayListExample1()
        {
            var parts = new Dictionary<int, Neighbor>();
            parts.Add(1,new Neighbor { fullname = "Fedya", flatNumber = 1, phoneNumber = 659842 });
            parts.Add(2,new Neighbor { fullname = "Vasia", flatNumber = 2, phoneNumber = 6854357 });
            parts.Add(3,new Neighbor { fullname = "Kola", flatNumber = 3, phoneNumber = 874422477 });
            Console.WriteLine("input flat number");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(parts[s].phoneNumber);
            //foreach (var item in parts)
            //{
            //    if(item.flatNumber == s)
            //    {
            //        Console.WriteLine(item.phoneNumber);
            //        break;
            //    }
            //}
        }


    }
}
