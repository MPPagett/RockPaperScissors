using RockPaperScissors.Enums;

namespace RockPaperScissors.Interfaces
{
    public interface IChoice
    {
        public Choice GetChoiceAsEnum();
        bool Beats(IChoice choice);
    }
}
