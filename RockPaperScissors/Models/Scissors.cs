using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Models
{
    public class Scissors : IChoice
    {
        public Choice GetChoiceAsEnum()
        {
            return Choice.Scissors;
        }

        public bool Beats(IChoice choice)
        {
            return choice is Paper || choice is Lizard;
        }
    }
}
