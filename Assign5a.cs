using System;

class SystemArray
{
    public static void Main()
    {
        int[] a = new int[5];
        int[] b = new int[5];

        Console.WriteLine("Enter number of elements you want to hold in the array (max5)?");
        string s = Console.ReadLine();
        int x = Int32.Parse(s);
        string v = Console.ReadLine();
        int y = Int32.Parse(v);
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("\n Enter array elements \n");
        Console.WriteLine("--------------------------------------------------");

        for (int i = 0; i < x; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = Int32.Parse(s1);
        }

        Array.Sort(a);
        Console.WriteLine("--------------Sorted-------------------------");
        for (int i = 0; i < x; i++)
        {

            Console.WriteLine($"Element {i + 1} is {a[i]}");
        }

        Array.Copy(a, 0, b, 0, 5);
        Console.WriteLine("-----------Copied-------------------------------");
        Console.WriteLine("----------------------------------------------");
       // for (int i = 0; i < x; i++)
        {
            for(int j = 0; j < y; j++)
            {
                Console.WriteLine($"Element {j + 1} in b is {b[j]}");
            }
        }

        // Reverse the values of the Array.  
        Array.Reverse(a);
        Console.WriteLine("-----------Reversed-------------------------------");
        Console.WriteLine("----------------------------------------------");
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine($"Element {i + 1} is {a[i]}");
        }

        Console.WriteLine("Array Before Operation:");

        // calling the PrintIndexAndValues() method 
        PrintIndexAndValues(a);
        Console.WriteLine();

        Array.Clear(a, 1, 1);

        // Display the values of myArr
        Console.WriteLine("Array After Operation:");

        // calling the PrintIndexAndValues() method
        PrintIndexAndValues(a);
    }
    public static void PrintIndexAndValues(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("{0}", a[i]);
        }

        Console.ReadKey();
    }
  
}