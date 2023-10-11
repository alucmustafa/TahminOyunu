using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tahmin_Oyunu
{
    public partial class ResultScreen : Form
    {
        public ResultScreen()
        {
            InitializeComponent();
        }
        GameControl game=new GameControl();
        private void button1_Click(object sender, EventArgs e)
        {
            StartGameScreen newGame=new StartGameScreen();
            newGame.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
