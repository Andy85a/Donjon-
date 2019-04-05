using System;

namespace Donjon
{
    internal class Game
    {

        private Map map;
        private Hero hero;
        private Healer healer;
        
        public void Run()
        {
            Initialize();
            Play();
        }

        private void Initialize()
        {
            map = new Map(width: 10, height: 10);
            Cell heroCell = map.GetCell(0, 0);
            hero = new Hero(heroCell);

            Cell healCell = map.GetCell(7, 5);
            healer = new Healer(healCell);

            map.Creatures.Add(hero);
        }

        private void Play()
        {
            bool gameInProgress = false;
            do
            {

                Draw();
                //get command
                //execute action
                Draw();
                //update game objects
            } while (gameInProgress);
            Draw();

        }

        private void Draw()
        {
            Console.Clear();
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(x, y);
                    IDrawable drawable = cell; 

                    foreach (var creature in map.Creatures)
                    {
                        if(creature.Cell == cell)
                        {
                            drawable = creature;
                            break;
                        }
                    }

                    Console.ForegroundColor = drawable.Color;
                    Console.Write(" " + drawable.Symbol);
                   // Console.Write(" " + drawable.Symbol2);

                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }


        //int Add(int v1, int v2) => v1 + v2;

        //int Add(int v1, int v2)
        //{
        //    return v1 + v2; // går istället för att skriva sum = v1 + v2
        //}
    }
}