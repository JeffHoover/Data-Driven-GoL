namespace GOL1.Tests
{
    public enum LiveNeighbors
    {
        ZERO,
        ONE,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE
    }

    public class RuleEngine
    {

        public State GetNextCellState   (State initialState, int numNeighbors)
        {
            if (numNeighbors == 3 || (numNeighbors == 2 && initialState == State.ALIVE))
                return State.ALIVE;
            return State.DEAD;
        }
    }
}