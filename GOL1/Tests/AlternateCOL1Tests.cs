using NUnit.Framework;

namespace GOL1.Tests
{
    [TestFixture]
    public partial class GOL1Tests
    {
        [TestCase(LiveNeighbors.ZERO)]
        [TestCase(LiveNeighbors.ONE)]
        [TestCase(LiveNeighbors.FOUR)]
        [TestCase(LiveNeighbors.FIVE)]
        [TestCase(LiveNeighbors.SIX)]
        [TestCase(LiveNeighbors.SEVEN)]
        [TestCase(LiveNeighbors.EIGHT)]
        public void Alive_Cell_With_Other_Than_2_or_3_Neighbors_Should_Die(int numNeighbors)
        {
            Assert.AreEqual(State.DEAD, _ruleEngine.GetNextCellState(State.ALIVE, numNeighbors));
        }

        [TestCase(LiveNeighbors.ZERO)]
        [TestCase(LiveNeighbors.ONE)]
        [TestCase(LiveNeighbors.TWO)]
        [TestCase(LiveNeighbors.FOUR)]
        [TestCase(LiveNeighbors.FIVE)]
        [TestCase(LiveNeighbors.SIX)]
        [TestCase(LiveNeighbors.SEVEN)]
        [TestCase(LiveNeighbors.EIGHT)]
        public void Dead_Cell_With_Other_Than_3_Neighbors_Should_Stay_Dead(int numNeighbors)
        {
            Assert.AreEqual(State.DEAD, _ruleEngine.GetNextCellState(State.DEAD, numNeighbors));
        }

        [TestCase(LiveNeighbors.THREE)]
        public void Dead_Cell_With_3_Neighbors_Should_Become_Alive(int numNeighbors)
        {
            Assert.AreEqual(State.ALIVE, _ruleEngine.GetNextCellState(State.DEAD, numNeighbors));
        }

        [TestCase(LiveNeighbors.TWO)]
        [TestCase(LiveNeighbors.THREE)]
        public void Alive_Cell_With_2_or_3_Neighbors_Should_Stay_Alive(int numNeighbors)
        {
            Assert.AreEqual(State.ALIVE, _ruleEngine.GetNextCellState(State.ALIVE, numNeighbors));
        }
    }
}
