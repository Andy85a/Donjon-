using System;
using System.Collections.Generic;

namespace Donjon
{
    internal class Cell : IDrawable

    {
        private readonly Map map; 
        public string Symbol => "."; //sätta startvärde
        public ConsoleColor Color => ConsoleColor.DarkCyan;

        public List<Item> Items { get; } = new List<Item>();
        //property Items kaninte få en ny tilldelning, det till likamedstecknet till höger är värdet

        public Creature Creature => map.GetCreatureAt(this);

        public Position Position { get; }

        public Cell(Position position, Map map)
        {
            Position = position;
            this.map = map;
        }


    }
}