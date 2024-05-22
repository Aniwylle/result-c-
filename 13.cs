// 13. Дан одномерный массив целых чисел. Найти максимальный элемент массива и поменять его местами с первым элементом.
using System;

class testthren
{
    static void Main()
    {
        int[] array = { 123, 476, 784, 327, 659, 981, 245, 132, 576, 804 };
 Console.WriteLine("Исходный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            int number = array[i];
            int maxDigit = 0;
            int minDigit = 9;

            while (number > 0)
            {
                int digit = number % 10;
                maxDigit = Math.Max(maxDigit, digit);
                minDigit = Math.Min(minDigit, digit);
                number = number / 10;
            }

            array[i] = maxDigit - minDigit;
        }

        Console.WriteLine("Измененный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
}