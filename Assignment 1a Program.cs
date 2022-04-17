using System;

namespace Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int student1, student2, student3, student4, student5;

            Console.WriteLine("Enter the mark of student1");
            student1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the mark of student2");
            student2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the mark of student3");
            student3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the mark of student4");
            student4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the mark of student5");
            student5 = int.Parse(Console.ReadLine());

            int avg = (student1 + student2 + student3 + student4 + student5) / 5;


            Console.WriteLine("Average of 5 students marks is " + avg);
        }
    }
}


