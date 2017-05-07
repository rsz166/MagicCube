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
            string[] steps = {
                // basic
                "L", "R", "B", "F", "U", "D", "x", "y", "z",
                // complex
                "M", "E", "S", "r", "I", "f", "b", "u", "d"
            };
            var cube = new Cube3();
            var copy = cube.GetCopy();
            PrintCube(cube);
            foreach (var step in steps)
            {
                Console.WriteLine($"Testing step: {step}");
                Console.WriteLine("Rotate 4 times");
                for (int i = 0; i < 4; i++) cube.Step(step);
                PrintCube(cube);
                Assert.IsTrue(cube.AreEquals(copy));
                Console.WriteLine("Rotate back and forth");
                cube.Step($"{step}'");
                cube.Step(step);
                PrintCube(cube);
                Assert.IsTrue(cube.AreEquals(copy));
                Console.WriteLine("Rotate double twice");
                cube.Step($"{step}2");
                cube.Step($"{step}2");
                PrintCube(cube);
                Assert.IsTrue(cube.AreEquals(copy));
            }
        }
    }
}
