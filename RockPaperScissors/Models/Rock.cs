using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Models
{
    public class Rock : IChoice
    {
        public Choice GetChoiceAsEnum()
        {
            return Choice.Rock;
        }
        public bool Beats(IChoice choice)
        {
            return choice is Scissors || choice is Lizard;
        }
    }
}
