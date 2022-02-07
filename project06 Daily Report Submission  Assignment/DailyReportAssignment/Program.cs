using System;
class Program
{
    static void Main()
    {
        Console.Write("The Tech Academy");
        Console.ReadLine();
        Console.Write("Student Daily Report");
        Console.ReadLine();
        Console.Write("what is your name? ");
        string yourName = Console.ReadLine();
        Console.Write("what course are you on? ");
        string yourCourse = Console.ReadLine();
        Console.Write("what page number are you on? only numbers please. ");
        string yourPageNumber = Console.ReadLine();
        int yourPageNumberInt = Convert.ToInt32(yourPageNumber);
        Console.Write("Do you need help with anything? Please answer \"true\" or \"false\". ");
        string helpNeeded = Console.ReadLine();
        bool helpNeededBool = Convert.ToBoolean(helpNeeded);
        Console.Write("Were there any positive experiences you'd like to share? Please give specifics. ");
        string yourExperiences = Console.ReadLine();
        Console.Write("Is there any other feedback you'd like to provide? Please be specific. ");
        string yourFeedback = Console.ReadLine();
        Console.Write("How many hours did you study, please write only numbers. ");
        string yourHoursStudied = Console.ReadLine();
        int yourHoursStudiedInt = Convert.ToInt32(yourHoursStudied);
        Console.Write("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}


