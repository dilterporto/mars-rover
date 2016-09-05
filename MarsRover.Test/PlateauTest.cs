using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    [TestClass]
    public class PlateauTest
    {
        [TestMethod]
        public void CanCreatePlateauWithUpperRightLimit()
        {
            //  arrange
            const int xMax = 5;
            const int yMax = 5;
            
            //  act
            var plateau = new Plateau(xMax, yMax);

            //  assert
            Assert.AreEqual(5, plateau.UpperRightCoordinate.X);
            Assert.AreEqual(5, plateau.UpperRightCoordinate.Y);
        }

        [TestMethod]
        public void CanAddRoverToPlateau()
        {
            //  arrange
            var plateau = new Plateau(x: 5, y: 5);
            var rover = new Rover(x:1, y:1, cardinalDirection:CardinalDirection.North);

            //  act
            plateau.AddRover(rover);

            //  assert
            Assert.AreEqual(1, plateau.Rovers.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(OutOfPlateauAreaException))]
        public void CannotAddRoverOutOfPlateauArea()
        {
            //  arrange
            var plateauUpperRighCoordinate = new Coordinate(x: 5, y: 5);
            var roverInitialCoordinate = new Position(x: 6, y: 6, cardinalDirection: CardinalDirection.North);

            var plateau = new Plateau(plateauUpperRighCoordinate);
            var rover = new Rover(roverInitialCoordinate);

            //  act
            plateau.AddRover(rover);            
        }
    }
}
