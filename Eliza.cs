using System;

namespace ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        //ask for user input
        Console.Write("What would you like to talk about? Enter your response here or Q to quit: ");
        //store user input in a variable
        string statement = Console.ReadLine();
        //create a loop that will continue to ask for user input until they enter Q
        while (statement.ToLower() != "q")
        {
            //print out the response
            Console.WriteLine($"Psychologist: {CreateElizaResponse(statement)}");
            //ask for user input
            Console.Write("Patient: ");
            //store user input in a variable
            statement = Console.ReadLine();
            //pause for 1 second
        }
    }
    //create a method that will return a response based on the user input
    static string CreateElizaResponse(string statement)
    {
        //if the user input contains the word "my" then return the following response
        if (statement.ToLower().Contains("my"))
        {
            return ("Tell me more about your " + statement.Substring(statement.IndexOf("my") + 3).Trim() + ".");
        }
        //else if the user input contains "love or "hate" then return the following response
        else if (statement.ToLower().Contains("love") || statement.ToLower().Contains("hate"))
        {
            return "You have strong feelings about that!";
        }
        //else return one of three random responses
        else
        {
            //create an array of responses
            string[] responseArray = { "Please go on.", "Tell me more.", "Continue..." };
            //create a random number generator
            Random random = new Random();
            //return a random response from the array
            return responseArray[random.Next(0, responseArray.Length)];
        }
    }

}



