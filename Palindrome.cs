using System;
using System.Collections.Generic;

namespace ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        //get user input
        Console.Write("Enter a word to check if it is a palindrome: ");
        //save user input to a variable
        string userInput = Console.ReadLine();
        //call isPalindrome method and pass in user input display result
        Console.WriteLine($"Palindrome: {isPalindrome(userInput)}");
    }
    //method to check if a word is a palindrome
    static bool isPalindrome(string word)
    {
        //create a stack and queue
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>();
        //for loop to iterate through each character in the word
        for (int i = 0; i < word.Length; i++)
        {
            //if the character is not a punctuation or whitespace
            if (!Char.IsPunctuation(word[i]) && !Char.IsWhiteSpace(word[i]))
            {
                //push the character to the stack and enqueue the character to the queue
                stack.Push(word[i].ToString().ToLower());
                queue.Enqueue(word[i].ToString().ToLower());
            }
        }
        //for loop to iterate through the stack and queue
        for (int i = 0; i < stack.Count; i++)
        {
            //if the stack and queue are not equal return false
            if (stack.Pop() != queue.Dequeue())
            {
                return false;
            }
        }
        //if the stack and queue are equal return true
        return true;
    }

}
