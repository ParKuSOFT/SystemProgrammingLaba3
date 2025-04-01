using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgrammingLaba3
{
    internal class ClassTry_Errors
    {

        static void TrumTrum(string[] args)
        {
            int rows = 6; // Строки определены
            int column = 8; // Столбцы определены
            Random rnd = new Random(); // экземплая класса определен
            int[,] array = new int[rows, column]; // массив определен
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = rnd.Next(20, 41);
                }
            } //цикл определен

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Сортируем нечетные столбцы методом вставки
            for (int j = 1; j < column; j += 2) // Нечетные столбцы (1, 3, 5, ...)
            {
                InsertionSortColumn(array, j);
            }

            // Выводим отсортированный массив
            Console.WriteLine("Массив после сортировки нечетных столбцов:");
            PrintArray(array);
        }

        static void InsertionSortColumn(int[,] array, int col)
        {
            int rows = array.GetLength(0);

            // Сортируем элементы в заданном столбце
            for (int i = 1; i < rows; i++)
            {
                int key = array[i, col];
                int k = i - 1;

                // Сдвигаем элементы, которые больше ключа
                while (k >= 0 && array[k, col] > key)
                {
                    array[k + 1, col] = array[k, col];
                    k--;
                }
                array[k + 1, col] = key;
            }
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}
