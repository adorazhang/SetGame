namespace SetGame
{
    public class Player
    {
        private readonly int playerNum;
        private int setsWon;
        public string name
        {
            get
            {
                return "Player #" + playerNum;
            }
        }

        public Player(int playerNum)
        {
            this.playerNum = playerNum;
            setsWon = 0;
        }

        public void WinsARound()
        {
            setsWon++;
        }

        public override string ToString()
        {
            return "Player #" + playerNum + ": " + setsWon;
        }
    }
}
