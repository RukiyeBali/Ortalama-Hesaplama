using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortalama_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float ortalama;

            ortalama=Convert.ToSingle(txtOrtalama.Text);

            if (ortalama < 0)
            {
                lblSonuc.Text = "Negatif değer giremessiniz.";
            }

            else if (ortalama < 50)
            {
                lblSonuc.Text = "Kaldınız.";
            }
            else if (ortalama < 70)
            {
                lblSonuc.Text = "Tebrikler geçtiniz.";
            }
            else if (ortalama < 85)
            {
                lblSonuc.Text = "Teşkkür belgesi aldınız.";
            }
            else if (ortalama <= 100)
            {
                lblSonuc.Text = "Takdir belgesi aldınız.";

            }
        }
    }
}
