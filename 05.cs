// 5. Дано натуральное число n . Вычислить: P = 2 × 4 × 6 × . . . × (2n)
public class testfive
{
    public static void Main()   
 {
        int n = 3; 
        long product = CalculateProduct(n);
        Console.WriteLine($"P = {product}");    
}

    public static long CalculateProduct(int n)    
{
        long product = 1;        
for (int i = 1; i <= n; i++)
        {            
product *= 2 * i;
        }       
 return product;
    }
}