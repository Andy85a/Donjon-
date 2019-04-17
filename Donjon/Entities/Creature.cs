using Donjon.World;
using System;

namespace Donjon.Entities
{
    internal class Creature : IDrawable
    {
        public string Symbol { get; set; } = "Abouu";
        //public string Symbol2 => "He";


        public ConsoleColor Color => ConsoleColor.White;
        public Cell Cell { get; set; }

        public Creature(Cell cell)
        {
            Cell = cell;
        }
    }
}