using System;

namespace Donjon.Entities
{
    public class Item : IDrawable
    {
        private readonly string name;

        public string Symbol { get; }

        public ConsoleColor Color { get; }

        private Item(string name, string symbol, ConsoleColor color)
        {
            this.name = name;
            Symbol = symbol;
            Color = color;
        }

        public static Item Fotboll() => new Item("alltid",  "f", ConsoleColor.DarkGray);
        public static Item Ronaldo() => new Item("dinmammajao",  "cr", ConsoleColor.Blue);

        public static Item HataBarca() => new Item("dinpappajao", "b", ConsoleColor.DarkYellow);

        public override string ToString() => name;

    }
}