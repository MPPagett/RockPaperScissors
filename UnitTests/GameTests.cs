using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;
using RockPaperScissors.Models;

namespace UnitTests
{
    public class GameTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Game_IncrementTurns_AddsOneToTurnAttribute()
        {
            var expectedTurnIncrease = 1;
            Game game = new Game();

            var turnsBefore = game.Turns;
            game.IncrementTurns();
            var turnsAfter = game.Turns;

            Assert.AreEqual(expectedTurnIncrease, turnsAfter - turnsBefore);
        }

        [Test]
        public void Game_HasWinner_ReturnsTrueWhenHumanHasWon()
        {
            Game game = new Game(1);
            game.HumanPlayer.IncrementScore();

            Assert.True(game.HasWinner());
        }

        [Test]
        public void Game_HasWinner_ReturnsTrueWhenBotHasWon()
        {
            Game game = new Game(1);
            game.BotPlayer.IncrementScore();

            Assert.True(game.HasWinner());
        }

        [Test]
        public void Game_HasWinner_ReturnsFalseWhenNoWinner()
        {
            Game game = new Game(1);

            Assert.False(game.HasWinner());
        }

        [Test]
        public void Game_GetWinner_ReturnsHumanWhenHumanHasWon()
        {
            var expectedWinner = "Human";
            Game game = new Game(1);
            game.HumanPlayer.IncrementScore();

            Assert.AreEqual(expectedWinner, game.GetWinner());
        }

        [Test]
        public void Game_GetWinner_ReturnsBotWhenBotHasWon()
        {
            var expectedWinner = "Bot";
            Game game = new Game(1);
            game.BotPlayer.IncrementScore();

            Assert.AreEqual(expectedWinner, game.GetWinner());
        }
    }
}