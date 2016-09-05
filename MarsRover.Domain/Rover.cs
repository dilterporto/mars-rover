namespace MarsRover.Domain
{
    public class Rover
    {
        public virtual Position Position { get; set; }

        public Rover() { }

        public Rover(int x, int y, CardinalDirection cardinalDirection)
            : this(new Position(x, y, cardinalDirection))
        {
            
        }

        public Rover(Position position)
            : this()
        {
            this.Position = position;
        }


        public override string ToString()
        {
            return this.Position.ToString();
        }

        public void ChangeOrientation(Orientation orientation)
        {
            if(this.Position.CardinalDirection.Equals(CardinalDirection.North))
            {
                if(orientation.Equals(Orientation.Left))
                    this.Position.ChangeCardinalDirection(CardinalDirection.West);
                if(orientation.Equals(Orientation.Right))
                    this.Position.ChangeCardinalDirection(CardinalDirection.East);

                return;
            }

            if (this.Position.CardinalDirection.Equals(CardinalDirection.South))
            {
                if (orientation.Equals(Orientation.Left))
                    this.Position.ChangeCardinalDirection(CardinalDirection.East);
                if (orientation.Equals(Orientation.Right))
                    this.Position.ChangeCardinalDirection(CardinalDirection.West);

                return;
            }

            if (this.Position.CardinalDirection.Equals(CardinalDirection.East))
            {
                if (orientation.Equals(Orientation.Left))
                    this.Position.ChangeCardinalDirection(CardinalDirection.North);
                if (orientation.Equals(Orientation.Right))
                    this.Position.ChangeCardinalDirection(CardinalDirection.South);
                
                return;
            }

            if (this.Position.CardinalDirection.Equals(CardinalDirection.West))
            {
                if (orientation.Equals(Orientation.Left))
                    this.Position.ChangeCardinalDirection(CardinalDirection.South);
                if (orientation.Equals(Orientation.Right))
                    this.Position.ChangeCardinalDirection(CardinalDirection.North);

                return;
            }
        }

        public void Move()
        {
            if (this.Position.CardinalDirection.Equals(CardinalDirection.North))
                this.Position.Coordinate.AddY(1);

            if (this.Position.CardinalDirection.Equals(CardinalDirection.South))
                this.Position.Coordinate.RemoveY(1);

            if (this.Position.CardinalDirection.Equals(CardinalDirection.West))
                this.Position.Coordinate.RemoveX(1);

            if (this.Position.CardinalDirection.Equals(CardinalDirection.East))
                this.Position.Coordinate.AddX(1);
        }
    }
}
