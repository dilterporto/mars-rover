namespace MarsRover.Domain
{
    public class Position
    {
        public virtual Coordinate Coordinate { get; set; }

        public virtual CardinalDirection CardinalDirection { get; set; }

        public Position(int x, int y, CardinalDirection cardinalDirection)
        {
            this.Coordinate = new Coordinate(x, y);

            this.CardinalDirection = cardinalDirection;
        }

        public virtual void ChangeCardinalDirection(CardinalDirection cardinalDirection)
        {
            this.CardinalDirection = cardinalDirection;
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Coordinate.X, this.Coordinate.Y, this.CardinalDirection.ToString().Substring(0, 1));
        }
    }
}