// 19. Дан двумерный массив целых чисел. В каждой его строке найти сумму отрицательных элементов.
using System;
class testninent
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
        for (int i = 0; i < rows; i++)
        {            
int sumOfNegatives = 0;
            for (int j = 0; j < columns; j++)           
 {
                if (array[i, j] < 0)       
         {
                    sumOfNegatives += array[i, j];      
          }
            }            Console.WriteLine($"Сумма отрицательных элементов в строке {i}: {sumOfNegatives}");
        }  
  }
}