using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    /// <summary>
    /// Testes unitários com todos os comportamentos especificados para o 
    /// objeto Rover
    /// </summary>
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void CanCreateRoverWithInitialPosition()
        {
            //  arrange 
            const int x = 0;
            const int y = 0;
            const CardinalDirection cardinalDirection = CardinalDirection.North;

            //  act
            var rover = new Rover(x, y, cardinalDirection);

            //  assert
            Assert.AreEqual(0, rover.Position.Coordinate.X);
            Assert.AreEqual(0, rover.Position.Coordinate.Y);
            Assert.AreEqual(CardinalDirection.North, rover.Position.CardinalDirection);
        }

        [TestMethod]
        public void CanOutputActualPositionDefaultFormat()
        {
            //  arrange 
            const int x = 1;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.North;

            //  act
            var rover = new Rover(x, y, cardinalDirection);

            //  assert
            Assert.AreEqual("1 2 N", rover.ToString());
        }

        [TestMethod]
        public void CanChangeOrientationToLeftFacingNorth()
        {
            //  arrange 
            const int x = 1;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.North;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.ChangeOrientation(Orientation.Left);

            //  assert
            Assert.AreEqual(CardinalDirection.West, rover.Position.CardinalDirection);

        }

        [TestMethod]
        public void CanChangeOrientationToRightFacingNorth()
        {
            //  arrange 
            const int x = 1;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.North;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.ChangeOrientation(Orientation.Right);

            //  assert
            Assert.AreEqual(CardinalDirection.East, rover.Position.CardinalDirection);

        }

        [TestMethod]
        public void CanChangeOrientationToLeftFacingSouth()
        {
            //  arrange 
            const int x = 1;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.South;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.ChangeOrientation(Orientation.Left);

            //  assert
            Assert.AreEqual(CardinalDirection.East, rover.Position.CardinalDirection);

        }

        [TestMethod]
        public void CanChangeOrientationToRightFacingSouth()
        {
            //  arrange 
            const int x = 1;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.South;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.ChangeOrientation(Orientation.Right);

            //  assert
            Assert.AreEqual(CardinalDirection.West, rover.Position.CardinalDirection);

        }

        [TestMethod]
        public void CanChangeOrientationToLeftFacingWest()
        {
            //  arrange 
            const int x = 1;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.West;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.ChangeOrientation(Orientation.Left);

            //  assert
            Assert.AreEqual(CardinalDirection.South, rover.Position.CardinalDirection);

        }

        [TestMethod]
        public void CanChangeOrientationToRightFacingWest()
        {
            //  arrange 
            const int x = 1;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.West;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.ChangeOrientation(Orientation.Right);

            //  assert
            Assert.AreEqual(CardinalDirection.North, rover.Position.CardinalDirection);

        }

        [TestMethod]
        public void CanChangeOrientationToLeftFacingEast()
        {
            //  arrange 
            const int x = 1;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.East;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.ChangeOrientation(Orientation.Left);

            //  assert
            Assert.AreEqual(CardinalDirection.North, rover.Position.CardinalDirection);

        }

        [TestMethod]
        public void CanChangeOrientationToRightFacingEast()
        {
            //  arrange 
            const int x = 1;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.East;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.ChangeOrientation(Orientation.Right);

            //  assert
            Assert.AreEqual(CardinalDirection.South, rover.Position.CardinalDirection);

        }

        [TestMethod]
        public void CanMoveUp()
        {
            //  arrange 
            const int x = 1;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.North;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.Move();

            //  assert
            Assert.AreEqual(3, rover.Position.Coordinate.Y);

        }

        [TestMethod]
        public void CanMoveDown()
        {
            //  arrange 
            const int x = 1;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.South;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.Move();

            //  assert
            Assert.AreEqual(1, rover.Position.Coordinate.Y);

        }

        [TestMethod]
        public void CanMoveLeft()
        {
            //  arrange 
            const int x = 3;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.West;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.Move();

            //  assert
            Assert.AreEqual(2, rover.Position.Coordinate.X);

        }

        [TestMethod]
        public void CanMoveRight()
        {
            //  arrange 
            const int x = 3;
            const int y = 2;
            const CardinalDirection cardinalDirection = CardinalDirection.East;
            var rover = new Rover(x, y, cardinalDirection);

            //  act
            rover.Move();

            //  assert
            Assert.AreEqual(4, rover.Position.Coordinate.X);

        }
    }
}
