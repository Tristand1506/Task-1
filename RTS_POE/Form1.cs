using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTS_POE
{
    public partial class GameWindow : Form
    {
        //creates a new map with 20 units

        static GameEngine engine = new GameEngine();

        Map battlemap = engine.battleMap;

        
        
        public GameWindow()
        {
            InitializeComponent();


        }

        private void lblRound_Click(object sender, EventArgs e)
        {

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            lblGridMap.Text = "";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    lblGridMap.Text = lblGridMap.Text + battlemap.grid[i, j];
                }
                lblGridMap.Text = lblGridMap.Text + Environment.NewLine;

            }
           
        }
    }
}
