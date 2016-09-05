using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{    
    [TestClass]
    public class PositionTest
    {
        [TestMethod]
        public void CanCreateAPositionUsingDefaultConstructor()
        {
            //  arrange
            const int x = 0;
            const int y = 0;
            const CardinalDirection orientation = CardinalDirection.North;

            //  act
            var position = new Position(x, y, orientation);

            //  assert
            Assert.AreEqual(0, position.Coordinate.X);
            Assert.AreEqual(0, position.Coordinate.Y);
            Assert.AreEqual(CardinalDirection.North, position.CardinalDirection);

        }

        [TestMethod]
        public void CanOutputDefault()
        {
            //  arrange
            const int x = 0;
            const int y = 0;
            const CardinalDirection orientation = CardinalDirection.North;

            //  act
            var position = new Position(x, y, orientation);

            //  assert
            Assert.AreEqual("0 0 N", position.ToString());
        }
    }
}
