using System;

namespace DungeonCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Dungeon Crawler");

            game.Init();

            while (!game.isGameOver())
            {
                game.interact();
            }
        }
    }
}
