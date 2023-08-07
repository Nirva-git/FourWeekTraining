namespace Day2Exe3
{
    internal class Program
    {
        abstract class Animal
        {
            public string Name;
            public int Age;
            public Animal(string name,int age)
            {
                Name = name;
                Age = age;
            }
            public abstract void MakeSound();
        }
        class Dog :Animal, IMovable
        {
            public Dog(int age, string name) : base(name, age)
            {
                
            }
            public override void MakeSound()
            {
                Console.WriteLine("woof!!!!");
            }
            public void Move()
            {
                Console.WriteLine("Dog is moving !!");
            }
        }
        class Cat : Animal, IMovable
        {
            public Cat(int age, string name) : base(name, age)
            {

            }
            public override void MakeSound()
            {
                Console.WriteLine("meow!!!!");
            }
            public void Move()
            {
                Console.WriteLine("Cat is moving !!");
            }
        }
        interface IMovable
        {
            void Move();
        }
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Dog dog = new Dog(15,"Guddy");
            animals.Add(dog);

            Cat cat = new Cat(12,"Sweety");
            animals.Add(cat);

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.Name}");
                Console.WriteLine($"{animal.Age}");
                animal.MakeSound();
                if(animal is IMovable mu)
                {
                    mu.Move();
                }
               
            }
        }
    }
}