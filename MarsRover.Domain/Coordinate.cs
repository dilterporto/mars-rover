namespace MarsRover.Domain
{
    public class Coordinate
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual void AddX(int value)
        {
            this.X += value;
        }

        public virtual void AddY(int value)
        {
            this.Y += value;
        }

        public virtual void RemoveY(int value)
        {
            this.Y -= value;

        }

        public virtual void RemoveX(int value)
        {
            this.X -= value;
        }
    }
}