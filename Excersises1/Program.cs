using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersises1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userChoice = ""; 
            bool answer = false;
            char  [] secretWordTry = new char [7];
            secretWordTry[0] = 'g';
            secretWordTry[1] = 'i';
            secretWordTry[2] = 'r';
            secretWordTry[3] = 'a';
            secretWordTry[4] = 'f';
            secretWordTry[5] = 'f';
            secretWordTry[6] = 'e';


            do
            {
                Console.WriteLine("Do you want to play a game? -Yes or -No?");
                userChoice = Console.ReadLine().ToLower();

                if (userChoice == "yes")
                {

                    //Game Starts Here
                    int playerGuess = 0;
                    String playerLetter = "";
                   
                    String secretWord = "giraffe";
                    String guessWord = "";

                    Console.WriteLine("Guess the secret word. You have 10 tries to guess the word or fail! " +
                        "\n Guess letter by letter.");

                    

                    Console.WriteLine("Word length is shown below.");
                    Console.WriteLine("-------");
                    Console.Write("Enter your first guess: ");

                    do
                    {
                        
                        playerLetter = Console.ReadLine();
                        playerGuess++;
                        char playerLetterChar = char.Parse(playerLetter);
                        bool b = secretWord.Contains(playerLetter);



                        

                        if (b) 
                        {
                            //Console.WriteLine(guessWord +  playerLetter);
                            Console.WriteLine("Du gissade en bokstav rätt");

                            //for (int i = 0; i < 7; i++)
                            //{
                            //    if (playerLetterChar == secretWordTry[i]);
                            //    Console.WriteLine(secretWordTry[i]);
                            //    break;
                            //}
                            

                            for (int i = 0; i < 1; i++ )
                            {
                                
                                
                                Console.WriteLine(guessWord + playerLetter);
                                guessWord = guessWord + playerLetter;

                            }
                        }   
                        else if (b != true)
                        {
                            Console.WriteLine("Du gissade fel");
                        }

                        
                        

                    } while (playerGuess <= 10);
                    Console.WriteLine("You Lose!");

                    




                }
                else if (userChoice != "no" || userChoice != "yes")
                {
                    Console.WriteLine("Wrong input. Try again.");
                }
                else
                {
                    Console.WriteLine("Exiting");
                    break;
                }


            } while (answer != true);
        }
    }
}
