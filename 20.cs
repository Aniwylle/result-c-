// 20. Дан двумерный массив целых чисел. Определить минимальный номер столбца, состоящего только из элементов, больших числа 10 (считать что такой столбец обязательно есть).
using System;
class testtwenty
{    
static void Main()
    {        
Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());        
Console.Write("Введите количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());
        int[,] array = new int[rows, columns];
                for (int i = 0; i < rows; i++)
        {            
for (int j = 0; j < columns; j++)
            {               
 Console.Write($"Введите значение для элемента [{i}, {j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());           
 }
        }
        int minColumnIndex = -1;       
 bool foundColumn = false;
        for (int j = 0; j < columns; j++)
        {           
 bool allGreaterThan10 = true;
            for (int i = 0; i < rows; i++)           
 {
                if (array[i, j] <= 10)              
  {
                    allGreaterThan10 = false;                 
   break;
                }           
 }
            if (allGreaterThan10)          
  {
                minColumnIndex = j;          
      foundColumn = true;
                break;          
  }
        }
        if (foundColumn)       
 {
            Console.WriteLine($"Минимальный номер столбца, в котором все элементы больше 10: {minColumnIndex}");       
 }
        else
    }
}