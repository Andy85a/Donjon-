using System;

namespace Donjon
{
    internal abstract class Creature : IDrawable
    {
        public string Symbol => "CR7";
        public string Symbol2 => "He";
        

        public ConsoleColor Color => ConsoleColor.White;
        public Cell Cell { get; set; }

        public Creature(Cell cell)
        {
            Cell = cell;
        }
    }
}