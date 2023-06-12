namespace Programming_Constructs;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2)
        {
            Console.WriteLine("The two integers are equal.");
        }
        else
        {
            Console.WriteLine("The two integers are not equal.");
        }

        Console.ReadLine();
    }
}
