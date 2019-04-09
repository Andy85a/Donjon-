using System;

namespace Donjon
{
    internal abstract class Creature : IDrawable
    {
        public string Symbol{get => symbol; set => Symbol => value;
        //public string Symbol2 => "He";
        

        public ConsoleColor Color => ConsoleColor.White;
        public Cell Cell { get; set; }

        public Creature(Cell cell)
        {
            Cell = cell;
        }
    }
}