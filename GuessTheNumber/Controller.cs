using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Controller
    {

        private int targetNumber;

        int guess;
        int attempts = 0;
        bool guessedCorrectly = false;

        private ConsoleView view;
        public Controller(int number)
        {
            targetNumber = number;
        }


        public void Start(ConsoleView view2)
        {

            view = view2;

            view.StartMessage();

            // Game loop
            while (!guessedCorrectly)
            {
                guess = view.TakeAGuess();
                attempts++;

                if (guess == targetNumber)
                {
                    view.WinningMessage(attempts);
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber)
                {
                    view.LowMessage();
                }
                else
                {
                    view.HighMessage();
                }
            }

            view.ThanksForPlaying();
        
        }

    }
}