using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawler
{
    class Game
    {
        public static Random RANDOM = new Random();

        private Dictionary<string, World> worlds;
        private string gameTitle;
        private bool isOver = false;

        internal void Init()
        {
            this.worlds = new Dictionary<string, World>();
            this.worlds.Add("normal", new World("normal"));
            Console.WriteLine("Welcome to {0} {1}.", "Laba's", gameTitle); // idk this is totally overboard but it's good to know
        }

        public Game(string gameTitle)
        {
            this.gameTitle = gameTitle;
        }

        public void interact()
        {
            Console.WriteLine("Interacting...");
            Console.WriteLine(Console.ReadLine());
        }

        public bool isGameOver()
        {
            return isOver;
        }

        public void endGame()
        {
            this.isOver = true;
            //
        }

        public string getGameTitle()
        {
            return this.gameTitle;
        }

        public Dictionary<string, World> getWorlds() { return worlds; }

    }
}
