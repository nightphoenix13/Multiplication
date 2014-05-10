// Written by Zack Rosales
// Introduction to C# Programming ITSE 1430 1001
// Program for page 331, # 6

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // local variables
            int number;

            // gets input from user
            number = Convert.ToInt32(numberTextBox.Text);

            // method call
            MultiplicationTable(number);
        }

        private void MultiplicationTable(int num)
        {
            // preparing output labels
            outputLabel1.Text = String.Format("{0} x 2 = {1}", num, (num * 2));
            outputLabel2.Text = String.Format("{0} x 3 = {1}", num, (num * 3));
            outputLabel3.Text = String.Format("{0} x 4 = {1}", num, (num * 4));
            outputLabel4.Text = String.Format("{0} x 5 = {1}", num, (num * 5));
            outputLabel5.Text = String.Format("{0} x 6 = {1}", num, (num * 6));
            outputLabel6.Text = String.Format("{0} x 7 = {1}", num, (num * 7));
            outputLabel7.Text = String.Format("{0} x 8 = {1}", num, (num * 8));
            outputLabel8.Text = String.Format("{0} x 9 = {1}", num, (num * 9));
            outputLabel9.Text = String.Format("{0} x 10 = {1}", num, (num * 10));

            // making output labels visible
            outputLabel1.Visible = true;
            outputLabel2.Visible = true;
            outputLabel3.Visible = true;
            outputLabel4.Visible = true;
            outputLabel5.Visible = true;
            outputLabel6.Visible = true;
            outputLabel7.Visible = true;
            outputLabel8.Visible = true;
            outputLabel9.Visible = true;
        }
    }
}
