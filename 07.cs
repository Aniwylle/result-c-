// 7. Дано натуральное число. Определить, является ли разность его максимальной и минимальной цифр четным числом.
 using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int result = CalculateMinMaxDifference(number);

        if (result % 2 == 0)
        {
            Console.WriteLine("Разность максимальной и минимальной цифр является четным числом.");
        }
        else
        {
            Console.WriteLine("Разность максимальной и минимальной цифр не является четным числом.");
        }
    }

    static int CalculateMinMaxDifference(int number)
    {
        int min = 9;
        int max = 0;

        while (number > 0)
        {
            int digit = number % 10;
            min = Math.Min(min, digit);
            max = Math.Max(max, digit);
            number /= 10;
        }

        return max - min;
    }
}