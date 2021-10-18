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
    public partial class Form9 : Form
    {
        bool f1=false;
        bool f2=false;
        bool ov1=false;
        bool ov2=false;
        bool vm=false;
        bool cm=false;
        bool genikos = false;


        public Form9()
        {
            InitializeComponent();
        }

        private void αρχικήToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ηλεκτρικέςΣυσκευέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form8();
            myForm.Show();
            this.Visible = false;
        }

        private void ηλεκτρικήΣκούπαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form10();
            myForm.Show();
            this.Visible = false;
        }

        private void καφετέριαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form9();
            myForm.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (genikos == true)
            {
                if (f2 == false)
                {
                    pictureBox8.Image = Properties.Resources.gl;
                    f2 = true;
                }
                else
                {
                    pictureBox8.Image = Properties.Resources.rl;
                    f2 = false;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (genikos == true)
            {
                if (f1 == false)
                {
                    pictureBox7.Image = Properties.Resources.gl;
                    f1 = true;
                }
                else
                {
                    pictureBox7.Image = Properties.Resources.rl;
                    f1 = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (genikos == true)
            {
                if (ov1 == false)
                {
                    pictureBox9.Image = Properties.Resources.gl;
                    ov1 = true;
                }
                else
                {
                    pictureBox9.Image = Properties.Resources.rl;
                    ov1 = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (genikos == true)
            {
                if (cm == false)
                {
                    pictureBox10.Image = Properties.Resources.gl;
                    cm = true;
                }
                else
                {
                    pictureBox10.Image = Properties.Resources.rl;
                    cm = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (genikos == true)
            {
                if (ov2 == false)
                {
                    pictureBox11.Image = Properties.Resources.gl;
                    ov2 = true;
                }
                else
                {
                    pictureBox11.Image = Properties.Resources.rl;
                    ov2 = false;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (genikos == true)
            {
                if (vm == false)
                {
                    pictureBox12.Image = Properties.Resources.gl;
                    vm = true;
                }
                else
                {
                    pictureBox12.Image = Properties.Resources.rl;
                    vm = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (genikos == true)
            {
                genikos = false;
                pictureBox7.Image = Properties.Resources.rl;
                pictureBox8.Image = Properties.Resources.rl;
                pictureBox9.Image = Properties.Resources.rl;
                pictureBox10.Image = Properties.Resources.rl;
                pictureBox11.Image = Properties.Resources.rl;
                pictureBox12.Image = Properties.Resources.rl;
                pictureBox13.Image = Properties.Resources.rl;
            }
            else
            {
                genikos = true;
                pictureBox13.Image = Properties.Resources.gl;
            }
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πατώντας το κουμπί ‘γενικός διακόπτης ρεύματος’ ανάβετε το ρεύμα έτσι ώστε να μπορούν να ανάψουν οι συσκευές. Υστέρα, πατώντας στο κουμπί με το όνομα μιας συσκευές  ανάβετε  την αντίστοιχη συσκευή αν είναι σβηστή και την σβήνετε αν είναι αναμμένη. ");
        }
    }
}
