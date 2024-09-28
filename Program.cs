using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace razakov
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleArray arrey = new DoubleArray(); arrey.additional();
            Console.WriteLine(); arrey.additional1();
            Console.WriteLine(); arrey.additional11();
            Console.WriteLine(); arrey.additional111();
        }
    }
    class DoubleArray
    {
        public static int Strings = 3;
        public static int Columns = 4; public int[,] array = new int[Strings, Columns];
        public int[,] array1 = new int[Strings, Columns]; public int[,] array2 = new int[Strings, Columns];
        public int[,] array3 = new int[Strings, Columns];
        public void additional()
        {
            Random rnd = new Random(); for (int i = 0; i < Strings; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = rnd.Next(1, 9);
                    array1[i, j] = rnd.Next(1, 9); Console.Write(array[i, j] + array1[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
        public void additional1()
        {
            Random rnd = new Random(); for (int i = 0; i < Strings; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = rnd.Next(1, 9);
                    Console.Write(array[i, j] * 2 + "   ");
                }
                Console.WriteLine();
            }
        }
        public void additional11()
        {
            Random rnd = new Random();
            for (int i = 0; i < Strings; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array2[i, j] = rnd.Next(1, 9); Console.Write(array[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
        public void additional111()
        {
            Random rnd = new Random(); for (int i = 0; i < Strings; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = rnd.Next(1, 9); array1[i, j] = rnd.Next(1, 9);
                    Console.Write(array[i, j] * array1[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
