using System;
using System.Collections.Generic;
using System.Text;

namespace MC.BL
{
    class Side
    {
        public readonly int Size;
        public Tile[,] Tiles { get; }

        public Side(int size = 3)
        {
            Size = size;
            Tiles = new Tile[Size, Size];
        }

        public void TurnCcw()
        {
            int last = Size - 1;
            for (int row = 0; row < Size/2; row++)
            {
                for (int i = 0; i < last; i++)
                {
                    var tmp = Tiles[0, 0];
                    Tiles[0, 0] = Tiles[last, 0];
                    Tiles[last, 0] = Tiles[last, last];
                    Tiles[last, last] = Tiles[last, 0];
                }
            }
        }
    }
}
