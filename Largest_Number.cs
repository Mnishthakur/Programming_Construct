namespace Programming_Constructs;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("The largest number is: " + num1);
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("The largest number is: " + num2);
        }
        else
        {
            Console.WriteLine("The largest number is: " + num3);
        }

        Console.ReadLine();
    }
}
