namespace RockPaperScissors.Models
{
    public class Player
    {
        public Player()
        {
            Score = 0;
        }

        public int Score { get; set; }

        public void IncrementScore() => Score++;
    }
}
