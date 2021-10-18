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
    public partial class Form8 : Form
    {
        bool scaneron=false;
        bool printeron = false;
        bool print=true;
        public Form8()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var myForm = new Form6();
            myForm.Show();
            this.Visible = false;
        }

        private void φωτισμόςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form7();
            myForm.Show();
            this.Visible = false;
        }

        private void ηλεκτρικήΣκούπαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var myForm = new Form8();
            myForm.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            pictureBox2.Image = Properties.Resources.gl;
            if (print == true)
            {
                printeron = true;
                button6.Visible = true;
                richTextBox1.Visible = true;
            }
            else { scaneron = true; }

                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.rl;
            button6.Visible = false;
            richTextBox1.Visible = false;
            if (print == true)
            { printeron = false; }
            else
            { scaneron = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            print = false;
            if (scaneron == true)
            { pictureBox2.Image = Properties.Resources.gl; }
            else
            { pictureBox2.Image = Properties.Resources.rl; }
            pictureBox1.Image = Properties.Resources.scaner;
            button6.Visible = false;
            richTextBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            print = true;
            pictureBox1.Image = Properties.Resources.printer;
            if (printeron == true)
            { pictureBox2.Image = Properties.Resources.gl;
                button6.Visible = true;
                richTextBox1.Visible = true;
            }
            else
            { pictureBox2.Image = Properties.Resources.rl;
                button6.Visible = false;
                richTextBox1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new Form9();
            myForm.Show();
            this.Visible = false;
        }

        private void ηλεκτρικέςΣυσκευέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form10();
            myForm.Show();
            this.Visible = false;
        }

       

        private void καφετέριαToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var myForm = new Form9();
            myForm.Show();
            this.Visible = false;
        }

        private void βοηθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέγετε την συσκευή που θέλετε(εκτυπωτής, σαρωτής) με το ποντίκι και πατώντας το κουμπί ‘εκκίνηση’ την ανάβετε ενώ πατώντας το κουμπί ‘τερματισμός’ της σβήνετε.");
        }
    }
}
