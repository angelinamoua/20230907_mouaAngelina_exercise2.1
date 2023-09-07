using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimeters
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            const double cent = 2.54;
            var inch = 15994;
            Console.WriteLine(inch + " inches is " + cent * inch + " centimeters");
            Console.ReadLine();
        }
    }
}
