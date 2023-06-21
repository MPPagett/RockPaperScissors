using RockPaperScissors.Enums;

namespace RockPaperScissors.Models
{
    public class Game
    {
        public Game(int scoreToWin = 4)
        {
            ScoreToWin = scoreToWin;
            Turns = 0;
            HumanPlayer = new Player();
            BotPlayer = new Player();
            ChoiceCounter = new Dictionary<Choice, int>()
            {
                { Choice.Rock, 0 },
                { Choice.Paper, 0 },
                { Choice.Scissors, 0 },
                { Choice.Lizard, 0 },
                { Choice.Spock, 0 }
            };
        }

        public int ScoreToWin { get; set; }
        public int Turns { get; set; }
        public Player HumanPlayer { get; set; }
        public Player BotPlayer { get; set; }
        public Dictionary<Choice, int> ChoiceCounter { get; set; }

        public void IncrementTurns() => Turns++;
        public bool HasWinner() => HumanPlayer.Score == ScoreToWin || BotPlayer.Score == ScoreToWin;
        public string GetWinner() => HumanPlayer.Score == ScoreToWin ? "Human": "Bot";
        public Choice GetMostUsedTurn() => ChoiceCounter.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        public void LogChoice(Choice choice) => ChoiceCounter[choice]++;
        public void PrintScores() => Console.WriteLine($"\nHuman: {HumanPlayer.Score} - {BotPlayer.Score} :Bot\n");
    }
}
