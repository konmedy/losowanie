using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace losowanieAleWWinForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        public int numer;

        private void txt1_Enter(object sender, KeyEventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            Random rnd = new Random();
            numer = rnd.Next(1,100);
        }

        private void button3_Click(object sender, EventArgs e) {
            if (txt1.Text == numer.ToString())
            {
                MessageBox.Show("Zgadłeś! Losowa liczba to " + numer, "Zwycięstwo!");
                txt1.ReadOnly = true;
                txt1.Text = "";
                button3.Enabled = false;
            }
            else if (int.Parse(txt1.Text) < numer)
            {
                MessageBox.Show("Twoja liczba jest za mała", "Nieprawidłowy");
            }
            else if (int.Parse(txt1.Text) > numer)
            {
                MessageBox.Show("Twoja liczba jest za duża", "Nieprawidłowy");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == "6392")
            {
                txt1.Text = numer.ToString();
            }
            else
            {
                MessageBox.Show("złe hasło", "Debug");
            }
            
        }

        private void button4_Click(object sender, EventArgs e) {
            Random rnd = new Random();
            switch (trackBar1.Value)
            {
                case 1://100
                    numer = rnd.Next(1, 100);
                    label3.Text = "Wygenerowano nową liczbę od 1 do 100";
                    txt1.ReadOnly = false;
                    button3.Enabled = true;
                    break;
                case 2://500
                    numer = rnd.Next(1, 500);
                    label3.Text = "Wygenerowano nową liczbę od 1 do 500";
                    txt1.ReadOnly = false;
                    button3.Enabled = true;
                    break;
                case 3://1000
                    numer = rnd.Next(1, 1000);
                    label3.Text = "Wygenerowano nową liczbę od 1 do 1000";
                    txt1.ReadOnly = false;
                    button3.Enabled = true;
                    break;
                case 4://2500
                    numer = rnd.Next(1, 2500);
                    label3.Text = "Wygenerowano nową liczbę od 1 do 2500";
                    txt1.ReadOnly = false;
                    button3.Enabled = true;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            oMnie om = new oMnie();
            om.ShowDialog();
        }
    }
}
