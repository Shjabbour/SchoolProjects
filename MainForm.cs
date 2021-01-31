//Name: Shadi Jabbour
//Date: August 29, 2018
//Assignment: MyClock App
//Purpose: The purpose of this application is to display user selected numbers in a digital clock format

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClockApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // reset the form back to it's original launch state
            topLabel.BackColor = Color.DarkGreen;
            botLabel.BackColor = Color.DarkGreen;
            midLabel.BackColor = Color.DarkGreen;
            topLeftLabel.BackColor = Color.DarkGreen;
            topRightLabel.BackColor = Color.DarkGreen;
            botLeftLabel.BackColor = Color.DarkGreen;
            botRightLabel.BackColor = Color.DarkGreen;
        }

        private void midLabel_Click(object sender, EventArgs e)
        {

        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            //displays a zero on the digital display
            topLabel.BackColor = Color.Lime;
            botLabel.BackColor = Color.Lime;
            midLabel.BackColor = Color.Black;
            topLeftLabel.BackColor = Color.Lime;
            topRightLabel.BackColor = Color.Lime;
            botLeftLabel.BackColor = Color.Lime;
            botRightLabel.BackColor = Color.Lime;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            //displays a one on the digital display
            topLabel.BackColor = Color.Black;
            botLabel.BackColor = Color.Black;
            midLabel.BackColor = Color.Black;
            topLeftLabel.BackColor = Color.Black;
            topRightLabel.BackColor = Color.Lime;
            botLeftLabel.BackColor = Color.Black;
            botRightLabel.BackColor = Color.Lime;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            // displays a two on the digital display
            topLabel.BackColor = Color.Lime;
            botLabel.BackColor = Color.Lime;
            midLabel.BackColor = Color.Lime;
            topLeftLabel.BackColor = Color.Black;
            topRightLabel.BackColor = Color.Lime;
            botLeftLabel.BackColor = Color.Lime;
            botRightLabel.BackColor = Color.Black;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            // displays a three on the digital display
            topLabel.BackColor = Color.Lime;
            botLabel.BackColor = Color.Lime;
            midLabel.BackColor = Color.Lime;
            topLeftLabel.BackColor = Color.Black;
            topRightLabel.BackColor = Color.Lime;
            botLeftLabel.BackColor = Color.Black;
            botRightLabel.BackColor = Color.Lime;
        }
        private void fourButton_Click(object sender, EventArgs e)
        {
            //displays a four on the digital display
            topLabel.BackColor = Color.Black;
            botLabel.BackColor = Color.Black;
            midLabel.BackColor = Color.Lime;
            topLeftLabel.BackColor = Color.Lime;
            topRightLabel.BackColor = Color.Lime;
            botLeftLabel.BackColor = Color.Black;
            botRightLabel.BackColor = Color.Lime;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            //displays a five on the digital display
            topLabel.BackColor = Color.Lime;
            botLabel.BackColor = Color.Lime;
            midLabel.BackColor = Color.Lime;
            topLeftLabel.BackColor = Color.Lime;
            topRightLabel.BackColor = Color.Black;
            botLeftLabel.BackColor = Color.Black;
            botRightLabel.BackColor = Color.Lime;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            //displays a six on the digital display
            topLabel.BackColor = Color.Lime;
            botLabel.BackColor = Color.Lime;
            midLabel.BackColor = Color.Lime;
            topLeftLabel.BackColor = Color.Lime;
            topRightLabel.BackColor = Color.Black;
            botLeftLabel.BackColor = Color.Lime;
            botRightLabel.BackColor = Color.Lime;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            //displays a seven on the digital display
            topLabel.BackColor = Color.Lime;
            botLabel.BackColor = Color.Black;
            midLabel.BackColor = Color.Black;
            topLeftLabel.BackColor = Color.Black;
            topRightLabel.BackColor = Color.Lime;
            botLeftLabel.BackColor = Color.Black;
            botRightLabel.BackColor = Color.Lime;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            //displays an eight on the digital display
            topLabel.BackColor = Color.Lime;
            botLabel.BackColor = Color.Lime;
            midLabel.BackColor = Color.Lime;
            topLeftLabel.BackColor = Color.Lime;
            topRightLabel.BackColor = Color.Lime;
            botLeftLabel.BackColor = Color.Lime;
            botRightLabel.BackColor = Color.Lime;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            //displays a nine on the digital display
            topLabel.BackColor = Color.Lime;
            botLabel.BackColor = Color.Lime;
            midLabel.BackColor = Color.Lime;
            topLeftLabel.BackColor = Color.Lime;
            topRightLabel.BackColor = Color.Lime;
            botLeftLabel.BackColor = Color.Black;
            botRightLabel.BackColor = Color.Lime;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // ask user for confirmation if they want to exit and if yes, exit the application
            DialogResult dialog = MessageBox.Show("Do you really want to hurt me?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //If the answer is yes, close the app
            if (dialog == DialogResult.Yes)
                this.Close();
        }
    }
}
