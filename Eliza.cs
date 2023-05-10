using System;

namespace ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What would you like to talk about? Enter your response here or Q to quit: ");
        string statement = Console.ReadLine();

        while (statement.ToLower() != "q")
        {
            Console.WriteLine($"Psychologist: {CreateElizaResponse(statement)}");
            Console.Write("Patient: ");
            statement = Console.ReadLine();
            Thread.Sleep(1000);
        }
    }
    static string CreateElizaResponse(string statement)
    {
        if (statement.ToLower().Contains("my"))
        {
            return ("Tell me more about your " + statement.Substring(statement.IndexOf("my") + 3).Trim() + ".");
        }
        else if (statement.ToLower().Contains("love") || statement.ToLower().Contains("hate"))
        {
            return "You have strong feelings about that!";
        }
        else
        {
            string[] responseArray = { "Please go on.", "Tell me more.", "Continue..." };
            Random random = new Random();
            return responseArray[random.Next(0, responseArray.Length)];
        }
    }

}



