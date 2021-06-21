/*
 *  C# Program to Create a HangMan Game
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Program
    {

     
static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hangman!!!!!!!!!!");
            Console.WriteLine();
            string[] listwords = new string[10];
            listwords[0] = "sweden";
            listwords[1] = "baghdad";
            listwords[2] = "computer";
            listwords[3] = "germany";
            listwords[4] = "stattminster";
            listwords[5] = "vienna";
            listwords[6] = "jasmine";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "apple";

            int y = 0;
            Console.Write("Please enter your guess: ");
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder("", 10);
            int maxWord = 3;

            do  
            {

                int score = 0;
                bool right = false;

                Random randGen = new Random();
                var idx = randGen.Next(0, 9);
                string mysteryWord = listwords[idx];
                char[] guess = new char[mysteryWord.Length];
                
                for (int p = 0; p < mysteryWord.Length; p++)
                {
                    guess[p] = '-';
                }
                Console.WriteLine();
                int i = 0;
                int inputLength = input.Length;
                if (inputLength == 1)
                 {
                    char playerGuess = char.Parse(input);
                    int counter = 0;
                    do   // 10 times guess allowed
                    {
                        for (int j = 0; j < mysteryWord.Length; j++)
                        {
                            if (playerGuess == mysteryWord[j])
                            {
                                guess[j] = playerGuess;
                                right = true;
                                counter++;
                                if (counter == mysteryWord.Length)
                                {
                                    i = 100;
                                    Console.WriteLine();
                                    Console.WriteLine("perfect");
                                   // endOfWord = false;
                                }

                            }
                        }

                        if (right != true)
                        {
                            Console.WriteLine("Your guess is incorrect.");
                            Console.WriteLine();
                            Boolean result = sb.ToString().Contains(input);
                                 if (result == true)
                                     {
                                          
                                     }
                            else
                                     {
                                        sb.Append(input);
                                        score = score + 1;
                                     }
                        }
                        else
                        {
                            right = false;
                        }
                        i++;
                        Console.WriteLine();
                        Console.WriteLine(guess);
                        Console.WriteLine();

                        Console.WriteLine("Your score is " + score);
                        Console.WriteLine();
                        if (i <= mysteryWord.Length)
                        {
                            Console.Write("Please enter your guess: ");
                            input = Console.ReadLine();
                        }
                       
                       
                        inputLength = input.Length;
                        if (inputLength == 1)
                        {
                             playerGuess = char.Parse(input);
                        }
                        else
                        {
                            if (input == mysteryWord)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" ************ well done very good guesses  ");
                                Console.WriteLine("Your score is " + score);
                                i = 100;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine(" you have guessed wrong word");
                                score = score + 1;
                                Console.WriteLine("Your score is " + score);
                            }
                        }
                        
                    } while (i < 10);
                }
             
                y++;

                if (y < 3)
                {
                    sb.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" ****************next mystery word**************");
                    Console.WriteLine();
                    Console.Write("Please enter your guess: ");
                    input = Console.ReadLine();
                }

            } while (y <= maxWord);
            Console.WriteLine(" click Enter to exit");
            Console.ReadLine();
            Console.WriteLine();
            
        }
    }
}
