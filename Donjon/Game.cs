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
            map = new Map(width: 15, height: 15);
            Cell heroCell = map.GetCell(0, 0);
            hero = new Hero(heroCell);

            Cell healCell = map.GetCell(7, 5);
            healer = new Healer(healCell);

            map.Creatures.Add(hero);
            map.Creatures.Add(new Creature(map.GetCell(7, 8)));
        }

        private void Play()
        {
            bool gameInProgress = true;
            do
            {

                Draw();
                //get command
                var key = UI.GetKey();
                
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        MoveHero(new Position(0, -1));
                        break;
                    case ConsoleKey.DownArrow:
                        MoveHero(new Position(0, 1));
                        break;
                    case ConsoleKey.LeftArrow:
                        MoveHero(new Position(-1, 0));
                        break;
                    case ConsoleKey.RightArrow:
                        MoveHero(new Position(1, 0));
                        break;
                    case ConsoleKey.Q:
                        gameInProgress = false;
                        break;
                }
                //execute action
                Draw();
                //update game objects
            } while (gameInProgress);
            Draw();

        }

        private void MoveHero(Position movement)
        {
            var newPosition = hero.Cell.Position + movement;
            Cell targetCell = map.GetCell(newPosition.X, newPosition.Y);
            if (targetCell != null) hero.Cell = targetCell;
        }

        private void Draw()
        {
            UI.Clear();
            UI.Draw(map);
            UI.SetColor(ConsoleColor.White);
            
        }

       



        //int Add(int v1, int v2) => v1 + v2;

        //int Add(int v1, int v2)
        //{
        //    return v1 + v2; // går istället för att skriva sum = v1 + v2
        //}
    }
}