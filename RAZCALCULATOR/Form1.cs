using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        double value;
        string superator;
        bool check;

        public Form1()
        {
            InitializeComponent();
        }

        private void PNumber(object sender, EventArgs e)
        {
            if ((superator == "+") || (superator == "-") || (superator == "*") || (superator == "/")) ;
            if (check)
            {
            check = false;
            result.Text="0";
        }
            Button b= sender as Button;
            if (result.Text=="0")
                result.Text=b.Text;
            else
                result.Text+=b.Text;

    }

        private void poperator(object sender, EventArgs e)
        {
            Button b = sender as Button;
            value = double.Parse(result.Text);
            superator=b.Text;
            result.Text += b.Text;
            check = true;
              
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                switch (superator)
                {
                    case "+":
                        result.Text = (value + double.Parse(result.Text)).ToString();
                        break;
                    case "-":
                        result.Text = (value + double.Parse(result.Text)).ToString();
                        break;
                    case "*":
                        result.Text = (value + double.Parse(result.Text)).ToString();
                        break;
                    case "/":
                        result.Text = (value + double.Parse(result.Text)).ToString();
                        break;


                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            
            
            
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
   
        }
    }
}
