using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema
{
    public partial class Form2 : Form
    {
        double cost;
        long til;
        long credit;
        public Form2(double price)
        {
            InitializeComponent();
            cost = price;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox1.Text != "" & textBox3.Text != "" & textBox4.Text != "" )
            {
                label11.Text = textBox1.Text;
                label12.Text = textBox2.Text;
                label13.Text = textBox3.Text;
                label14.Text = textBox4.Text;
                label15.Text = cost.ToString();
                panel1.Visible = true;

            }                
            else
            {
                MessageBox.Show("Δεν έχετε συμπληρώσει όλα τα πεδία");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            this.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                til = Int64.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("το πεδίο Τηλέφωνο πρέπει να αποτελείται απο αριθμούς");
                textBox2.Text = "0";
            }
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                credit = Int64.Parse(textBox4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("το πεδίο Credit Card πρέπει να αποτελείται απο αριθμούς");
                textBox4.Text = "0";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
