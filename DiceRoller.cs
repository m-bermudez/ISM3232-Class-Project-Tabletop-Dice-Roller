using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace Class_Project
{
    public partial class FormDiceRoller : Form
    {

        Random rnd;
        public FormDiceRoller()
        {
            rnd = new Random();
            InitializeComponent();
        }
        private void calculateRollOutput (int d20)
        {
            string d20roll = (d20 + 5).ToString();
            if ((d20 + 5) >= 17)
            {
                if (d20 == 20)
                {
                    textBoxRollNumber.Text = d20roll;
                    textBoxd20Result.Text = ("Attack was a critical success!!!");
                }
                else
                {
                    textBoxRollNumber.Text = d20roll;
                    textBoxd20Result.Text = ("Attack was a success!");
                }
            }
            else if (d20 == 1)
            {
                textBoxRollNumber.Text = d20roll;
                textBoxd20Result.Text = ("Attack was a critical failure!!!");
            }
            else
            {
                textBoxRollNumber.Text = d20roll;
                textBoxd20Result.Text = "Attack was a failure!";
            }
        }
        private void buttonNormal_Click(object sender, EventArgs e)
        {
            int d20 = rnd.Next(1, 21);
            calculateRollOutput(d20);
        }
        private void buttonAdvantage_Click(object sender, EventArgs e)
        {
            int d20 = Math.Max(rnd.Next(1, 21), rnd.Next(1, 21));
            calculateRollOutput(d20);
        }
        private void buttonDisadvantage_Click(object sender, EventArgs e)
        {
            int d20 = Math.Min(rnd.Next(1, 21), rnd.Next(1, 21));
            calculateRollOutput(d20);
        }

        private void buttonD4_Click(object sender, EventArgs e)
        {
            int d4 = rnd.Next(1, 5);
            listBoxTotal.Items.Add(d4);
        }
        private void buttonD6_Click(object sender, EventArgs e)
        {
            int d6 = rnd.Next(1, 7);
            listBoxTotal.Items.Add(d6);
        }
        private void buttonD8_Click(object sender, EventArgs e)
        {
            int d8 = rnd.Next(1, 9);
            listBoxTotal.Items.Add(d8);
        }
        private void buttonD10_Click(object sender, EventArgs e)
        {
            int d10 = rnd.Next(1, 11);
            listBoxTotal.Items.Add(d10);
        }
        private void buttonD12_Click(object sender, EventArgs e)
        {
            int d12 = rnd.Next(1, 13);
            listBoxTotal.Items.Add(d12);
        }

        private void buttonTotals_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int roll in listBoxTotal.Items)
            {
                sum += roll; 
            }
            textBoxTotal.Text = sum.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTotal.Clear();
            listBoxTotal.Items.Clear();
        }
    }
}
