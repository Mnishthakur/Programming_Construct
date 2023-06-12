class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are eligible to cast your vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to cast your vote.");
        }

        Console.ReadLine();
    }
}
