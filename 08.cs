// 8. Даны два натуральных числа. Выяснить, в каком из них сумма цифр больше.
 using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое натуральное число: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе натуральное число: ");
        int number2 = int.Parse(Console.ReadLine());

        int sum1 = CalculateSumOfDigits(number1);
        int sum2 = CalculateSumOfDigits(number2);

        if (sum1 > sum2)
        {
            Console.WriteLine($"Сумма цифр в первом числе больше, чем во втором числе.");
        }
        else if (sum1 < sum2)
        {
            Console.WriteLine($"Сумма цифр во втором числе больше, чем в первом числе.");
        }
        else
        {
            Console.WriteLine($"Суммы цифр в обоих числах равны.");
        }
    }

    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}