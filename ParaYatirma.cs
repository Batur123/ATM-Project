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
    public partial class ParaYatirma : Form
    {
        public ParaYatirma()
        {
            InitializeComponent();
        }
        public static int YatirilanTutar;

        private void ParaYatirma_Load(object sender, EventArgs e)
        {
            Bankamatik a = new Bankamatik();
            //string yatırmayazısı;
            //yatırmayazısı = "TL hesabınıza başarıyla yatırılmıştır.";
            //label2.Text = yatırmayazısı.ToString();
            Bakiye.Text = Bankamatik.bakiye.ToString();
            //MevcutBaiye.Text = Bankamatik.tambakiye.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AnaSayfa a = new AnaSayfa();
            a.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //int 
            //public static string yazı;

            string yatırmayazısı;
            yatırmayazısı = "TL hesabınıza başarıyla yatırılmıştır.";
            label2.Text = yatırmayazısı.ToString();
            YatirilanTutar = Convert.ToInt32(textBox1.Text);
            label3.Text = Convert.ToString(YatirilanTutar);
            Bankamatik.bakiye = Bankamatik.bakiye + YatirilanTutar;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void Bakiye_TextChanged(object sender, EventArgs e)
        {
           // YatirilanTutar = Convert.ToInt32(textBox1.Text);
            Bakiye.Text = Convert.ToString(YatirilanTutar + Bankamatik.bakiye);
            

        }
    }
}
