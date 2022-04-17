using System;
using System.Collections.Generic;

namespace GenericStackDemo
{
    public class Program
    {
        public class MyStack
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Salary { get; set; }
        }
        static void Main(string[] args)
        {
            //Create Employee object
            MyStack emp1 = new MyStack()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 20000
            };
            MyStack emp2 = new MyStack()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 30000
            };
            MyStack emp3 = new MyStack()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 40000
            };
            

            Stack<MyStack> SE = new Stack<MyStack>();

            
            SE.Push(emp1);

            SE.Push(emp2);

            SE.Push(emp3);

       
            Console.WriteLine("Retrive Using Foreach Loop");
            foreach (MyStack emp in SE)
            {
                Console.WriteLine(emp.ID + " - " + emp.Name + " - " + emp.Gender + " - " + emp.Salary);
                Console.WriteLine("Items left in the Stack = " + SE.Count);
            }

            Console.WriteLine("                    ");


            Console.WriteLine("Retrive Using Pop Method");
            MyStack e1 = SE.Pop();
            Console.WriteLine(e1.ID + " - " + e1.Name + " - " + e1.Gender + " - " + e1.Salary);
            Console.WriteLine("Items left in the Stack = " + SE.Count);

            MyStack e2 = SE.Pop();
            Console.WriteLine(e2.ID + " - " + e2.Name + " - " + e2.Gender + " - " + e2.Salary);
            Console.WriteLine("Items left in the Stack = " + SE.Count);

            MyStack e3 = SE.Pop();
            Console.WriteLine(e3.ID + " - " + e3.Name + " - " + e3.Gender + " - " + e3.Salary);
            Console.WriteLine("Items left in the Stack = " + SE.Count);

        }

     /*       // Now there will be no items left in the stack. 
            // So, let's push the five objects once again
            stackEmployees.Push(emp1);
            stackEmployees.Push(emp2);
            stackEmployees.Push(emp3);
            stackEmployees.Push(emp4);
            stackEmployees.Push(emp5);

            // To retrieve an item that is present at the top of the stack, 
            // without removing it, then use the Peek() method.

            Console.WriteLine("Retrive Using Peek Method");
            Employee e105 = stackEmployees.Peek();
            Console.WriteLine(e105.ID + " - " + e105.Name + " - " + e105.Gender + " - " + e105.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);

            Employee e104 = stackEmployees.Peek();
            Console.WriteLine(e104.ID + " - " + e104.Name + " - " + e104.Gender + " - " + e104.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);

            Console.WriteLine("------------------------------");

            // To check if an item exists in the stack, use Contains() method.
            if (stackEmployees.Contains(emp3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }

            Console.ReadKey();
        }
    }*/
    
    }
}
