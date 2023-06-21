using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Models
{
    public class Lizard : IChoice
    {
        public Choice GetChoiceAsEnum()
        {
            return Choice.Lizard;
        }

        public bool Beats(IChoice choice)
        {
            return choice is Paper || choice is Spock;
        }
    }
}
