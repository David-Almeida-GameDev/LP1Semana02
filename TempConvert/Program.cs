using System;
using System.Data;
using System.Diagnostics;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is the Temperature?"); //Prints "What is the Temperature?"
            Console.ReadLine(); //Asks for the user's input
            Console.WriteLine("Celsius (C) or Fahrenheit (F)?"); //Prints "Celsius (C) or Fahrenheit (F)?"
            Console.ReadLine(); //Asks for the user's input
        }
    }
}
