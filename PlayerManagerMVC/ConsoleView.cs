using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class ConsoleView
    {
        
        Controller Controller { get; private set; }
        Player<List> PlayerList { get; private set; }

        public ConsoleView(Controller controller, Player<List> playerList)
        {
            Controller = controller;
            PlayerList = playerList;
        }
            
        public void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Quit\n");
            Console.Write("Your choice > ");
        }

        public void AskPlayerName()
        {
            Console.WriteLine("\nInsert player");
            Console.WriteLine("-------------\n");
            Console.Write("Name: ");
        }
    }
}