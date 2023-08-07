using System;
namespace Day4Exe7
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int[] List = {0,1,2,3,4,5,6,7,8,9}

           
            //to find all the number above 5 in list
           
            var filteredNumber = number.Where(n => n > 5);
            Console.WriteLine("Numbers above {0}:");
            foreach (var i in filteredNumber)
            {
                Console.WriteLine( i);
            }
        }
    } 
}

