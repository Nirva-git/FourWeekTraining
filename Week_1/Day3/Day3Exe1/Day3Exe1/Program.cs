
namespace Day3Exe1
{
    internal class Program
    {
        public static long Factorial(int x)
        {
            int fact = 1;
            while (x > 0)
            {
                fact *= x;
                x--;
            }
            return fact;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please enter the Number you want to do factorial!");
            int number = int.Parse(Console.ReadLine());
            long Answer = Factorial(number);
            Console.WriteLine(Answer);
        }
    }
}