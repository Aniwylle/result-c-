// 2. Даны 3 натуральных числа. Определить, у какого из них среднее арифметическое цифр больше
using System;
class testtwel
{
    static void Main()    
{
        Console.WriteLine("Введите три натуральных числа:");        
int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());        
int n3 = Convert.ToInt32(Console.ReadLine());
        double averageDigits1 = CalculateAverageDigits(n1);
        double averageDigits2 = CalculateAverageDigits(n2);        
double averageDigits3 = CalculateAverageDigits(n3);
        if (averageDigits1 > averageDigits2 && averageDigits1 > averageDigits3)
        {            
Console.WriteLine($"Среднее арифметическое цифр в числе {n1} больше чем в числах {n2} и {n3}");
        }        
else if (averageDigits2 > averageDigits1 && averageDigits2 > averageDigits3)
        {            
Console.WriteLine($"Среднее арифметическое цифр в числе {n2} больше чем в числах {n1} и {n3}");
        }        
else if (averageDigits3 > averageDigits1 && averageDigits3 > averageDigits2)
        {            
Console.WriteLine($"Среднее арифметическое цифр в числе {n3} больше чем в числах {n1} и {n2}");
        }        
else
        {            
Console.WriteLine("У чисел средние арифметические цифры совпадают");
        }    
}
    static double CalculateAverageDigits(int n)
    {        
int sumOfDigits = 0;
        int countOfDigits = 0;        
int tempN = n;
        while (tempN > 0)
        {            
sumOfDigits += tempN % 10;
            countOfDigits++;            
tempN /= 10;
        }
        return (double)sumOfDigits / countOfDigits;   
 }
}