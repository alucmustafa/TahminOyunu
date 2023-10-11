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
    public partial class SplahsScreen : Form
    {
        public SplahsScreen()
        {
            InitializeComponent();
        }

        private async void SplahsScreen_Load(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            StartGameScreen newGame = new StartGameScreen();
            newGame.Show();
            this.Hide();
        }
    }
}
