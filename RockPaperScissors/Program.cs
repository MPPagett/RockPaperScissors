using RockPaperScissors;
using RockPaperScissors.Models;

Game game = new Game();

while (!game.HasWinner())
{
    game.PrintScores();
    game.IncrementTurns();

    var userChoice = Utils.MapChoiceToObject(Utils.GetUserChoice());
    var botChoice = Utils.MapChoiceToObject(Utils.GetRandomChoiceAsInt());

    Utils.PrintChoices(userChoice, botChoice);

    game.LogChoice(userChoice.GetChoiceAsEnum());
    game.LogChoice(botChoice.GetChoiceAsEnum());

    if (userChoice.GetType() == botChoice.GetType())
    {
        Console.WriteLine(Constants.Messages.Draw);
        continue;
    }

    if (userChoice.Beats(botChoice))
    {
        game.HumanPlayer.IncrementScore();
        Console.WriteLine(Constants.Messages.HumanWin);
        continue;
    }

    game.BotPlayer.IncrementScore();
    Console.WriteLine(Constants.Messages.BotWin);
}

Utils.PrintGameSummary(game);