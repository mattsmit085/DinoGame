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
    public partial class endscreen : UserControl
    {
        public endscreen()
        {
            InitializeComponent();
        }

        private void endscreen_Load(object sender, EventArgs e)
        {
            scoreLabel.Text = $"Your Score Was: {gamescreen.score}";
        }

        private void mainmenuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            menuscreen ms = new menuscreen();
            f.Controls.Add(ms);
        }
    }
}
