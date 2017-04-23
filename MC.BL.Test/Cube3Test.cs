using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.BL.Test
{
    [TestClass]
    public class Cube3Test
    {
        void PrintCube(Cube3 cube)
        {
            List<string> lines = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                lines.Add(string.Concat(cube[Cube3.SideNames.Up].GetRow(i)).PadLeft(7));
            }
            for (int i = 0; i < 3; i++)
            {
                lines.Add(
                    string.Join(" ",
                        string.Concat(cube[Cube3.SideNames.Left].GetRow(i)),
                        string.Concat(cube[Cube3.SideNames.Front].GetRow(i)),
                        string.Concat(cube[Cube3.SideNames.Right].GetRow(i)),
                        string.Concat(cube[Cube3.SideNames.Back].GetRow(i))
                    ));
            }
            for (int i = 0; i < 3; i++)
            {
                lines.Add(string.Concat(cube[Cube3.SideNames.Down].GetRow(i)).PadLeft(7));
            }
            Console.WriteLine(string.Join(Environment.NewLine, lines));
            Console.WriteLine();
        }

        [TestMethod]
        public void Cube3TestConstr()
        {
            var cube = new Cube3();
            Assert.AreEqual(6, cube.Sides.Length);
            Assert.IsTrue(cube.Sides.All(x => x.Size == 3));
            PrintCube(cube);
            Assert.IsTrue(cube.Sides.All(x => x.IsSameValue));
        }

        [TestMethod]
        public void Cube3TestStep()
        {
            var cube = new Cube3();
            PrintCube(cube);
            cube.Step("L");
            PrintCube(cube);
            cube.Step("L'");
            PrintCube(cube);
            cube.Step("L2");
            PrintCube(cube);
        }
    }
}
