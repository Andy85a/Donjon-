using System;

namespace Donjon
{
    internal class Creature : IDrawable
    {
        public string Symbol { get; set; } = "C";
        //public string Symbol2 => "He";
        

        public ConsoleColor Color => ConsoleColor.White;
        public Cell Cell { get; set; }

        public Creature(Cell cell)
        {
            Cell = cell;
        }
    }
}