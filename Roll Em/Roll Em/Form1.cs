using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll_Em
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random randomNumbers = new Random();

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int i = randomNumbers.Next(1, 7); // 1 to 6
            int j = randomNumbers.Next(1, 7);

            pbxDie1.Image = (Image) (Properties.Resources.ResourceManager.GetObject(
                $"dice{i}"));
            pbxDie2.Image = (Image) (Properties.Resources.ResourceManager.GetObject(
                $"dice{j}"));
        }
    }
}
