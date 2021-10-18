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
    public partial class Form5 : Form
    {
        
        int d = 0;
        int l = 0;
        int c = 0;
        int s = 0;
        int f = 0;
        int p = 0;
        int h = 0;
        int dp = 0;
        int dpepper;
        int haribo;
        int pop;
        int doritos;
        int lays;
        int coke;
        int sprite;
        int fanta;
        double price;
        int seats;
        public Form5(int numofseats)
        {
        
            InitializeComponent();
            seats = numofseats;
            label2.BackColor = Color.Transparent;
        }

        private int buy(int b,TextBox c)
        {
            b = b + 1;
            c.Text = b.ToString();
            return b;
        }

        private int notbuy( int b, TextBox c)
        {
            if (b > 0)
            {
                b = b - 1;
            }
                c.Text = b.ToString();
            return b;
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form2(price);
            myForm.Show();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            price= seats * 7;
            textBox1.Text = price.ToString()+"$";
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           doritos= buy( doritos, textBox2);
            price = price + 1.5;
            d = d + 1;
            textBox1.Text = price.ToString() + "$";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           doritos= notbuy( doritos, textBox2);
            if (d > 0)
            {
                price = price - 1.5;
                d = d - 1;
            }
            textBox1.Text = price.ToString() + "$";
        }

        private void button7_Click(object sender, EventArgs e)
        {
           lays= buy( lays, textBox4);
            price = price + 1.2;
            l = l + 1;
            textBox1.Text = price.ToString() + "$";
        }

        private void button6_Click(object sender, EventArgs e)
        {
          lays=  notbuy( lays, textBox4);
            if (l > 0)
            {
                price = price - 1.2;
                l = l - 1;
            }
            textBox1.Text = price.ToString() + "$";
        }

        private void button5_Click(object sender, EventArgs e)
        {
          coke= buy( coke, textBox3);
            price = price + 1;
            c = c + 1;
            textBox1.Text = price.ToString() + "$";
        }

        private void button4_Click(object sender, EventArgs e)
        {
         coke= notbuy( coke, textBox3);
            if (c > 0)
            {
                price = price - 1;
                c = c - 1;
            }
            textBox1.Text = price.ToString() + "$";
        }

        private void button9_Click(object sender, EventArgs e)
        {
          sprite=  buy( sprite, textBox5);
            price = price + 1.0;
            s = s + 1;
            textBox1.Text = price.ToString() + "$";
        }

        private void button8_Click(object sender, EventArgs e)
        {
           sprite= notbuy( sprite, textBox5);
            if (s > 0)
            {
                price = price - 1;
                s = s - 1;
            }
            textBox1.Text = price.ToString() + "$";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fanta= buy(fanta, textBox6);
            price = price + 1.5;
            f = f + 1;
            textBox1.Text = price.ToString() + "$";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fanta = notbuy(fanta, textBox6);
            if (f > 0)
            {
                price = price - 1;
                f = f - 1;
            }
            textBox1.Text = price.ToString() + "$";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            haribo = buy(haribo, textBox9);
            price = price + 1.3;
            h = h + 1;
            textBox1.Text = price.ToString() + "$";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            haribo = notbuy(haribo, textBox9);
            if (h > 0)
            {
                price = price - 1.3;
                h = h - 1;
            }
            textBox1.Text = price.ToString() + "$";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pop = buy(pop, textBox11);
            price = price + 2.5;
            p = p + 1;
            textBox1.Text = price.ToString() + "$";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pop = notbuy(pop, textBox11);
            if (p > 0)
            {
                price = price - 2.5;
                p = p - 1;
            }
            textBox1.Text = price.ToString() + "$";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            dpepper = buy(dpepper, textBox10);
            price = price + 1;
            dp = dp + 1;
            textBox1.Text = price.ToString() + "$";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            dpepper = notbuy(dpepper, textBox10);
            if (dp > 0)
            {
                price = price - 1;
                dp = dp - 1;
            }
            textBox1.Text = price.ToString() + "$";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var myForm = new Form3();
            myForm.Show();
            this.Close();
        }
    }
}
