using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint4.Task3.V25.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint4.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5] { { 7, 3, 5, 3, 6 },
                                     { 4, 6, 2, 5, 7 },
                                     { 2, 3, 3, 3, 5 },
                                     { 2, 7, 7, 6, 2 },
                                     { 6, 6, 4, 3, 6 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Жданова А. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание: 3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Жданова Анна Александровна                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 7. Найдите произведение     *");
            Console.WriteLine("* элементов в четвертом столбце массива.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            { 
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение элементов в 4-ом столбце = {ds.Calculate(mtrx)}");
            Console.ReadKey();
        }
    }
}
