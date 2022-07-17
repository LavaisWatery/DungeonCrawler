using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonCrawler
{
    class Room
    {
        private int xCoord, yCoord;

        public Room(int xCoord, int yCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

        public int getXCoord() { return xCoord; }
        public int getYCoord() { return yCoord; }

        public string getCoordString() { return "" + xCoord + "," + yCoord; }

        public override string ToString() { return "Room: " + xCoord + ", " + yCoord; }
    }
}
