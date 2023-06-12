using System.Text;

namespace Programming_Constructs;

class Program
{
    static void Main()
{
    Console.WriteLine("Enter the weekday number (1-7):");
    int weekdayNumber = Convert.ToInt32(Console.ReadLine());

    string weekdayName;

    switch (weekdayNumber)
    {
        case 1:
            weekdayName = "Monday";
            break;
        case 2:
            weekdayName = "Tuesday";
            break;
        case 3:
            weekdayName = "Wednesday";
            break;
        case 4:
            weekdayName = "Thursday";
            break;
        case 5:
            weekdayName = "Friday";
            break;
        case 6:
            weekdayName = "Saturday";
            break;
        case 7:
            weekdayName = "Sunday";
            break;
        default:
            weekdayName = "Invalid weekday number!";
            break;
    }

    Console.WriteLine("The corresponding weekday name is: " + weekdayName);

    Console.ReadLine();
}
}
