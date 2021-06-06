using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBulOyunu
{
    public partial class OyunaBaslarken : Form
    {
        public OyunaBaslarken()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (rbKolay.Checked || rbOrta.Checked || rbZor.Checked)
            {
            SeviyeSecenekleri ss = rbKolay.Checked ? SeviyeSecenekleri.Kolay : (rbOrta.Checked ? SeviyeSecenekleri.Orta : SeviyeSecenekleri.Zor);
            Form1 frmOyunEkrani = new Form1(ss);
            frmOyunEkrani.Show(this);
            Hide();
            }
            else
            {
                MessageBox.Show("Lütfen bir seviye belirleyiniz.");
            }
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
