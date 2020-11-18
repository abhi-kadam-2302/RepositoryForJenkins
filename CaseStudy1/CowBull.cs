using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaseStudy1
{
    class CowBull
    {
        public static string GuessWord;
        public static char[] Buffer;
        public static char[] GuessWordArray;
        public char Guess;
        public int Attempts = 10, Cows = 0, Bulls = 0, Pos = 0;
        public bool flag = true;

        void Input()
        {
            Console.WriteLine("******************* PLAYER 1 *******************");
            Console.Write("Enter a word for Player 2 to guess : ");
            GuessWord = Console.ReadLine();
            Buffer = new char[GuessWord.Length];
            GuessWordArray = GuessWord.ToCharArray();
            Console.WriteLine();
            Console.WriteLine("******************* PLAYER 2 *******************");
            Console.WriteLine("Player 2 gets 10 Attempts to guess {0} lettered word !", GuessWord.Length);
            Console.WriteLine();
        }

        void Calculation()
        {
            while (flag)
            {
                Console.WriteLine();
                Console.Write("PLayer 2 enter a guess : ");
                Guess = Convert.ToChar(Console.ReadLine());
                Attempts--;
                if (GuessWord.Contains(Guess))
                {
                    Bulls++;
                    Buffer[Pos++] = Guess;
                    if (GuessWordArray.SequenceEqual(Buffer))
                    {
                        Console.WriteLine("Congratulations ! You guessed the word '{0}' !", GuessWord);
                        Console.WriteLine("Player 2 Wins !");
                        flag = false;
                    }
                    else
                        Console.WriteLine("You have guessed a correct letter ! {0} Attempts remaining !", Attempts);
                }
                else
                {
                    Cows++;
                    Console.WriteLine("OOPS ! Incorrect Guess ! Guess Again ! {0} Attempts remaining !", Attempts);
                    if (Attempts == 0)
                        flag = false;
                }
                Console.WriteLine();
            }
        }

        void Display()
        {
            if (Attempts == 0 && Bulls != GuessWord.Length)
                Console.WriteLine("Player 1 Wins !");
            Console.WriteLine();
            Console.WriteLine("Cows : {0}, Bulls : {1}", Cows, Bulls);
        }

        static void Main()
        {
            CowBull cowBull = new CowBull();
            cowBull.Input();
            cowBull.Calculation();
            cowBull.Display();        

            Console.ReadLine();
        }
    }
}
