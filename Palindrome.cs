using System;
using System.Collections.Generic;

namespace ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a word to check if it is a palindrome: ");
        string userInput = Console.ReadLine();
        Console.WriteLine($"Palindrome: {isPalindrome(userInput)}");
    }
    
    static bool isPalindrome(string word)
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>();
        
        for (int i = 0; i < word.Length; i++)
        {
            if (!Char.IsPunctuation(word[i]) && !Char.IsWhiteSpace(word[i]))
            {
                stack.Push(word[i].ToString().ToLower());
                queue.Enqueue(word[i].ToString().ToLower());
            }
        }
        
        for (int i = 0; i < stack.Count; i++)
        {
            if (stack.Pop() != queue.Dequeue())
            {
                return false;
            }
        }
        
        return true;
    }

}


