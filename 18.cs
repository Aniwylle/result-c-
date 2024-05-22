// 18. Дан двумерный массив размером n на n, заполненный целыми числами. Все его отрицательные элементы записать в первый одномерный массив, все его четные элементы - во второй, а нечетные - в третий.
using System;
class testeigtn
{    static void Main()
    {        
Console.Write("Введите размер n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];        
int[] negatives = new int[n * n]; 
        int[] evens = new int[n * n];
int[] odds = new int[n * n];
        int negIndex = 0;        
int evenIndex = 0;
        int oddIndex = 0;    
for (int i = 0; i < n; i++)
        {            
for (int j = 0; j < n; j++)
            {                
Console.Write($"Введите значение для элемента [{i}, {j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
                if (array[i, j] < 0)
                {                    
negatives[negIndex] = array[i, j];
                    negIndex++;                
}
                else if (array[i, j] % 2 == 0)               
 {
                    evens[evenIndex] = array[i, j];                    
evenIndex++;
                }
                else               
 {
                    odds[oddIndex] = array[i, j];                   
 oddIndex++;
                }            
}
        }       
Console.WriteLine("Отрицательные элементы:");
        for (int k = 0; k < negIndex; k++)       
 {
            Console.Write(negatives[k] + " ");        
}
        Console.WriteLine();
        Console.WriteLine("Четные элементы:");        
for (int k = 0; k < evenIndex; k++)
        {            
Console.Write(evens[k] + " ");
        }        
Console.WriteLine();

        Console.WriteLine("Нечетные элементы:");        
for (int k = 0; k < oddIndex; k++)
        {            
Console.Write(odds[k] + " ");
        }        
Console.WriteLine();
    }
}