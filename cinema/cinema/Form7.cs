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
    public partial class Form7 : Form
    {
        int i=1;
        bool e1 = false;
        bool e2 = false;
        bool e3 = false;
        bool e4 = false;
        
        public Form7()
        {
            InitializeComponent();
        }

        public bool Room(bool flag)
        {
            if (flag == false)
            {
                button1.BackgroundImage = Properties.Resources.on;
                flag = true;
                switch (i)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.cinema;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.cinema2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.cinema3;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.cinema4;
                        break;
                    default:
                        break;
                }
            }
            else
            {

                button1.BackgroundImage = Properties.Resources.off;
                flag = false;
                switch (i)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.darkcinema;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.darkcinema2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.darkcinema3;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.darkcinema4;
                        break;
                    default:
                        break;
                }
            }
            return flag;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    e1 = Room(e1);
                    break;
                case 2:
                    e2 = Room(e2); break;
                case 3:
                    e3 = Room(e3); break;
                case 4:
                    e4 = Room(e4); break;
                default:
                    break;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 1;
           
            if (e1 == true)
            {
                pictureBox1.Image = Properties.Resources.cinema;
                button1.BackgroundImage = Properties.Resources.on;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.darkcinema;
                button1.BackgroundImage = Properties.Resources.off;
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 2;
           
            if (e2 == true)
            {
                pictureBox1.Image = Properties.Resources.cinema2;
                button1.BackgroundImage = Properties.Resources.on;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.darkcinema2;
                button1.BackgroundImage = Properties.Resources.off;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = 3;
           
            if (e3 == true)
            {
                pictureBox1.Image = Properties.Resources.cinema3;
                button1.BackgroundImage = Properties.Resources.on;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.darkcinema3;
                button1.BackgroundImage = Properties.Resources.off;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i = 4;
           
            if (e4 == true)
            {
                pictureBox1.Image = Properties.Resources.cinema4;
                button1.BackgroundImage = Properties.Resources.on;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.darkcinema4;
                button1.BackgroundImage = Properties.Resources.off;
            }
        }

        private void αρχικήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form6();
            myForm.Show();
            this.Visible = false;
        }

        private void ηλεκτρικέςΣυσκευέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void καφετέριαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form9();
            myForm.Show();
            this.Visible = false;
        }

        private void ηλεκτρικήΣκούπαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form8();
            myForm.Show();
            this.Visible = false;
        }

        private void ηλεκτρικήΣκούπαToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var myForm = new Form10();
            myForm.Show();
            this.Visible = false;
        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέγετε με το ποντίκι σας την αίθουσα που θέλετε και πατώντας το κουμπί ανάβετε το φως αν δεν είναι ήδη αναμμένο ή το σβήνετε αν είναι. ");
        }
    }
}
