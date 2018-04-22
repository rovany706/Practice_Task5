using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 5\n=================");
            Console.WriteLine("Условие задачи:\nДаны натуральное число n, действительная квадратная матрица порядка n.\n" +
                              "Построить последовательность b1, ..., bn из нулей и единиц,\n" +
                              "в которой b i-ое = 1 тогда и только тогда, когда в i-й строке матрицы есть хотя бы один отрицательный элемент.\n" +
                              "=================");
            int input;
            bool ok;
            Console.Write("Введите размер матрицы, для создания матрицы из случайных чисел в диапазоне [-10, 10]: ");
            do
            {
                ok = int.TryParse(Console.ReadLine(), out input);
                if (!ok || input < 1)
                {
                    ok = false;
                    Console.WriteLine("Ошибка! Введите натуральное число.");
                }
            } while (!ok);
            Matrix matr = new Matrix(input);
            Console.WriteLine("Матрица:");
            matr.Show();
            Console.Write("Получившаяся поледовательность: ");
            foreach (int i in matr.Sequence)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }
    }
}
