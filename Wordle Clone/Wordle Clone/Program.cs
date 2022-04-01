using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Wordle_Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"bezel","banjo","equip","chuck", "field", "jokes", "joker", "adieu", "shoes", "water", "irate", "power"};
            Random random = new Random();
            string word = words[random.Next(words.Length)];
            //Console.WriteLine(word);
            game(word);
            Console.ReadKey();
        }
        static void game(string word)
        {
            int guesses = 5;
            bool guessed = false;
            char[] wordArr = word.ToCharArray();
            char[] stringToReturn = {'_','_', '_', '_','_' };
            while(guesses != 0 || !guessed)
            {
                Console.WriteLine("Guess: ");
                string guess = Console.ReadLine();
                char[] guessArr = guess.ToCharArray();
                if(guessArr.Length < 5)
                {
                    Console.WriteLine("Has to be a five letter word! Exiting.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                
                for(int i = 0; i < guessArr.Length; i++)
                {

                    if (guessArr[i] == wordArr[i])
                    {
                        stringToReturn[i] = '*';
                        
                    } else if (wordArr.Contains(guessArr[i]))
                    {
                        stringToReturn[i] = '^';
                        
                    }
                    else
                    {
                        stringToReturn[i] = '_';
                        
                    }
                    
                }
                colouredString(stringToReturn, guessArr);      
                if (guess == word)
                {
                    Console.WriteLine("You got it!");
                    Console.ReadKey();
                    guessed = true;
                }
                guesses--;

            }
        }
        static void colouredString(char[] returnedString, char[] guessArray)
        {
            for(int i = 0; i < returnedString.Length; i++)
            {
                if(returnedString[i] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(guessArray[i]);
                } else if(returnedString[i] == '^')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(guessArray[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(guessArray[i]);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        

        
    }

    
}
