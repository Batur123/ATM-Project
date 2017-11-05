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
    public partial class BorcGoruntu : Form
    {
        public BorcGoruntu()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AnaSayfa a = new AnaSayfa();
            a.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Bakiye_TextChanged(object sender, EventArgs e)
        {

        }
        public static int borc;

        private void BorcGoruntu_Load(object sender, EventArgs e)
        {


            Bakiye.Text = Bankamatik.bakiye.ToString();
            //listBox1.Items.Add(ParaCekme.CekilenTutar + "\n");
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
