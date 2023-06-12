using System.Text;

namespace Programming_Constructs;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the marks obtained in Physics:");
        int physicsMarks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the marks obtained in Chemistry:");
        int chemistryMarks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the marks obtained in Mathematics:");
        int mathsMarks = Convert.ToInt32(Console.ReadLine());

        int totalMarks = physicsMarks + chemistryMarks + mathsMarks;

        if (mathsMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && totalMarks >= 180)
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else if (mathsMarks >= 65 && (physicsMarks >= 55 || chemistryMarks >= 55) && totalMarks >= 140)
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            Console.WriteLine("The candidate is not eligible for admission.");
        }

        Console.ReadLine();
    }
}
