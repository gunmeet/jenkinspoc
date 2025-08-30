// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Product.Add(4, 5);


public class Product
{
    public static int Add(int a, int b)
    {
        Console.WriteLine(a + b);
        return a + b;
    }
}