using RockPaperScissors;
using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;
using RockPaperScissors.Models;

namespace UnitTests
{
    public class UtilTests
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
        public void Util_MapChoiceToRockObject_ReturnsExpectedObject()
        {
            var choiceObject = Utils.MapChoiceToObject((int)Choice.Rock);

            Assert.AreEqual(rock.GetType(), choiceObject.GetType());
        }

        [Test]
        public void Util_MapChoiceToPaperObject_ReturnsExpectedObject()
        {
            var choiceObject = Utils.MapChoiceToObject((int)Choice.Paper);

            Assert.AreEqual(paper.GetType(), choiceObject.GetType());
        }

        [Test]
        public void Util_MapChoiceToScissorsObject_ReturnsExpectedObject()
        {
            var choiceObject = Utils.MapChoiceToObject((int)Choice.Scissors);

            Assert.AreEqual(scissors.GetType(), choiceObject.GetType());
        }

        [Test]
        public void Util_MapChoiceToLizardObject_ReturnsExpectedObject()
        {
            var choiceObject = Utils.MapChoiceToObject((int)Choice.Lizard);

            Assert.AreEqual(lizard.GetType(), choiceObject.GetType());
        }

        [Test]
        public void Util_MapChoiceToSpockObject_ReturnsExpectedObject()
        {
            var choiceObject = Utils.MapChoiceToObject((int)Choice.Spock);

            Assert.AreEqual(spock.GetType(), choiceObject.GetType());
        }
    }
}