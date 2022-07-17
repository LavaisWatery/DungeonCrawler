using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawler
{
    class World
    {
        // WORLD DATA
        public static int WORLD_LENGTH = 10;

        private string worldName;
        private Dictionary<string, Room> rooms;

        public World(string worldName)
        {
            this.worldName = worldName;
            this.rooms = new Dictionary<string, Room>();

            generate();

            displayWorld();
        }

        void generate()
        {
            for(int i = 0; i < 5; i++)
            {
                Room room = new Room(Game.RANDOM.Next(0, WORLD_LENGTH), Game.RANDOM.Next(0, WORLD_LENGTH));
                this.rooms.Add(room.getCoordString(), room);
            }
        }

        public string getRoomCoord(int x, int y)
        {
            return "" + x + "," + y;
        }

        public string displayWorld()
        {
            Console.WriteLine("Generated World: \n\n");
            for(int y = 0; y < WORLD_LENGTH; y++)
            {
                Console.Write("|");
                
                for (int x = 0; x < WORLD_LENGTH; x++) {
                    Room room;

                    if(rooms.TryGetValue(getRoomCoord(x, y), out room))
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }

                Console.Write("|\n");
            }
            Console.Write("\n\n");

            return "";
        }

        public string getWorldName() { return worldName; }

        public Dictionary<string, Room> getRooms() { return rooms; }

    }
}
