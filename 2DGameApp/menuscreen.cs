using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DGameApp
{
    public partial class menuscreen : UserControl
    {
        public menuscreen()
        {
            InitializeComponent();

            //clear score
            gamescreen.score = 0;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //switch to game screen on play click
            Form f = this.FindForm();
            f.Controls.Remove(this);

            gamescreen gs = new gamescreen();
            f.Controls.Add(gs);

            playButton.Enabled = false;
            exitButton.Enabled = false;
            gs.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit application on exit click
            Application.Exit();
        }
    }
}
