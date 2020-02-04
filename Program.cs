using System;
using System.Collections;
using System.Collections.Generic;

namespace StacksAndStringReversals
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord;


            Console.WriteLine("\n WELCOME!!! to word-to-stack-to-REVERS-O-RAMA!!!!!");
            do
            {
                Console.WriteLine("\nPLEASE  E.N.T.E.R  A WOOOOOORD!!!! \n(or press Enter to exit.)");
                inputWord = Console.ReadLine();

                if (!inputWord.Contains(" "))
                {
                    Console.WriteLine(StringToStackToReverseString(inputWord));
                }
                else
                {
                    Console.WriteLine(SentenceToStackToReverseString(inputWord));
                }
            }
            while (!string.IsNullOrEmpty(inputWord));
            {
                Console.WriteLine("Later. Skater.");
                Console.ReadLine();
            }
        }

        static string StringToStackToReverseString(string inputWord)
        {
            Stack<char> charStack = new Stack<char>();
            string reversed = null;
            char[] wordToCharArray = inputWord.ToCharArray();

            foreach (char c in wordToCharArray)
            {
                charStack.Push(c);
            }

            while (charStack.Count > 0)
            {
                reversed += charStack.Pop();
            }
            return reversed;
        }

        static string SentenceToStackToReverseString(string inputWord)
        {
            string sentence = "";
            string[] sentenceArray = inputWord.Split(" ");
            foreach (string word in sentenceArray)
            {
                sentence += StringToStackToReverseString(word) + " ";
            }
            return sentence;
        }
    }
}


