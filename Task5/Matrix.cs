using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Matrix
    {
        static Random rand = new Random();
        public int Size { get; }
        public double[,] Array { get; }
        public int[] Sequence { get; }

        public Matrix(int size)
        {
            Size = size;
            Array = CreateNewArray(Size, -10, 10);
            Sequence = CreateSequence();

        }
        private double[,] CreateNewArray(int size, int min, int max)
        {
            double[,] array = new double[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    array[i, j] = rand.NextDouble() * (max - min) + min; //формула для генерации вещественного числа

            return array;
        }

        private int[] CreateSequence()
        {
            int[] sequence = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                sequence[i] = 0;
                for (int j = 0; j < Size; j++)
                    if (Array[i, j] < 0)
                    {
                        sequence[i] = 1;
                        break;
                    }
            }

            return sequence;
        }

        public void Show()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                    Console.Write("{0,10:F4} ", Array[i, j]);
                Console.WriteLine();
            }
        }

    }
}
