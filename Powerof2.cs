using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Programming_Constructs;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the value of n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Powers of 2 that are less than or equal to 2^n:");

        for (int i = 0; i <= n; i++)
        {
            double power = Math.Pow(2, i);
            Console.WriteLine("2^" + i + " = " + power);
        }

        Console.ReadLine();
    }
}
