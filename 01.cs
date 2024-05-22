// 1. Дано натуральное число N. Найти сумму его четных делителей.
using System;

class testOne
{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = GetSum(N);

        Console.WriteLine($"Сумма четных делителей числа {N} равна {sum}");
    }

    static int GetSum(int number)
    {
        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0 && i % 2 == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}
