using System;


class Program
{
    static void Main(string[] args)
    {

        // Ось як буде працювати програма:

        //  ввести розміри двовимірного масиву(рядки та стовпці).
        //  ввести початкове число.
        // заповнити масив так, щоб кожен наступний елемент був на одиницю більшим за попередній.
        // вивести заповнений масив на екран.


        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        Console.Write("Enter the starting number: ");
        int startNumber = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, cols];
        FillArray(array, startNumber);
        PrintArray(array);
    }
    static void FillArray(int[,] array, int startNumber)
    {
        int number = startNumber;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = number++;
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
