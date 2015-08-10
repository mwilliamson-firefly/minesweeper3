using System;

namespace Minesweeper3
{
    class Program
    {
        static void Main(string[] args)
        {
            var minefield = Minefield.Unexplored(5, 5);
            Console.Write(MinefieldRenderer.Render(minefield));

            var coordinates = CoordinateParser.Parse(Console.ReadLine());
            var newMinefield = minefield.Explore(coordinates);
            Console.Write(MinefieldRenderer.Render(newMinefield));


            Console.ReadLine();
        }
    }
}
