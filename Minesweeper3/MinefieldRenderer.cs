using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper3
{
    public class MinefieldRenderer
    {
        public static string Render(Minefield minefield)
        {
            var rowIndices = Enumerable.Range(0, minefield.Height);
            var rows = rowIndices.Select(rowIndex => RenderRow(minefield, rowIndex));
            return string.Join("", rows);
        }

        private static string RenderRow(Minefield minefield, int rowIndex)
        {
            var squares = Enumerable.Range(0, minefield.Width)
                .Select(columnIndex => RenderSquare(minefield, columnIndex, rowIndex));
            return string.Join("", squares) + "\n";
        }

        private static string RenderSquare(Minefield minefield, int columnIndex, int rowIndex)
        {
            return minefield.IsExplored(columnIndex, rowIndex) ? "O" : "X";
        }
    }
}