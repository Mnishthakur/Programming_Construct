using System.Text;

namespace Programming_Constructs;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select the arithmetic operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int choice = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("The addition of the two numbers is: " + result);
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine("The subtraction of the two numbers is: " + result);
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine("The multiplication of the two numbers is: " + result);
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("The division of the two numbers is: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        Console.ReadLine();
    }
}
