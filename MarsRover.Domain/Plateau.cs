using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MarsRover.Domain
{
    public class Plateau
    {        
        public virtual IList<Rover> Rovers { get; protected set; }

        public virtual Coordinate UpperRightCoordinate { get; set; }

        public Plateau()
        {
            this.Rovers = new List<Rover>();
        }

        public Plateau(Coordinate upperRightCoordinate)
            : this()
        {
            this.UpperRightCoordinate = upperRightCoordinate;
        }

        public Plateau(int x, int y)
            : this(new Coordinate(x, y))
        {
                        
        }

        public virtual bool IsOutOfArea(Coordinate coordinate)
        {
            return coordinate.X > this.UpperRightCoordinate.X
                   || coordinate.Y > this.UpperRightCoordinate.Y;
        }


        public virtual void AddRover(Rover newRover)
        {
            if (this.IsOutOfArea(newRover.Position.Coordinate))
                throw new OutOfPlateauAreaException();

            this.Rovers.Add(newRover);
        }
    }
}
