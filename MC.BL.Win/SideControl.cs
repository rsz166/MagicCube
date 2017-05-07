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
    public partial class SideControl : UserControl
    {
        int sideLength;
        public Side Side { get; set; }

        public int SideLength
        {
            get
            {
                return sideLength;
            }

            set
            {
                sideLength = value;
                Controls.Clear();
            }
        }

        Panel[,] Tiles;

        public SideControl()
        {
            InitializeComponent();
        }

        private void CreateTiles()
        {
            int tileWidth = Width / sideLength;
            int tileHeight = Height / sideLength;
            Tiles = new Panel[sideLength, sideLength];
            for (int row = 0; row < sideLength; row++)
            {
                for (int col = 0; col < sideLength; col++)
                {
                    var panel = new Panel()
                    {
                        Width = tileWidth,
                        Height = tileHeight,
                        Top = row * tileHeight,
                        Left = col * tileWidth,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    Tiles[col, row] = panel;
                    Controls.Add(panel);
                }
            }
            UpdateTiles();
        }

        public void UpdateTiles()
        {
            if (Side != null && Tiles != null)
            {
                for (int row = 0; row < sideLength; row++)
                {
                    for (int col = 0; col < sideLength; col++)
                    {
                        Color color;
                        switch (Side[col, row])
                        {
                            default:
                            case 0: color = Color.White; break;
                            case 1: color = Color.Yellow; break;
                            case 2: color = Color.Blue; break;
                            case 3: color = Color.Green; break;
                            case 4: color = Color.Orange; break;
                            case 5: color = Color.Red; break;
                        }
                        Tiles[col, row].BackColor = color;
                    }
                }
            }
        }

        private void SideControl_Load(object sender, EventArgs e)
        {
            if(Controls.Count == 0)
            {
                CreateTiles();
            }
        }
    }
}
