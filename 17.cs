// 17. Дан одномерный массив целых чисел. Напечатать все элементы, следующие за последним, оканчивающиеся цифрой "7". Если элементов, оканчивающихся цифрой "7", в массиве нет, то ни один элемент не должен быть напечатан.
using System;
public class testseventeen
{
    public static void Main()    
{
        int[] array = { 123, 57, 47, 876, 32, 10 }; 
        bool found = false;      
int lastIndex = array.Length - 1;
        if (array[lastIndex] % 10 == 7) 
        {            Console.WriteLine("Последний элемент массива оканчивается на 7");
            return;
      }
        foreach (var element in array)
        {            
if (element % 10 == 7) 
            {                
found = true;
            }        
}
        if (!found) 
        {            
Console.WriteLine("В массиве нет элементов, оканчивающихся на 7");
            return;        
}
        bool printNext = false;        
foreach (var element in array)
        {           
 if (printNext)
            {                
if (element % 10 != 7) 
                {                    
Console.WriteLine(element);
                }           
 }
            if (element % 10 == 7)            
{
                printNext = true;           
 }
        }  
  }
}