// 4. Найти все трехзначные числа, которые делятся на n или содержат цифру n (n вводится с клавиатуры).
using System;

class testfour
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Трехзначные числа, которые делятся на {n} или содержат цифру {n}:");

        for (int i = 100; i <= 999; i++)
        {
            if (i % n == 0 || ContainsDigit(i, n))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool ContainsDigit(int number, int digit)
    {
        while (number > 0)
        {
            if (number % 10 == digit)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }
}