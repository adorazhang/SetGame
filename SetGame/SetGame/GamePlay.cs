using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SetGame
{
    public class GamePlay
    {
        private int numCards;
        private int numPlayers;
        private int roundsPlayed;
        private List<Player> players;
        private List<Card> deck;
        private Board board;

        /// <summary>
        /// Constructor for a game
        /// </summary>
        /// <param name="numCards"></param>
        /// <param name="numPlayers"></param>
        public GamePlay(int numCards, int numPlayers)
        {
            this.numCards = numCards;
            this.numPlayers = numPlayers;
        }

        /// <summary>
        /// Initializes the board and scores
        /// </summary>
        public void InitGame()
        {
            this.roundsPlayed = 0;
            this.deck = new List<Card>();
            this.board = new Board();
            this.players = new List<Player>();
            for (int i = 1; i <= numCards; i++)
            {
                deck.Add(new Card(i));
                //Console.WriteLine(deck[i - 1]);
            }
            for (int i = 1; i <= numPlayers; i++)
            {
                players.Add(new Player(i));
                //Console.WriteLine(players[i - 1]);
            }
        }

        /// <summary>
        /// Plays an entire game of set from beginning to end
        /// and returns a list of each valid set removed from the board
        /// </summary>
        public List<Set> Play()
        {
            Console.Clear();
            InitGame();
            DealCards(12);
            Console.WriteLine("== Game Set Up! ==");
            Player currentPlayer = GetNextPlayer();
            List<Set> setsRemoved = new List<Set>();
            while (deck.Count != 0)
            {
                Console.WriteLine("== Round " + (++roundsPlayed) + " ==");
                Set set = board.HasASet();
                if (set != null)
                {
                    currentPlayer.WinsARound();
                    //Console.WriteLine(set);
                    setsRemoved.Add(set);
                }
                else
                {
                    Console.WriteLine("Draws another 3 cards...");
                    if (deck.Count > 0)
                    {
                        DealCards(3);
                    }
                }
                currentPlayer = GetNextPlayer();
            }
            Console.WriteLine("----------------------------------------\nScore Board: ");
            foreach(Player p in players)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("----------------------------------------\nAll Sets:");
            foreach(Set s in setsRemoved)
            {
                Console.WriteLine(s);
            }
            return setsRemoved;
        }

        /// <summary>
        /// Returns next player
        /// (randomly selected, since the game play is simulated by a program)
        /// (in real world, it depends on how fast a player's reaction is)
        /// </summary>
        /// <returns></returns>
        private Player GetNextPlayer()
        {
            Thread.Sleep(20);
            Random random = new Random((int)DateTime.Now.Ticks);
            return players[random.Next(players.Count)];
        }

        /// <summary>
        /// Draws num of cards from the deck
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private void DealCards(int num)
        {
            if (deck.Count < num)
            {
                return;
            }
            while(num != 0)
            {
                board.AddCard(deck[0]);
                deck.RemoveAt(0);
                num--;
            }
        }
    }
}
