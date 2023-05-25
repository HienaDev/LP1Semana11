using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            // Generate a random number
            Random random = new Random();

            // Generate a number between 1 and 100
            int targetNumber = random.Next(1, 101);

            Controller controller = new Controller(targetNumber);

            ConsoleView view = new ConsoleView(controller);

            controller.Start(view);
        }
    }
}