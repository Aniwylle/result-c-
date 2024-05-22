// 14. Известно, что в одномерном массиве имеются элементы, равные 5. Определить номер первого из них.
using System;

class testfourtn
{
    static void Main()
    {

        int[] array = { 3, 7, 5, 8, 4, 5, 10 };
 Console.WriteLine("Исходный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 5)
            {
                index = i;
                break; 
            }
        }

        if (index != -1)
        {
            Console.WriteLine($"Первый элемент равный 5 найден в позиции: {index}");
        }
        else
        {
            Console.WriteLine("В массиве нет элементов равных 5");
        }
    }
}