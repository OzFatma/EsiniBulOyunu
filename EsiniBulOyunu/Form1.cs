using EsiniBulOyunu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBulOyunu
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int satir = 2;
        int sutun = 2;
        int kartBoyutBoy = 95;
        int kartBoyutEn = 85;
        int kartBosluk = 5;
        int sayac, bulunan;
        public int ToplamKart { get { return satir * sutun; } }

        int[] cicekler;
        int[] cicekHavuzu;
        List<PictureBox> kartlar;
        List<PictureBox> acilanlar;
        private readonly SeviyeSecenekleri _seviye;

        int dakika = 0;
        int saniye = 1;

        public Form1(SeviyeSecenekleri seviye)
        {
            _seviye = seviye;
            SeviyeBelirle();
            InitializeComponent();
            acilanlar = new List<PictureBox>();
            CicekHavuzunuDoldur();
            KartlariDiz();

            tmrDakika.Interval = 60000;
            tmrSaniye.Interval = 1000;
        }

        private void SeviyeBelirle()
        {
            switch (_seviye)
            {
                case SeviyeSecenekleri.Kolay:
                    satir = 4;
                    sutun = 4;
                    break;
                case SeviyeSecenekleri.Orta:
                    satir = 6;
                    sutun = 6;
                    break;
                case SeviyeSecenekleri.Zor:
                    satir = 8;
                    sutun = 8;
                    break;
                default:
                    throw new Exception("Hatalı bir işlem gerçekleştirdiniz.");

            }
        }

        private void KartlariDiz()
        {
            CicekleriDoldur();

            kartlar = new List<PictureBox>();
            pnlKartlar.Height = satir * (kartBoyutBoy + kartBosluk);
            pnlKartlar.Width = sutun * (kartBoyutEn + kartBosluk);
            ClientSize = new Size(pnlKartlar.Width + 30, pnlKartlar.Height + 30);

            for (int i = 0; i < ToplamKart; i++)
            {
                PictureBox pb = new PictureBox();
                kartlar.Add(pb);
                pb.Click += Pb_Click;
                pb.Tag = i;
                pb.BackColor = Color.DarkSeaGreen;
                pb.Height = kartBoyutBoy;
                pb.Width = kartBoyutEn;
                pb.Left = i % sutun * (kartBoyutEn + kartBosluk);
                pb.Top = i / sutun * (kartBoyutBoy + kartBosluk);
                pb.Image = Resources.kapak;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.BorderStyle = BorderStyle.Fixed3D;
                pnlKartlar.Controls.Add(pb);
            }
        }

        private void CicekHavuzunuDoldur()
        {
            cicekHavuzu = Enumerable.Range(1, 50).ToArray();
            Karistirici(cicekHavuzu);
        }

        private void CicekleriDoldur()
        {
            cicekler = new int[ToplamKart];
            Array.Copy(cicekHavuzu, cicekler, ToplamKart / 2);
            Array.Copy(cicekHavuzu, 0, cicekler, ToplamKart / 2, ToplamKart / 2);
            Karistirici(cicekler);
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            tmrSaniye.Start(); tmrDakika.Start();
            sayac++;
            if (acilanlar.Count == 1 && pb == acilanlar[0])
                return;

            if (acilanlar.Count == 2)
                AcilanlariKapat();

            acilanlar.Add(pb);
            KartlariAc(pb);


            if (acilanlar.Count == 2 && AcilanlarAyni())
            {
                bulunan++;
                Thread.Sleep(275);
                AyniKartlariGizle();
                if (bulunan == ToplamKart / 2)
                {
                    tmrSaniye.Stop(); tmrDakika.Stop();
                    MessageBox.Show($"Oyunu { sayac} deneme ile bitirdiniz. Tamamlama süreniz: {lblDk.Text} dk : {lblSn.Text} sn");

                }
            }
        }

        private void AyniKartlariGizle()
        {
            foreach (PictureBox pictureBox in acilanlar)
            {
                pictureBox.Hide();
            }
            acilanlar.Clear();
        }

        private bool AcilanlarAyni()
        {
            int index1 = (int)acilanlar[0].Tag;
            int index2 = (int)acilanlar[1].Tag;
            return cicekler[index1] == cicekler[index2];
        }

        private void KartlariKapat(PictureBox pb)
        {
            pb.Image = Resources.kapak;
        }
        private void AcilanlariKapat()
        {
            foreach (PictureBox pictureBox in kartlar)
            {
                KartlariKapat(pictureBox);
            }
            acilanlar.Clear();
        }

        private void KartlariAc(PictureBox pb)
        {
            int index = (int)pb.Tag;
            int cicekNo = cicekler[index];
            pb.Image = (Bitmap)Resources.ResourceManager.GetObject("_" + cicekNo);
            pb.Refresh();
        }

        private void tmrDakika_Tick(object sender, EventArgs e)
        {
            dakika++;
            lblDk.Text = Convert.ToString(dakika);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void tmrSaniye_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                saniye = 0;
            }
            lblSn.Text = Convert.ToString(saniye.ToString("00"));
            saniye++;
        }

        private void tsmKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmYeniOyun_Click(object sender, EventArgs e)
        {
            OyunaBaslarken ob = new OyunaBaslarken();
            DialogResult dr = MessageBox.Show(
                "Devam etmekte olan oyununuz kapatılacaktır. Onaylıyor musunuz?",
                "Oyun kapatılsın mı?",
                MessageBoxButtons.YesNo
                );
            if (dr == DialogResult.Yes)
                Close();
            else
                return;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            KartOnIzleme();
        }

        private void KartOnIzleme()
        {
            foreach (PictureBox pictureBox in kartlar)
            {
                KartlariAc(pictureBox);
            }
            Thread.Sleep(1500);
            foreach (PictureBox pictureBox1 in kartlar)
            {
                KartlariKapat(pictureBox1);
            }
        }

        private void Karistirici<T>(IList<T> list)
        {
            T gecici;
            int rastgeleSecilen;
            for (int i = 0; i < list.Count - 1; i++)
            {
                rastgeleSecilen = rnd.Next(i, list.Count);
                gecici = list[i];
                list[i] = list[rastgeleSecilen];
                list[rastgeleSecilen] = gecici;
            }
        }

    }
}
