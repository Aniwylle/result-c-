// 10. Даны стороны двух треугольников. Найти сумму их площадей.
using System;
class testten
{    static void Main()
    {        
Console.WriteLine("Введите длины сторон первого треугольника:");
        double a1 = Convert.ToDouble(Console.ReadLine());        
double b1 = Convert.ToDouble(Console.ReadLine());
        double c1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите длины сторон второго треугольника:");        
double a2 = Convert.ToDouble(Console.ReadLine());
        double b2 = Convert.ToDouble(Console.ReadLine());        
double c2 = Convert.ToDouble(Console.ReadLine());
        double area1 = CalculateArea(a1, b1, c1);
        double area2 = CalculateArea(a2, b2, c2);
        double totalArea = area1 + area2;
        Console.WriteLine($"Сумма площадей двух треугольников: {totalArea}");   
 }
    static double CalculateArea(double a, double b, double c)
    {        
double p = (a + b + c) / 2; 
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));       
return area;
    }
}