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
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();

        string reversedWord = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }

        Console.WriteLine("Reversed word: " + reversedWord);

        Console.ReadLine();
    }
}

