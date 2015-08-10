using System.Collections.Generic;
using System.Linq;

namespace Minesweeper3
{
    public class Minefield
    {
        public static Minefield Unexplored(int width, int height)
        {
            var rowIndices = Enumerable.Range(0, height);
            var squares = rowIndices.Select(rowIndex => RowOfSquares(width)).ToList();
            return new Minefield(width, height, squares);
        }

        private static IList<bool> RowOfSquares(int width)
        {
            return Enumerable.Range(0, width).Select(columnIndex => false).ToList();
        }

        private readonly int _width;
        private readonly int _height;
        private readonly IList<IList<bool>> _squares = new List<IList<bool>>();

        private Minefield(int width, int height, IList<IList<bool>> squares)
        {
            _width = width;
            _height = height;
            _squares = squares;
        }

        public int Height
        {
            get { return _height; }
        }

        public int Width
        {
            get { return _width; }
        }

        public Minefield Explore(Coordinates coordinates)
        {
            return new Minefield(_width, _height, ExploreSquares(_squares, coordinates));
        }

        private IList<IList<bool>> ExploreSquares(IList<IList<bool>> squares, Coordinates coordinates)
        {
            return squares
                .Select((row, rowIndex) => ExploreRow(row, rowIndex, coordinates))
                .ToList();
        }

        private IList<bool> ExploreRow(IList<bool> row, int rowIndex, Coordinates coordinates)
        {
            return row
                .Select((explored, columnIndex) => (coordinates.ColumnIndex == columnIndex && coordinates.RowIndex == rowIndex) || explored)
                .ToList();
        }

        public bool IsExplored(int columnIndex, int rowIndex)
        {
            return _squares[rowIndex][columnIndex];
        }
    }
}