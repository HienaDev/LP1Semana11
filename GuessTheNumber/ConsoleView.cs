using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class ConsoleView
    {


        private Controller controller;

        public ConsoleView(Controller controller)
        {
            this.controller = controller;
        }

        public int TakeAGuess()
        {
            Console.Write("Take a guess: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        public void WinningMessage(int attempts)
        {
            Console.WriteLine(
                        "Congratulations! You guessed the number correctly!");
                    Console.WriteLine("Number of attempts: " + attempts);
        }

        public void StartMessage()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }
        public void LowMessage() => Console.WriteLine("Too low! Try again.");

        public void HighMessage() => Console.WriteLine("Too high! Try again.");

        public void ThanksForPlaying() 
        => Console.WriteLine("Thank you for playing Guess the Number!");


    }
}