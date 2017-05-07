using MC.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC.Win
{
    public partial class Form1 : Form
    {
        Cube3 cube;

        public Form1()
        {
            InitializeComponent();
            cube = new Cube3();
            cube3Control1.Cube = cube;
            cube3Control1.UpdateCube();
        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            ProcessSteps(tb_rotate.Text);
        }

        private void ProcessSteps(string steps)
        {
            var parts = steps.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                cube.Step(parts[i]);
                cube3Control1.UpdateCube();
            }
        }

        private void tb_rotate_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: ProcessSteps(tb_rotate.Text); break;
                case Keys.Escape: ResetCube(); break;
            }
        }

        private void ResetCube()
        {
            cube.Reset();
            cube3Control1.UpdateCube();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cube.Reset();
            cube3Control1.UpdateCube();
        }
    }
}
