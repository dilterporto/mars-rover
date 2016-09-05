using MarsRover.Domain;

namespace MarsRover.UI.Console
{
    public class ServiceController
    {
        protected Plateau Plateau { get; set; }

        public ServiceController(int x, int y)
        {
            this.Plateau = new Plateau(x, y);
        }

        public virtual void CreateNewRover(string x, string y, string cardinalDirection)
        {
            var rover = new Rover(int.Parse(x), int.Parse(y), CardinalDirectionExtensions.Parse(cardinalDirection));
            this.Plateau.AddRover(rover);
        }

        public virtual void ExecuteCommand(int roverIndex, string command)
        {
            foreach (var @char in command)
            {                
                if (@char.Equals('L'))
                {
                    this.Plateau.Rovers[roverIndex].ChangeOrientation(Orientation.Left);
                    continue;
                }

                if (@char.Equals('R'))
                {
                    this.Plateau.Rovers[roverIndex].ChangeOrientation(Orientation.Right);
                    continue;
                }

                if (@char.Equals('M'))
                {
                    this.Plateau.Rovers[roverIndex].Move();
                    continue;
                }
            }
        }

        public virtual Rover GetRover(int index)
        {
            return this.Plateau.Rovers[index];
        }
    }
}
