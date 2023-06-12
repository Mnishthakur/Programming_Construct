using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace Programming_Constructs;

class Program
{
    static void Main()
    {
        int number = 1;
        int sum = 0;
        int count = 0;

        while (count < 5)
        {
            sum += number;
            number++;
            count++;
        }

        Console.WriteLine("The sum of the first 5 natural numbers is: " + sum);

        Console.ReadLine();
    }
}

