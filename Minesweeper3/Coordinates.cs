namespace Minesweeper3
{
    public class Coordinates
    {
        private readonly int _columnIndex;
        private readonly int _rowIndex;

        public Coordinates(int columnIndex, int rowIndex)
        {
            _columnIndex = columnIndex;
            _rowIndex = rowIndex;
        }

        public int ColumnIndex
        {
            get { return _columnIndex; }
        }

        public int RowIndex
        {
            get { return _rowIndex; }
        }
    }
}