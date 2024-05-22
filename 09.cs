
using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[6];

        Console.WriteLine("Введите шесть различных натуральных чисел:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxNumber = maxnum(numbers);

        Console.WriteLine($"Максимальное число: {maxNumber}");
    }

    static int maxnum(int[] array)
    {
        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }
}