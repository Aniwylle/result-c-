// 3. Найти сумму -12 + 22 – 32 + 42 – 5 2 + . . . + 402 .
using System;
public class testtree
{
    public static void Main()    
{
        int sum = 0;        
int a = 2;
        int n = 1;        
for (int i = 0; a<402; i++) 
{ 
            if (n== 1)            
{
                a = a + 10;                
a = a * -1;
                sum = sum + a;                
n = 0;
            }            
if (n == 0)
            {                
a = a * -1;
                a = a + 10;                
sum = sum + a;
                n = 1;            
}
        }        
Console.WriteLine(sum);

    }
}