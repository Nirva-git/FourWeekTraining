using System.Diagnostics.CodeAnalysis;

namespace HelloWorld
{
    internal class Program
    {
        static int sum(int a, int b)
        {
            int Sum = a + b;
            return Sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("enter the 1st value:");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("enter the 2nd value:");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("sum of two numbers is : {0}", sum(num1, num2));
        }
        
    }
}