// 2. Дано натуральное число. Определить, какая цифра встречается чаще: 0 или 9.
using System;
using System.Collections.Generic;
using System.Linq;

class testtwo
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        string input = Console.ReadLine();

        int nul = input.Count(ch => ch == '0');
        int nine = input.Count(ch => ch == '9');

        if (nul > nine)
        {
            Console.WriteLine("Цифра 0 встречается чаще");
        }
        else if (nine > nul)
        {
            Console.WriteLine("Цифра 9 встречается чаще");
        }
        else if (nine == 0 && nul == 0)
        {
            Console.WriteLine("Цифры 0 и 9 не встречаются вообще");
        }
        else
        {
            Console.WriteLine("Цифры 0 и 9 встречаются одинаковое количество раз");
        }
    }
}