using System;

namespace Day4Exe1
{
    internal class Program
    {
        public class Stack<T>
        {
            public T[] fields;
            public int top;
            public Stack(int cap)
            {
                fields = new T[cap];
                top = -1;
            }
            public void Push(T x)
            {
                if (top == fields.Length - 1)
                {
                    Console.WriteLine("Stack is full!!!");
                }
                else
                {
                    top++;
                    fields[top] = x;
                }
            }
            public T Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty!!!");
                    return default(T); // Return default value if stack is empty
                }
                else
                {
                    T item = fields[top];
                    top--;
                    return item;
                }
            }
            public bool IsEmpty()
            {
                return top == -1;
            }
        }

        static void Main(string[] args)
        {
            // Test for int datatype:
            Stack<int> intStack = new Stack<int>(3);
            Console.WriteLine("Checking IsEmpty before adding: " + intStack.IsEmpty());
            intStack.Push(25);
            intStack.Push(45);
            intStack.Push(30);
            Console.WriteLine("Top element is: " + intStack.Pop());
            Console.WriteLine("Checking after push: " + intStack.IsEmpty());

            // Test for String datatype:
            Stack<string> stringStack = new Stack<string>(3);
            Console.WriteLine("Checking IsEmpty before adding: " + stringStack.IsEmpty());
            stringStack.Push("Nirva");
            stringStack.Push("new");
            stringStack.Push("Nir");
            Console.WriteLine("Top element is: " + stringStack.Pop());
            Console.WriteLine("Checking after push: " + stringStack.IsEmpty());

            // Test for Custom datatype:
            Stack<Person> personStack = new Stack<Person>(3);
            Console.WriteLine("Checking IsEmpty before adding: " + personStack.IsEmpty());
            personStack.Push(new Person("Nirva", 20));
            personStack.Push(new Person("new", 42));
            personStack.Push(new Person("Nir", 60));
            Console.WriteLine("Top element is: " + personStack.Pop());
            Console.WriteLine("Checking after push: " + personStack.IsEmpty());
        }
        public class Person
        {
            public string Name;
            public int Age;
            public Person(string name, int age)
            {
                this.Age = age;
                this.Name = name;
            }
            public override string ToString()
            {
                return $"Person(Name: {Name}, Age: {Age})";
            }
        }
    }
}
