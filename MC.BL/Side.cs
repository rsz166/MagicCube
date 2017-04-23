using System;
using System.Collections.Generic;
using System.Text;

namespace MC.BL
{
    public class Side
    {
        public readonly int Size;
        public int[,] Tiles { get; set; }

        public int this[int col, int row]
        {
            get { return Tiles[col, row]; }
            set { Tiles[col, row] = value; }
        }

        public Side(int size = 3)
        {
            Size = size;
            Tiles = new int[Size, Size];
        }

        public Side GetCopy()
        {
            Side side = new Side(Size);
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    side[col, row] = Tiles[col, row];
                }
            }
            return side;
        }

        public bool AreEquals(Side side)
        {
            if (side == null) return false;
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if(side[col, row] != Tiles[col, row])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void RotateHalf()
        {
            RotateCw();
            RotateCw();
        }

        public void RotateCw()
        {
            for (int row = 0; row < Size / 2; row++)
            {
                int last = Size - 1 - row;
                for (int i = 0; i < last - row; i++)
                {
                    var tmp = Tiles[i + row, row];
                    Tiles[i + row, row] = Tiles[row, last - i];
                    Tiles[row, last - i] = Tiles[last - i, last];
                    Tiles[last - i, last] = Tiles[last, i + row];
                    Tiles[last, i + row] = tmp;
                }
            }
        }

        public void RotateCcw()
        {
            for (int row = 0; row < Size / 2; row++)
            {
                int last = Size - 1 - row;
                for (int i = 0; i < last - row; i++)
                {
                    var tmp = Tiles[i + row, row];
                    Tiles[i + row, row] = Tiles[last, i + row];
                    Tiles[last, i + row] = Tiles[last - i, last];
                    Tiles[last - i, last] = Tiles[row, last - i];
                    Tiles[row, last - i] = tmp;
                }
            }
        }

        public int[] GetColumn(int col)
        {
            int[] ret = new int[Size];
            for (int row = 0; row < Size; row++)
            {
                ret[row] = Tiles[col, row];
            }
            return ret;
        }

        public int[] GetRow(int row)
        {
            int[] ret = new int[Size];
            for (int col = 0; col < Size; col++)
            {
                ret[col] = Tiles[col, row];
            }
            return ret;
        }

        void Reverse(int[] array)
        {
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                int tmp = array[i];
                array[i] = array[j];
                array[j] = array[i];
            }
        }

        public void SetColumn(int col, int[] tiles, bool reverse = false)
        {
            if(reverse) Reverse(tiles);
            for (int row = 0; row < Size; row++)
            {
                Tiles[col, row] = tiles[row];
            }
        }

        public void SetRow(int row, int[] tiles, bool reverse = false)
        {
            if(reverse) Reverse(tiles);
            for (int col = 0; col < Size; col++)
            {
                Tiles[col, row] = tiles[col];
            }
        }

        public void SetSide(int value)
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    Tiles[col, row] = value;
                }
            }
        }

        public void SetSide(int[,] values)
        {
            Tiles = values;
        }
    }
}
