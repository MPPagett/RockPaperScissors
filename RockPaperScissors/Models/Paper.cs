using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Models
{
    public class Paper : IChoice
    {
        public Choice GetChoiceAsEnum()
        {
            return Choice.Paper;
        }

        public bool Beats(IChoice choice)
        {
            return choice is Rock || choice is Spock;
        }
    }
}
