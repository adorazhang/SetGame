using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGame
{
    /// <summary>
    /// This is a set game developed by Adora Zhang.
    /// Pardon her for no GUI due to time constraint.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The command line interface that does not check user input
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This is a simple set game developed by Adora Zhang.\n");

            string operation;
            while(true)
            {
                Console.Write("Play a game? [y/N]: ");
                operation = Console.ReadLine();
                if (operation == "Y" || operation == "y")
                {
                    Console.Write("Please enter n for the number of cards (12 + 3*n): ");
                    int numCards = 12 + 3 * Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter number of players: ");
                    int numPlayers = Convert.ToInt32(Console.ReadLine());
                    GamePlay game = new GamePlay(numCards, numPlayers);
                    List<Set> setsRemoved = game.Play();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
