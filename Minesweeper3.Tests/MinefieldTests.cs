using NUnit.Framework;

namespace Minesweeper3.Tests
{
    public class MinefieldTests
    {
        [Test]
        public void GivenAnUnexploredMinefieldAllSquaresAreUnexplored()
        {
            var minefield = Minefield.Unexplored(10, 10);
            Assert.IsFalse(minefield.IsExplored(3, 5));
        }

        [Test]
        public void SquareIsExploredAfterExploringThatSquare()
        {
            var minefield = Minefield.Unexplored(10, 10);
            var newMinefield = minefield.Explore(new Coordinates(3, 5));
            Assert.IsTrue(newMinefield.IsExplored(3, 5));
        }

        [Test]
        public void SquareRemainsExploredAfterExploringAnotherSquare()
        {
            var minefield = Minefield.Unexplored(10, 10)
                .Explore(new Coordinates(3, 5))
                .Explore(new Coordinates(2, 2));
            Assert.IsTrue(minefield.IsExplored(3, 5));
        }
    }
}
