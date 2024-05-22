// 11. Вычислить значение выражения (2*5!+3*8!)/(6!+4!), используя функцию для вычисления n!
using System;
class testelev
{
    static int Factorial(int n)    
{
        if (n == 0)        
{
            return 1;        
}
        else        
{
            return n * Factorial(n - 1);        
}
    }
    static void Main()    
{
        int result = (2 * Factorial(5) + 3 * Factorial(8)) / (Factorial(6) + Factorial(4));        
Console.WriteLine($"Результат : {result}");
    }
}