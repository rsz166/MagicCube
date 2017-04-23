using System;
using System.Collections.Generic;
using System.Text;

namespace MC.BL
{
    public class Cube3
    {
        public enum SideNames
        {
            Front = 0,
            Back = 1,
            Up = 2,
            Down = 3,
            Left = 4,
            Right = 5,
        }
        public Side[] Sides { get; set; }
        public Side this[int index] { get { return Sides[index]; } }
        public Side this[SideNames name] { get { return Sides[(int)name]; } }
        public readonly int Size;

        public Cube3()
        {
            Size = 3;
            Sides = new Side[6];
            for (int i = 0; i < Sides.Length; i++)
            {
                Sides[i] = new Side(Size);
                Sides[i].SetSide(i);
            }
        }

        public void Step(string step)
        {
            bool reverse = step.Length > 1 && step[1] == '\'';
            bool twice = step.Length > 1 && step[1] == '2';
            int count = twice ? 2 : reverse ? 3 : 1;
            switch (step[0])
            {
                case 'L': StepL(count); break;
                case 'R': StepR(count); break;
                case 'B': StepB(count); break;
                case 'F': StepF(count); break;
                case 'U': StepU(count); break;
                case 'D': StepD(count); break;
                case 'x': StepX(count); break;
                case 'y': StepY(count); break;
                case 'z': StepZ(count); break;
                default:
                    // split to known steps
                    SplitSteps(step);
                    break;
            }
        }

        void SplitSteps(string steps)
        {
            // TODO
        }
        
        public void StepL(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this[SideNames.Left].RotateCw();
                var tmp = this[SideNames.Front].GetColumn(0);
                this[SideNames.Front].SetColumn(0, this[SideNames.Up].GetColumn(0));
                this[SideNames.Up].SetColumn(0, this[SideNames.Back].GetColumn(Size - 1), true);
                this[SideNames.Back].SetColumn(Size - 1, this[SideNames.Down].GetColumn(0), true);
                this[SideNames.Down].SetColumn(0, tmp);
            }
        }

        public void StepR(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this[SideNames.Right].RotateCw();
                var tmp = this[SideNames.Front].GetColumn(Size - 1);
                this[SideNames.Front].SetColumn(Size - 1, this[SideNames.Down].GetColumn(Size - 1));
                this[SideNames.Down].SetColumn(Size - 1, this[SideNames.Back].GetColumn(0), true);
                this[SideNames.Back].SetColumn(0, this[SideNames.Up].GetColumn(Size - 1), true);
                this[SideNames.Up].SetColumn(Size - 1, tmp);
            }
        }

        public void StepB(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this[SideNames.Back].RotateCw();
                var tmp = this[SideNames.Up].GetRow(0);
                this[SideNames.Up].SetRow(0, this[SideNames.Right].GetColumn(Size - 1));
                this[SideNames.Right].SetColumn(Size - 1, this[SideNames.Down].GetRow(Size - 1), true);
                this[SideNames.Down].SetColumn(Size - 1, this[SideNames.Left].GetColumn(0));
                this[SideNames.Left].SetColumn(0, tmp, true);
            }
        }

        public void StepF(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this[SideNames.Front].RotateCw();
                var tmp = this[SideNames.Up].GetRow(Size - 1);
                this[SideNames.Up].SetRow(0, this[SideNames.Left].GetColumn(Size - 1), true);
                this[SideNames.Left].SetColumn(Size - 1, this[SideNames.Down].GetRow(0));
                this[SideNames.Down].SetRow(0, this[SideNames.Right].GetColumn(0), true);
                this[SideNames.Right].SetColumn(0, tmp);
            }
        }

        public void StepU(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this[SideNames.Up].RotateCw();
                var tmp = this[SideNames.Front].GetRow(0);
                this[SideNames.Front].SetRow(0, this[SideNames.Right].GetRow(0));
                this[SideNames.Right].SetRow(0, this[SideNames.Back].GetRow(0));
                this[SideNames.Back].SetRow(0, this[SideNames.Left].GetRow(0));
                this[SideNames.Left].SetRow(0, tmp);
            }
        }

        public void StepD(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this[SideNames.Down].RotateCw();
                var tmp = this[SideNames.Front].GetRow(Size - 1);
                this[SideNames.Up].SetRow(Size - 1, this[SideNames.Left].GetRow(Size - 1));
                this[SideNames.Left].SetRow(Size - 1, this[SideNames.Back].GetRow(Size - 1));
                this[SideNames.Back].SetRow(Size - 1, this[SideNames.Right].GetRow(Size - 1));
                this[SideNames.Right].SetRow(Size - 1, tmp);
            }
        }

        public void StepX(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this[SideNames.Right].RotateCw();
                this[SideNames.Left].RotateCcw();
                var tmp = this[SideNames.Front].Tiles;
                this[SideNames.Front].SetSide(this[SideNames.Down].Tiles);
                this[SideNames.Down].SetSide(this[SideNames.Back].Tiles);
                this[SideNames.Down].RotateHalf();
                this[SideNames.Back].SetSide(this[SideNames.Up].Tiles);
                this[SideNames.Back].RotateHalf();
                this[SideNames.Up].SetSide(tmp);
            }
        }

        public void StepY(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this[SideNames.Up].RotateCw();
                this[SideNames.Down].RotateCcw();
                var tmp = this[SideNames.Front].Tiles;
                this[SideNames.Front].SetSide(this[SideNames.Right].Tiles);
                this[SideNames.Right].SetSide(this[SideNames.Back].Tiles);
                this[SideNames.Back].SetSide(this[SideNames.Left].Tiles);
                this[SideNames.Left].SetSide(tmp);
            }
        }

        public void StepZ(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this[SideNames.Front].RotateCw();
                this[SideNames.Back].RotateCcw();
                var tmp = this[SideNames.Up].Tiles;
                this[SideNames.Up].SetSide(this[SideNames.Left].Tiles);
                this[SideNames.Up].RotateCw();
                this[SideNames.Left].SetSide(this[SideNames.Down].Tiles);
                this[SideNames.Left].RotateCw();
                this[SideNames.Down].SetSide(this[SideNames.Right].Tiles);
                this[SideNames.Down].RotateCw();
                this[SideNames.Right].SetSide(tmp);
                this[SideNames.Right].RotateCw();
            }
        }
    }
}
