using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MC.BL.Test
{
    [TestClass]
    public class SideTest
    {
        [TestMethod]
        public void SideTestSize()
        {
            var side1 = new Side(2);
            Assert.AreEqual(2 * 2, side1.Tiles.Length);
            var side2 = new Side(3);
            Assert.AreEqual(3 * 3, side2.Tiles.Length);
            var side3 = new Side(4);
            Assert.AreEqual(4 * 4, side3.Tiles.Length);
        }

        void FillSide(Side side)
        {
            for (int row = 0; row < side.Size; row++)
            {
                for (int col = 0; col < side.Size; col++)
                {
                    side.Tiles[col, row] = row * side.Size + col;
                }
            }
        }

        void PrintSide(Side side)
        {
            for (int row = 0; row < side.Size; row++)
            {
                for (int col = 0; col < side.Size; col++)
                {
                    Console.Write("{0} ", side.Tiles[col, row]);
                }
                Console.WriteLine();
            }
        }

        int SumOfRow(Side side, int row)
        {
            int sum = 0;
            for (int col = 0; col < side.Size; col++)
            {
                sum += (int)side[col, row];
            }
            return sum;
        }

        int SumOfCol(Side side, int col)
        {
            int sum = 0;
            for (int row = 0; row < side.Size; row++)
            {
                sum += (int)side[col, row];
            }
            return sum;
        }

        bool IsRotatedCw(Side orig, Side mod, int times)
        {
            switch (times % 4)
            {
                case 0:
                    return orig.AreEquals(mod);
                case 1:
                    for (int i = 0; i < orig.Size; i++)
                    {
                        if (SumOfRow(orig, i) != SumOfCol(mod, orig.Size - 1 - i)) return false;
                    }
                    break;
                case 2:
                    for (int i = 0; i < orig.Size; i++)
                    {
                        if (SumOfRow(orig, i) != SumOfRow(mod, orig.Size - 1 - i)) return false;
                        if (SumOfCol(orig, i) != SumOfCol(mod, orig.Size - 1 - i)) return false;
                    }
                    break;
                case 3:
                    for (int i = 0; i < orig.Size; i++)
                    {
                        if (SumOfRow(orig, i) != SumOfCol(mod, i)) return false;
                    }
                    break;
            }
            return true;
        }

        [TestMethod]
        public void Side4TestRotateCcw()
        {
            var side = new Side(4);
            FillSide(side);
            PrintSide(side);
            var original = side.GetCopy();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Rotate CCW {0} times:", i + 1);
                side.RotateCcw();
                PrintSide(side);
                Assert.IsTrue(IsRotatedCw(side, original, i + 1));
            }
        }

        [TestMethod]
        public void Side5TestRotateCcw()
        {
            var side = new Side(5);
            FillSide(side);
            PrintSide(side);
            var original = side.GetCopy();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Rotate CCW {0} times:", i + 1);
                side.RotateCcw();
                PrintSide(side);
                Assert.IsTrue(IsRotatedCw(side, original, i + 1));
            }
        }

        [TestMethod]
        public void Side4TestRotateCw()
        {
            var side = new Side(4);
            FillSide(side);
            PrintSide(side);
            var original = side.GetCopy();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Rotate CW {0} times:", i + 1);
                side.RotateCw();
                PrintSide(side);
                Assert.IsTrue(IsRotatedCw(original, side, i + 1));
            }
        }

        [TestMethod]
        public void Side5TestRotateCw()
        {
            var side = new Side(5);
            FillSide(side);
            PrintSide(side);
            var original = side.GetCopy();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Rotate CW {0} times:", i + 1);
                side.RotateCw();
                PrintSide(side);
                Assert.IsTrue(IsRotatedCw(original, side, i + 1));
            }
        }
    }
}
