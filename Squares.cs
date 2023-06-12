using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Programming_Constructs;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the value of N:");
        int N = Convert.ToInt32(Console.ReadLine());

        int sumOfSquares = 0;

        for (int i = 1; i <= N; i++)
        {
            int square = i * i;
            sumOfSquares += square;
        }

        Console.WriteLine("The sum of squares of N numbers starting from 1 is: " + sumOfSquares);

        Console.ReadLine();
    }
}
