using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tahmin_Oyunu
{
    public class GameControl
    {
        public int startNumber = 50;
        public int pc;
        public bool controlPerson = false;
        public bool controlPc = false;
        public bool draw = false;
        public int GameNumber { get; set; }
        Random rnd = new Random();
        public int returnPersonNumber;
        public int returnPcNumber;
        public GameControl()
        {
            GameNumber = rnd.Next(1, 30);
        }
        public int pcgame()
        {
            return rnd.Next(1, 3);
        }

        public void azalt1()
        {
            startNumber--;
            returnPersonNumber = startNumber;
            controlPerson = controlValue(startNumber);
            if (!controlPerson)
            {
                int pctahmin = pcgame();
                startNumber = startNumber - pctahmin;
                returnPcNumber = startNumber;
                controlPc = controlValue(startNumber);
            }
          
        }
        public void azalt2()
        {
            startNumber = startNumber - 2;
            returnPersonNumber = startNumber;
            controlPerson = controlValue(startNumber);
            if (!controlPerson)
            {
                int pctahmin = pcgame();
                startNumber = startNumber - pctahmin;
                returnPcNumber = startNumber;
                controlPc = controlValue(startNumber);
            }
        }

        private bool controlValue(int number)
        {
            if (number == GameNumber)
            {
                return true;
            }
            else if (number < GameNumber)
            {
                draw = true;
                return false;
            }
            else
            {
                return false;
            }

        }
    }
}
