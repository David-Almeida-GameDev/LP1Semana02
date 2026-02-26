using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Reflection.PortableExecutable;
using System.Reflection;
using System.Reflection.Emit;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Temperature: ");
            string Temperature1 = Console.ReadLine();
            double Temperature2 = Convert.ToDouble(Temperature1);

            Console.Write("Unit (C/F): ");
            string Mode = Console.ReadLine();

            double Calculate1 = Temperature2;
            double Calculate2 = Temperature2;

            double Result1 = Calculate1 * 1.8 + 32;
            double Absolute1 = Math.Abs(Result1);

            double Result2 = (Calculate2 - 32) / 1.8;
            double Absolute2 = Math.Abs(Result2);


            switch (Mode)
            {
                case "C":
                    Console.WriteLine($"{Calculate1:f2} C = {Result1:f2} F");
                    Console.WriteLine($"Absolute value: {Absolute1:f2}");
                    break;

                case "F":
                    Console.WriteLine($"{Calculate2:f2} F = {Result2:f2} C");
                    Console.WriteLine($"Absolute value: {Absolute2:f2}");
                    break;

                default:
                    Console.WriteLine("Invalid unit.");
                    break;
            }
        }
    }
}
