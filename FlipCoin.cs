using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Programming_Constructs;

class Program
{
    static void Main()
{
    int headsCount = 0;
    int tailsCount = 0;
    int totalFlips = 0;

    Random random = new Random();

    while (headsCount < 20 && tailsCount < 20)
    {
        int result = random.Next(2); // Generate a random number: 0 or 1

        if (result == 0)
        {
            Console.WriteLine("Heads");
            headsCount++;
        }
        else
        {
            Console.WriteLine("Tails");
            tailsCount++;
        }

        totalFlips++;
    }

    if (headsCount == 20)
    {
        Console.WriteLine("Heads wins!");
    }
    else
    {
        Console.WriteLine("Tails wins!");
    }

    Console.WriteLine("Total flips: " + totalFlips);
    Console.ReadLine();
}
}
