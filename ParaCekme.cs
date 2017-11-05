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
    public partial class ParaCekme : Form
    {
        public ParaCekme()
        {
            InitializeComponent();
        }

        private void ParaCekme_Load(object sender, EventArgs e)
        {
            Bankamatik a = new Bankamatik();

            
            
            Bakiye.Text = Bankamatik.bakiye.ToString();
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static int CekilenTutar;
        private void button7_Click(object sender, EventArgs e)
        {
            string yatırmayazısı;
            yatırmayazısı = "TL çekme işleminiz için teşekkür ederiz.";
            label2.Text = yatırmayazısı.ToString();
            CekilenTutar = Convert.ToInt32(textBox1.Text);
            label3.Text = Convert.ToString(CekilenTutar);
            Bankamatik.bakiye = Bankamatik.bakiye - CekilenTutar;

            //BorcGoruntu A = new BorcGoruntu();           
            // ÇEKEMEDİM BOZUK GALİBA ListBox1.Items.Add(ParaCekme.CekilenTutar + "\n");
        }

        private void SayiTik2(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AnaSayfa a = new AnaSayfa();
            a.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
