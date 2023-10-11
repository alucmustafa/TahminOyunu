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
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }
        GameControl game = new GameControl();
        StartGameScreen name = new StartGameScreen();
        ResultScreen result = new ResultScreen();
        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGameScreen BackScreen = new StartGameScreen();
            BackScreen.Show();
            this.Close();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void Azalt1(object sender, EventArgs e)
        {
            game.azalt1();
            personTxt.Text = Convert.ToString(game.returnPersonNumber);
            PcText.Text= Convert.ToString(game.returnPcNumber);
            if (!game.draw)
            {
                if (game.controlPerson)
                {
                    result.vinnerName.Text = nameGamer.Text + " Kazandın..:)";
                    result.number.Text = Convert.ToString(game.startNumber);
                    result.ShowDialog();
                    this.Close();
                }
                else if (game.controlPc)
                {
                    result.vinnerName.Text = "Pc Kazandı :(";
                    result.number.Text = Convert.ToString(game.startNumber);
                    result.ShowDialog();                   
                    this.Close();
                }
            }
            else
            {
                result.vinnerName.Text = "Kazanan Çıkmadı. Tekrar deneyiniz :)";
                result.number.Text = Convert.ToString(game.startNumber);
                result.ShowDialog();
                this.Close();
            }
        }

        private void Azalt2(object sender, EventArgs e)
        {
            game.azalt2();
            personTxt.Text = Convert.ToString(game.returnPersonNumber);
            PcText.Text = Convert.ToString(game.returnPcNumber);
            if (!game.draw)
            {
                if (game.controlPerson)
                {
                    result.vinnerName.Text = nameGamer.Text + " Kazandın..:)";
                    result.number.Text = Convert.ToString(game.startNumber);
                    result.ShowDialog();
                    this.Close();
                }
                else if (game.controlPc)
                {
                    result.vinnerName.Text = "Pc Kazandı :(";
                    result.number.Text = Convert.ToString(game.startNumber);
                    result.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                result.vinnerName.Text = "Kazanan Çıkmadı. Tekrar deneyiniz :)";
                result.number.Text = Convert.ToString(game.startNumber);
                result.ShowDialog();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(game.GameNumber);
        }
    }
}
