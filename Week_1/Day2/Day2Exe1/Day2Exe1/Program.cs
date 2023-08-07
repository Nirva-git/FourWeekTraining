namespace Day2Exe1
{
    internal class Program
    {
        class Circle
        {
            public double Radius;
            public Circle(double raduis)
            {
                Radius = raduis;
            }
            public double GetArea()
            {
                double area = 3.14 * Math.Pow(Radius, 2); 
                return area;
            }
            public double GetCircumference()
            {
                double circumference = 2 * 3.14 * Radius;
                return circumference;
            }
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle(20);
            double Area=circle.GetArea();
            double Circumference= circle.GetCircumference();
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("Circumference: " + Circumference);
        }
    }
}