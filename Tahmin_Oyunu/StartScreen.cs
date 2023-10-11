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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private async void StartScreen_Load(object sender, EventArgs e)
        {
            await Task.Delay(3000);
            SplahsScreen newGame = new SplahsScreen();
            newGame.Show();
            this.Hide();
        }
    }
}
