// 16. Дан массив, содержащий 10 трехзначных чисел. Заменить каждый элемент массива разностью максимальной и минимальной из его цифр.
 using System;

class testsixtn
{
    static void Main()
    {
      
        int[] array = { 123, 784, 729, 371, 184, 987, 246, 148, 579, 804 }; 
        Console.WriteLine("Исходный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < array.Length; i++)
        {
            int number = array[i];
            int max = 0;
            int min = 9;

            while (number > 0)
            {
                int digit = number % 10;
                max = Math.Max(max, digit);
                min = Math.Min(min, digit);
                number = number / 10;
            }

            array[i] = max - min;
        }

        Console.WriteLine("Измененный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
} 