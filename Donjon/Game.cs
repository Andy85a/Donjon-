using Donjon.Entities;
using Donjon.Utilities;
using Donjon.World;
using System;
using System.Collections.Generic;
using System.Linq;

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
            Cell heroCell = map.GetCell(4, 8);
            hero = new Hero(heroCell);

            //Cell healCell = map.GetCell(7, 5);
            //healer = new Healer(healCell);

            map.Creatures.Add(hero);
            map.Creatures.Add(new Creature(map.GetCell(7, 7)));

            map.GetCell(2, 3).Items.Add(Item.Fotboll());
            map.GetCell(7, 6).Items.Add(Item.HataBarca());
            map.GetCell(3, 2).Items.Add(Item.Ronaldo());
            map.GetCell(1, 9).Items.Add(Item.Fotboll());
            map.GetCell(9, 5).Items.Add(Item.HataBarca());
            map.GetCell(3, 3).Items.Add(Item.HataBarca());
            map.GetCell(5, 4).Items.Add(Item.Ronaldo());
            map.GetCell(8, 7).Items.Add(Item.HataBarca());
            map.GetCell(0, 5).Items.Add(Item.Fotboll());
        }

        private void Play()
        {
            bool gameInProgress = true;
            do
            {

                Draw();
                //get command
                var key = UI.GetKey();

                var key = new ConsoleKey();

                Dictionary<string, string> dic = new Dictionary<string, string>(); 
                dic.Add("Up"ConsoleKey.UpArrow)(0, -1)),

                
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
                    case ConsoleKey.P:
                        PickUp();
                        break;
                    case ConsoleKey.I:
                        Inventory();
                        break;
                }
                //execute action
                Draw();
                //update game objects
            } while (gameInProgress);
            Draw();

        }

        private void Inventory()
        {
            foreach (var item in hero.Backpack)
            {
                Console.WriteLine(item);
            }
        }

        private void PickUp()
        {
            var items = hero.Cell.Items;
            var item = items.FirstOrDefault();
            if (item == null) return;
            if(hero.Backpack.Add(item)) items.Remove(item);
        }

        private void MoveHero(Position movement)
        {
            var newPosition = hero.Cell.Position + movement;
            Cell targetCell = map.GetCell(newPosition);
            if (targetCell != null && targetCell.Creature == null) hero.Cell = targetCell;
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