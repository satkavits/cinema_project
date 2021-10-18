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
    public partial class Form4 : Form
    {
        int number;
        int number2;
        int numofseats;
        int i=0;
        public Form4(int numb,int numb2,int list)
        {
            InitializeComponent();
          number = numb;
          number2 = numb2;
           numofseats=list;
           
            
        }

        private void reserve()
        {
            if (number == 1 & number2 == 1)
            {
                button33.BackColor = Color.Red;
                button34.BackColor = Color.Red;
                button35.BackColor = Color.Red;
            }
            if (number == 2 & number2 == 1)
            {
                button33.BackColor = Color.Red;
                button34.BackColor = Color.Red;
                button25.BackColor = Color.Red;
                button23.BackColor = Color.Red;
                button22.BackColor = Color.Red;
            }
            if (number == 5 & number2 == 2)
            {
                button33.BackColor = Color.Red;
                button32.BackColor = Color.Red;
                
            }
            if (number == 1 & number2 == 8)
            {
                button33.BackColor = Color.Red;
                button34.BackColor = Color.Red;
                button35.BackColor = Color.Red;
                button25.BackColor = Color.Red;
                button23.BackColor = Color.Red;
                button37.BackColor = Color.Red;
                button36.BackColor = Color.Red;
                button38.BackColor = Color.Red;
            }
            if (number == 4 & number2 == 4)
            {
                button33.BackColor = Color.Red;
                button34.BackColor = Color.Red;
                button35.BackColor = Color.Red;
            }
            if (number == 3 & number2 == 3)
            {
                button13.BackColor = Color.Red;
                button14.BackColor = Color.Red;
                button15.BackColor = Color.Red;
            }

        }
        private void Buttons(Button abutton)
        {
            if (abutton.BackColor != Color.Red)
            {
                if (abutton.BackColor != Color.Green)
                {
                    if (numofseats > i)
                    {
                        abutton.BackColor = Color.Green;
                        i = i + 1;
                    }
                }
                else
                {
                    abutton.BackColor = Color.Gray;
                    i = i - 1;
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            reserve();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buttons(button1);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (numofseats==i)
            {
                var myForm = new Form5(numofseats);
                myForm.Show();
                this.Close();
            }
            
        }

       

        private void button46_Click(object sender, EventArgs e)
        {
            Buttons(button46);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buttons(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buttons(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Buttons(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buttons(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Buttons(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Buttons(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Buttons(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Buttons(button9);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Buttons(button18);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Buttons(button17);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Buttons(button16);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Buttons(button15);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Buttons(button14);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Buttons(button13);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Buttons(button12);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Buttons(button11);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Buttons(button10);
        }
        

        private void button45_Click(object sender, EventArgs e)
        {
            Buttons(button45);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Buttons(button44);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Buttons(button43);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Buttons(button42);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Buttons(button41);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Buttons(button40);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Buttons(button39);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Buttons(button38);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Buttons(button37);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Buttons(button27);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Buttons(button35);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Buttons(button26);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Buttons(button25);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Buttons(button24);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Buttons(button23);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Buttons(button22);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Buttons(button21);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Buttons(button20);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Buttons(button19);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Buttons(button36);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Buttons(button34);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Buttons(button33);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Buttons(button32);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Buttons(button31);
        }
        private void button30_Click(object sender, EventArgs e)
        {
            Buttons(button30);
        }


        private void button29_Click(object sender, EventArgs e)
        {
            Buttons(button29);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Buttons(button28);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Buttons(button54);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Buttons(button53);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Buttons(button52);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Buttons(button51);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Buttons(button50);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Buttons(button49);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Buttons(button48);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Buttons(button47);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            var myForm = new Form3();
            myForm.Show();
            this.Close();
        }
    }
}
