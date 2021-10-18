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
    public partial class Form3 : Form
    {
        bool f1=false;
        bool f2 = false;
        bool f3 = false;
        int numb;
        int numb2;
        int list;
        public Form3()
        {
            InitializeComponent();
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label3.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numb = 1;
            f1 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numb = 3;
            f1 = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f1 = true;
            numb = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numb = 4;
            f1 = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numb = 5;
            f1 = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numb = 6;
            f1 = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numb = 7;
            f1 = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(f1==true & f2 == true & f3==true)
            {
                var myForm = new Form4(numb, numb2, list);
                myForm.Show();
                this.Close();
            }
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numb2 = 1;
            f2 = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numb2 = 2;
            f2 = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            numb2 = 3;
            f2 = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            numb2 = 4;
            f2 = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            numb2 = 5;
            f2 = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            numb2 = 6;
            f2 = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            numb2 = 7;
            f2 = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            numb2 = 8;
            f2 = true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "Joker ονομάζεται η αμερικανική ταινία ψυχολογικού θρίλερ του 2019 σε σκηνοθεσία Τοντ Φίλιπς, ο οποίος συμμετείχε και στη συγγραφή του σεναρίου μαζί με τον Σκοτ Σίλβερ. Βασισμένη σε χαρακτήρες της DC Comics, έχει πρωταγωνιστή τον Χοακίν Φίνιξ ως Joker.  \r\nΕισπράξεις: 1,061 δισεκατομμύρια USD  \r\nΗμερομηνία κυκλοφορίας στο σινεμά: 31 Αυγούστου 2019  \r\nΣκηνοθέτης: Τοντ Φίλιπς  \r\nΠροϋπολογισμός: $55 - 70 εκ.";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "Οι Μαχητές των Δρόμων 8 είναι αμερικανική ταινία δράσης του 2017 σε σκηνοθεσία του F. Gary Gray και σενάριο του Chris Morgan.\r\nΗμερομηνία κυκλοφορίας: 13 Απριλίου 2017(Ελλάδα)\r\nΣκηνοθέτης: Γκάρι Γκρέι\r\nΕισπράξεις: 1,239 δισεκατομμύρια USD\r\nΠροϋπολογισμός: 250 εκατομμύρια USD\r\nΣειρές ταινιών: Οι μαχητές των δρόμων";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "ΠεριγραφήTo Star Wars: Ο Τελευταίoς Jedi, είναι μία αμερικανική επική space opera ταινία του 2017, σε σκηνοθεσία και σενάριο Ράιαν Τζόνσον. Η ταινία είναι το δεύτερος μέρος της σίκουελ τριλογίας του Star Wars και έπεται του Star Wars: The Force Awakens. \r\nΗμερομηνία κυκλοφορίας: 14 Δεκεμβρίου 2017(Ελλάδα)\r\nΣκηνοθέτης: Ράιαν Τζόνσον\r\nΠροϋπολογισμός: $200–317 εκατομμύρια\r\nΕισπράξεις: 1,321 δισεκατομμύρια USD\r\nΣενάριο: Ράιαν Τζόνσον";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "Ο Ντάμπο είναι αμερικανική ταινία περιπέτειας και φαντασίας που κυκλοφόρησε στις 29 Μαρτίου του 2019. Η σκηνοθεσία της έγινε από τον Τιμ Μπάρτον και το σενάριό της γράφτηκε από τον Έχρεν Κρούγκερ.\r\nΗμερομηνία κυκλοφορίας στο σινεμά: 11 Μαρτίου 2019(Λος Άντζελες) \r\n Σκηνοθέτης: Τιμ Μπάρτον \r\nΕισπράξεις: 353,3 εκατομμύρια USD \r\nΠροϋπολογισμός: 170 εκατομμύρια USD ";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "Το Εκδικητές: Η Τελευταία Πράξη είναι αμερικανική ταινία υπερηρώων του 2019, βασισμένη στους υπερήρωες των Marvel Comics, τους Εκδικητές. Παράχθηκε από τη Marvel Studios και διατέθηκε για διανομή από την Walt Disney Studios Motion Pictures. \r\nΗμερομηνία κυκλοφορίας: 25 Απριλίου 2019(Ελλάδα)\r\nΣκηνοθέτες: Αδέλφια Ρούσο\r\nΕισπράξεις: 2,798 δισεκατομμύρια USD\r\nΠροϋπολογισμός: 356 εκατομμύρια USD(2019)";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

       
        private void button8_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "Το Αυτό είνα αμερικανική ταινία τρόμου, σε σκηνοθεσία Andy Muschietti και κείμενο Gary Dauberman, βασισμένο στο ομότιτλο μυθιστόρημα του Στίβεν Κινγκ του 1986.\r\nΗμερομηνία κυκλοφορίας στο σινεμά: 26 Αυγούστου 2019(Λος Άντζελες)\r\nΣκηνοθέτης: Andrés Muschietti\r\nΕισπράξεις: $472 million\r\nΙστορία από: Στίβεν Κινγκ\r\nΠροϋπολογισμός: 79 εκατομμύρια USD";
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Text = "Ο Βασιλιάς των Λιονταριών είναι ταινία μιούζικαλ της Walt Disney Pictures σε σκηνοθεσία του Τζον Φαβρώ. Η ταινία αποτελεί φωτορεαλιστικό ριμέικ σε υπολογιστή της ομώνυμης ταινίας της Disney του 1994. \r\nΗμερομηνία κυκλοφορίας στο σινεμά: 9 Ιουλίου 2019(Χόλυγουντ)\r\nΣκηνοθέτης: Τζον Φαβρό\r\nΕισπράξεις: $1.656 billion\r\nΠροϋπολογισμός: 260 εκατομμύρια USD(2016)";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            list = listBox1.SelectedIndex+1;
            f3 = true;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            this.Close();
        }
    }
}
