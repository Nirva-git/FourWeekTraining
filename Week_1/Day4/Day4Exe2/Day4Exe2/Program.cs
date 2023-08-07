using System;
using System.Collections;

namespace Day4Exe2
{
    internal class Program
    {
        public class Fibonacci : IEnumerable
        {
            public int Count;

            public Fibonacci(int count)
            {
                Count = count;
            }

            public IEnumerator GetEnumerator()
            {
                int current = 0;
                int next = 1;

                for (int x = 0; x < Count; x++)
                {
                    yield return current;

                    int temp = next;
                    next = current;
                    current = temp + current;
                }
            }
        }

        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci(10);
            foreach (var i in fibonacci)
            {
                Console.WriteLine(i);
            }
        }
    }
}
