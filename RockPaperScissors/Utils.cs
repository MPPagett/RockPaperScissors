using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
    public static class Utils
    {
        public static IChoice MapChoiceToObject(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    return new Rock();
                case 2:
                    return new Paper();
                case 3:
                    return new Scissors();
                case 4:
                    return new Lizard();
                default:
                    return new Spock();
            }
        }

        public static int GetUserChoice()
        {
            int playerChoice = 0;
            bool isNumber = false;
            while (!isNumber || !(playerChoice > 0 && playerChoice < 6))
            {
                Console.WriteLine("Please make a choice:\n1.Rock \n2.Paper \n3.Scissors \n4.Lizard \n5.Spock");
                string numberOfPlayersAsString = Console.ReadLine();
                isNumber = int.TryParse(numberOfPlayersAsString, out playerChoice);
            }

            return playerChoice;
        }

        public static int GetRandomChoiceAsInt()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }

        public static void PrintChoices(IChoice userChoice, IChoice botChoice)
        {
            Console.WriteLine("Human chooses " + userChoice.GetChoiceAsEnum().ToString());
            Console.WriteLine("Bot chooses " + botChoice.GetChoiceAsEnum().ToString());
        }

        public static void PrintGameSummary(Game game)
        {
            Console.WriteLine("\nGame over!");
            Console.WriteLine($"The {game.GetWinner()} wins!");
            Console.WriteLine($"They won in {game.Turns} turns");
            Console.WriteLine($"The most used choice was {game.GetMostUsedTurn()}");
        }
    }
}
