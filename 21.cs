// 21. Дан двумерный массив. Найти строку с максимальной суммой элементов.
using System;
class testtwentyonepilots
{    
static void Main()
    {       
int[,] array = 
{
            {1, 2, 3},           
            {4, 5, 6},
            {7, 8, 9}        
};
        int maxSum = int.MinValue;
        int maxSumR = -1;
        for (int i = 0; i < array.GetLength(0); i++)        
{
            int rowSum = 0;            
for (int j = 0; j < array.GetLength(1); j++)
            {                
rowSum += array[i, j];
            }            
if (rowSum > maxSum)
            {               
 maxSum = rowSum;
                maxSumR = i;           
 }
        }
        Console.WriteLine($"Строка с максимальной суммой элементов находится в  {maxSumR} ряду.");   
 }
}
