﻿using NUnit.Framework;

namespace GOL1.Tests
{
    [TestFixture]
    public partial class GOL1Tests
    {
#region setup
        RuleEngine _ruleEngine;
        [SetUp]
        public void Setup()
        {
            _ruleEngine = new RuleEngine();
        }
#endregion
        //[TestCase(State.ALIVE, 0, Result = State.DEAD)]
        //[TestCase(State.ALIVE, 1, Result = State.DEAD)]
        //[TestCase(State.ALIVE, 4, Result = State.DEAD)]
        //[TestCase(State.ALIVE, 5, Result = State.DEAD)]
        //[TestCase(State.ALIVE, 6, Result = State.DEAD)]
        //[TestCase(State.ALIVE, 7, Result = State.DEAD)]
        //[TestCase(State.ALIVE, 8, Result = State.DEAD)]
        //public State z_BONUS__Alive_Cell_With_Other_Than_2_or_3_Neighbors_Should_Die(State initialState, int numNeighbors)
        //{

        //    return _ruleEngine.GetNextCellState(initialState, numNeighbors);
        //}

        //[TestCase(State.DEAD, 0, Result = State.DEAD)]
        //[TestCase(State.DEAD, 1, Result = State.DEAD)]
        //[TestCase(State.DEAD, 2, Result = State.DEAD)]
        //[TestCase(State.DEAD, 4, Result = State.DEAD)]
        //[TestCase(State.DEAD, 5, Result = State.DEAD)]
        //[TestCase(State.DEAD, 6, Result = State.DEAD)]
        //[TestCase(State.DEAD, 7, Result = State.DEAD)]
        //[TestCase(State.DEAD, 8, Result = State.DEAD)]
        //public State z_BONUS__Dead_Cell_With_Other_Than_2_or_3_Neighbors_Should_Die(State initialState, int numNeighbors)
        //{
        //    return _ruleEngine.GetNextCellState(initialState, numNeighbors);
        //}
        //[TestCase(State.DEAD, 3, Result = State.ALIVE)]
        //public State z_BONUS__Dead_Cell_With_3_Neighbors_Should_Become_Alive(State initialState, int numNeighbors)
        //{
        //    return _ruleEngine.GetNextCellState(initialState, numNeighbors);
        //}


        [TestCase(LiveNeighbors.ZERO)]
        [TestCase(LiveNeighbors.ONE)]
        public void Rule_1__Alive_Cell_With_0_or_1_Neighbors_Should_Die(int numNeighbors)
        {
            Assert.AreEqual(State.DEAD, _ruleEngine.GetNextCellState(State.ALIVE, numNeighbors));
        }

        // As I imagined it:
        //[TestCase(State.ALIVE, 2, Result = State.ALIVE)]
        //[TestCase(State.ALIVE, 3, Result = State.ALIVE)]
        //public State Rule_2_Alive_Cell_With_2_or_3_Neighbors_Should_Be_Alive(State initialState, int numNeighbors)
        //{
        //    return _ruleEngine.GetNextCellState(initialState, numNeighbors);
        //}

        // As Patrick helped me refine it:
        [TestCase(LiveNeighbors.TWO)]
        [TestCase(LiveNeighbors.THREE)]
        public void Rule_2__Alive_Cell_With_2_or_3_Neighbors_Should_Stay_Alive(int numNeighbors)
        {
            Assert.AreEqual(State.ALIVE, _ruleEngine.GetNextCellState(State.ALIVE, numNeighbors));
        }

        [TestCase(LiveNeighbors.FOUR)]
        [TestCase(LiveNeighbors.FIVE)]
        [TestCase(LiveNeighbors.SIX)]
        [TestCase(LiveNeighbors.SEVEN)]
        [TestCase(LiveNeighbors.EIGHT)]
        public void Rule_3__Alive_Cell_With_More_Than_3_Neighbors_Should_Die(int numNeighbors)
        {
            Assert.AreEqual(State.DEAD, _ruleEngine.GetNextCellState(State.ALIVE, numNeighbors));
        }

        [TestCase(LiveNeighbors.THREE)]
        public void Rule_4__Dead_Cell_With_3_Neighbors_Should_Become_Alive(int numNeighbors)
        {
            Assert.AreEqual(State.ALIVE, _ruleEngine.GetNextCellState(State.DEAD, numNeighbors));
        }
    }
}
