using MarsRover.Domain;

namespace MarsRover.UI.Console
{    
    public static class CardinalDirectionExtensions
    {
        public static CardinalDirection Parse(string value)
        {
            if (value.Equals("N"))
                return CardinalDirection.North;
            if (value.Equals("S"))
                return CardinalDirection.South;
            if (value.Equals("E"))
                return CardinalDirection.East;
            if (value.Equals("W"))
                return CardinalDirection.West;

            //  TODO: tratar o retorno para casos não default
            return CardinalDirection.North;
        }
    }
}
