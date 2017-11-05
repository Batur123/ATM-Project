using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankamatik
{
    public partial class Bankamatik : Form
    {
        public Bankamatik()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static string kullanici;
        public static int bakiye;
        public static string hesapno;
       
        
        private void button13_Click(object sender, EventArgs e)
        {
            int sifreBatu = 1945, sifreAhmet = 6666, sifreFurkan = 1234, sifreYusuf = 9977, sifreCan = 1111;

            if (textBox1.Text == sifreBatu.ToString())
            {
                kullanici = "Batuhan ÖZKOÇ";
                bakiye = 3500;
                
                hesapno = "5455-7565-8842-9874";
                AnaSayfa a = new AnaSayfa();
                a.Show();
                Hide();
            }
            else if (textBox1.Text == sifreAhmet.ToString())
            {
                
                kullanici ="Ahmet Hakan TANYILMAZ";
                bakiye = 2750;
                
                hesapno = "3555-7585-8382-1283";
                AnaSayfa a = new AnaSayfa();
                a.Show();
                Hide();
            }
            else if (textBox1.Text == sifreFurkan.ToString())
            {

                kullanici = "Furkan AKYÜZ";
                bakiye = 4500;
                hesapno = "4543-1470-4321-4555";
                
                AnaSayfa a = new AnaSayfa();
                a.Show();
                Hide();
            }
            else if (textBox1.Text == sifreYusuf.ToString())
            {

                kullanici = "Yusuf SAHA";
                bakiye = 8000;
                
                hesapno = "1234-1234-4332-4321";
                AnaSayfa a = new AnaSayfa();
                a.Show();
                Hide();
            }
            else if (textBox1.Text == sifreCan.ToString())
            {

                kullanici = "CAN KAPLAN XO";
                bakiye = 15000;

                hesapno = "3131-4242-5353-6464";
                AnaSayfa a = new AnaSayfa();
                a.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("YANLIŞ ŞİFRE");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SayiTik(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void Handled(object sender, KeyPressEventArgs e)
        {
            if(textBox1.TextLength == 4)
            {
                e.Handled = true;
            }

            
        }
    }
}
