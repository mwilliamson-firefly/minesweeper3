using NUnit.Framework;

namespace Minesweeper3.Tests
{
    public class MinefieldRendererTests
    {
        [Test]
        public void UnexploredSquaresAreRepresentedByX()
        {
            var minefield = Minefield.Unexplored(2, 3);
            Assert.AreEqual("XX\nXX\nXX\n", MinefieldRenderer.Render(minefield));
        }

        [Test]
        public void ExploredSparesRepresentedByO()
        {
            var minefield = Minefield.Unexplored(2, 3);
            var coordinates = new Coordinates(1, 2);
            var newMinefield = minefield.Explore(coordinates);
            Assert.AreEqual("XX\nXX\nXO\n", MinefieldRenderer.Render(newMinefield));
        }
    }
}
