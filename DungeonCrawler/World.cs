using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawler
{
    class World
    {
        private string worldName;
        private Dictionary<string, Room> rooms;

        public World(string worldName)
        {
            this.worldName = worldName;
            this.rooms = new Dictionary<string, Room>();

            Room newRoom = new Room(0, 1);
            this.rooms.Add(newRoom.getCoordString(), newRoom);
        }


        public string getWorldName() { return worldName; }

        public Dictionary<string, Room> getRooms() { return rooms; }

    }
}
