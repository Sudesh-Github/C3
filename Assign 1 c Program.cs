using System;
public class Circle
{
    public static void Main()
    {

        Console.Write("Enter Radius: ");
        double Radius = Convert.ToDouble(Console.ReadLine());
        double Area = Math.PI * Radius * Radius;
        Console.WriteLine("Area of circle: " + Area);
        Console.ReadKey();
        double per_cir = 2 * Math.PI * Radius;
        Console.WriteLine("Circumference of Circle : {0}", per_cir);
        Console.Read();
    }
}
