using MarsRover.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{    
    [TestClass]
    public class CoordinateTests
    {
        [TestMethod]
        public void CanCreateCoordinateUsingDefaultConstructor()
        {
            //  arrange
            const int x = 0;
            const int y = 0;

            //  act
            var coordinate = new Coordinate(x, y);

            //  assert
            Assert.AreEqual(0, coordinate.X);
            Assert.AreEqual(0, coordinate.Y);
        }
    }
}
