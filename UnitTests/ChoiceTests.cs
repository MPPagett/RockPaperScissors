using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;
using RockPaperScissors.Models;

namespace UnitTests
{
    public class ChoiceTests
    {
        private Rock rock;
        private Paper paper;
        private Scissors scissors;
        private Lizard lizard;
        private Spock spock;

        [SetUp]
        public void Setup()
        {
            rock = new Rock();
            paper = new Paper();
            scissors = new Scissors();
            lizard = new Lizard();
            spock = new Spock();
        }

        [Test]
        public void Rock_GetChoiceAsEnum_ReturnsCorrectEnum()
        {
            Assert.AreEqual(rock.GetChoiceAsEnum(), Choice.Rock);
        }

        [Test]
        public void Paper_GetChoiceAsEnum_ReturnsCorrectEnum()
        {
            Assert.AreEqual(paper.GetChoiceAsEnum(), Choice.Paper);
        }

        [Test]
        public void Scissors_GetChoiceAsEnum_ReturnsCorrectEnum()
        {
            Assert.AreEqual(scissors.GetChoiceAsEnum(), Choice.Scissors);
        }

        [Test]
        public void Lizard_GetChoiceAsEnum_ReturnsCorrectEnum()
        {
            Assert.AreEqual(lizard.GetChoiceAsEnum(), Choice.Lizard);
        }

        [Test]
        public void Spock_GetChoiceAsEnum_ReturnsCorrectEnum()
        {
            Assert.AreEqual(spock.GetChoiceAsEnum(), Choice.Spock);
        }

        [Test]
        public void Rock_Beats_ReturnsTrueForCorrectChoices()
        {
            Assert.True(rock.Beats(scissors));
            Assert.True(rock.Beats(lizard));
        }

        [Test]
        public void Paper_Beats_ReturnsTrueForCorrectChoices()
        {
            Assert.True(paper.Beats(rock));
            Assert.True(paper.Beats(spock));
        }

        [Test]
        public void Scissors_Beats_ReturnsTrueForCorrectChoices()
        {
            Assert.True(scissors.Beats(paper));
            Assert.True(scissors.Beats(lizard));
        }

        [Test]
        public void Lizard_Beats_ReturnsTrueForCorrectChoices()
        {
            Assert.True(lizard.Beats(spock));
            Assert.True(lizard.Beats(paper));
        }

        [Test]
        public void Spock_Beats_ReturnsTrueForCorrectChoices()
        {
            Assert.True(spock.Beats(scissors));
            Assert.True(spock.Beats(rock));
        }

        [Test]
        public void Rock_Beats_ReturnsFalseForCorrectChoices()
        {
            Assert.False(rock.Beats(rock));
            Assert.False(rock.Beats(paper));
            Assert.False(rock.Beats(spock));
        }

        [Test]
        public void Paper_Beats_ReturnsFalseForCorrectChoices()
        {
            Assert.False(paper.Beats(paper));
            Assert.False(paper.Beats(scissors));
            Assert.False(paper.Beats(lizard));
        }

        [Test]
        public void Scissors_Beats_ReturnsFalseForCorrectChoices()
        {
            Assert.False(scissors.Beats(scissors));
            Assert.False(scissors.Beats(rock));
            Assert.False(scissors.Beats(spock));
        }

        [Test]
        public void Lizard_Beats_ReturnsFalseForCorrectChoices()
        {
            Assert.False(lizard.Beats(lizard));
            Assert.False(lizard.Beats(rock));
            Assert.False(lizard.Beats(scissors));
        }

        [Test]
        public void Spock_Beats_ReturnsFalseForCorrectChoices()
        {
            Assert.False(spock.Beats(spock));
            Assert.False(spock.Beats(paper));
            Assert.False(spock.Beats(lizard));
        }
    }
}