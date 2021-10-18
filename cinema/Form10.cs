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
    public partial class Form10 : Form
    {
       
        bool flag1=false;
        bool flag2 = false;
        bool flag3 = false;
        Random random = new Random();
        bool flag4 = false;
        int[,] seats=new int[5,6];        
        string item1;
        string item2;
        string item3;
        string item4;
        Random r = new Random();
        string[] words ={ "ζευγάρι κλειδιά", "πορτοφόλι", "κινητό" };
        int room;
        public Form10()
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

        private void καφετέριαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form9();
            myForm.Show();
            this.Visible = false;
        }
        

        private void Clean(int room,int seat1,int seat2,int seat3,int seat4,int dirtyseat)
        {
            richTextBox1.Text = "Στην αίθουσα "+room.ToString() + " στη θέση "+seat1.ToString()+" έχει βρεθεί ενα "+item1+ ", στη θέση " + seat2.ToString() + " έχει βρεθεί ένα " + item2 + ", στη θέση " + seat3.ToString() + " έχει βρεθεί ένα " + item3 + " και στη θέση " + seat4.ToString() + " έχει βρεθεί ένα " + item4+". Επίσης, η θέση "+dirtyseat.ToString() + " είναι πολύ λερωμένη οπότε καλό θα ήταν να ειδοποιηθεί ο κατοχός της, ώστε να είναι πιο προσεκτικός την επομενή φορά";

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            room = 2;
            if (flag2 == false)
            {
                
                seats[2,1] = random.Next(1, 54);               
                seats[2,2] = random.Next(1, 54);
                seats[2,3] = random.Next(1, 54);
                seats[2,4] = random.Next(1, 54);
                seats[2,5] = random.Next(1, 54);
                item1 = words[r.Next(0, words.Length)];
                item2 = words[r.Next(0, words.Length)];
                item3 = words[r.Next(0, words.Length)];
                item4 = words[r.Next(0, words.Length)];
                flag2 = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clean(room,seats[room,1], seats[room,2], seats[room,3], seats[room,4], seats[room,5]);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            room = 3;
            if (flag3 == false)
            {
                
                seats[3,1] = random.Next(1, 54);
                seats[3,2] = random.Next(1, 54);
                seats[3,3] = random.Next(1, 54);
                seats[3,4] = random.Next(1, 54);
                seats[3,5] = random.Next(1, 54);
                item1 = words[r.Next(0, words.Length)];
                item2 = words[r.Next(0, words.Length)];
                item3 = words[r.Next(0, words.Length)];
                item4 = words[r.Next(0, words.Length)];
                flag3 = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            room = 4;
            if (flag4 == false)
            {
                
                seats[4,1] = random.Next(1, 54);
                seats[4,2] = random.Next(1, 54);
                seats[4,3] = random.Next(1, 54);
                seats[4,4] = random.Next(1, 54);
                seats[4,5] = random.Next(1, 54);
                item1 = words[r.Next(0, words.Length)];
                item2 = words[r.Next(0, words.Length)];
                item3 = words[r.Next(0, words.Length)];
                item4 = words[r.Next(0, words.Length)];
                flag4 = true;
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            room = 1;
            if (flag1 == false)
            {
                
                seats[1,1] = random.Next(1, 54);
                seats[1,2] = random.Next(1, 54);
                seats[1,3] = random.Next(1, 54);
                seats[1,4] = random.Next(1, 54);
                seats[1,5] = random.Next(1, 54);
                item1 = words[r.Next(0, words.Length)];
                item2 = words[r.Next(0, words.Length)];
                item3 = words[r.Next(0, words.Length)];
                item4 = words[r.Next(0, words.Length)];
                flag1 = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέγετε την αίθουσα που θέλετε να καθαριστεί και πατάτε το κουμπί εκκίνηση σκούπας. Η σκούπα καθαρίζοντας την αίθουσα θα σας ενημέρωση στην οθόνη για τυχών απολεσθέντα αντικείμενα ή παρατεταμένες φθορές στο χώρο, αλλά και τη θέση στην οποία αυτά βρίσκονται.");
        }
    }
}
