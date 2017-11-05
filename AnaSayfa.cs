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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
           
           
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Bankamatik a = new Bankamatik();
            
            label2.Text = Bankamatik.kullanici;
            HesapNo.Text = Bankamatik.hesapno;
            Bakiye.Text = Bankamatik.bakiye.ToString();
           
        }

        private void Bakiye_TextChanged(object sender, EventArgs e)
        {

        }

        private void MevcutBaiye_TextChanged(object sender, EventArgs e)
        {

        }

        private void HesapNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParaCekme a = new ParaCekme();
            a.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bankamatik a = new Bankamatik();
            a.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ParaYatirma a = new ParaYatirma();
            a.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hakkında a = new Hakkında();
            a.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BorcGoruntu a = new BorcGoruntu();
            a.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}

