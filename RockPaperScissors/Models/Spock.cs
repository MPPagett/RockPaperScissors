using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Models
{
    public class Spock : IChoice
    {
        public Choice GetChoiceAsEnum()
        {
            return Choice.Spock;
        }

        public bool Beats(IChoice choice)
        {
            return choice is Scissors || choice is Rock;
        }
    }
}
