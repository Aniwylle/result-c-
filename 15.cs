// 15. Дан одномерный массив из четного числа элементов. Поменять местами его первый элемент со вторым, третий с четвертым и т.д.
using System;

class testfefteen
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