using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC.BL.Win
{
    public partial class Cube3Control : UserControl
    {
        Cube3 cube;

        public Cube3 Cube
        {
            get
            {
                return cube;
            }

            set
            {
                cube = value;
                if (cube != null)
                {
                    sideU.Side = cube[Cube3.SideNames.Up];
                    sideD.Side = cube[Cube3.SideNames.Down];
                    sideF.Side = cube[Cube3.SideNames.Front];
                    sideB.Side = cube[Cube3.SideNames.Back];
                    sideR.Side = cube[Cube3.SideNames.Right];
                    sideL.Side = cube[Cube3.SideNames.Left];
                }
            }
        }

        public Cube3Control()
        {
            InitializeComponent();
        }

        public void UpdateCube()
        {
            foreach (var side in Controls)
            {
                (side as SideControl)?.UpdateTiles();
            }
        }
    }
}
