using System;
using System.Diagnostics;

namespace Day5Exe2
{
    public interface IProcessor<in TInput, out TResult>
    {
        TResult Process(TInput input);
    }

    public class StringToIntProcessor : IProcessor<string, int>
    {
        public int Process(string input)
        {
            return input.Length;
        }
    }

    public class DoubleToStringProcessor : IProcessor<double, string>
    {
        public string Process(double input)
        {
            return input.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Covariance example
            IProcessor<string, int> stringToObjectProcessor = new StringToIntProcessor();
            object result1 = stringToObjectProcessor.Process("Hello");
            Console.WriteLine(result1);

            // Contravariance example
            IProcessor<Double, string> objectToStringProcessor = new DoubleToStringProcessor();
            string result2 = objectToStringProcessor.Process(3.14);
            Console.WriteLine(result2);
        }
    }
}
