namespace Donjon
{
    internal interface IDrawable
    {
        string Symbol { get;  }
        //string Symbol2 { get; }
        System.ConsoleColor Color { get; }
    }
}