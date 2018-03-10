using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
	//readin from console

            double result = width * height;
	//calculating
            Console.WriteLine($"{result:F2}");
            Console.ReadLine();
	//printing
        }
    }
 }
