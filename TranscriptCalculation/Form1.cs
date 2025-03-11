using TranscriptCalculation.Data;
using TranscriptCalculation.Enums;

namespace TranscriptCalculation
{
    public partial class Form1 : Form
    {
        Ders secilenDers;
        List<Ders> secilenDersler = new List<Ders>()
        {
            new Ders{Ad="Matematik", Kredi=10,Kod="MAT101"},
            new Ders{Ad="TÜRKÇE", Kredi=1,Kod="MAT101"},
            new Ders{Ad="ÝNKILAP TARÝHÝ", Kredi=2,Kod="TAR101"},
        };
        public void NotlarýEkle()
        {
            cmbAraSinav.Items.Add("Seçiniz");
            cmbFinal.Items.Add("Seçiniz");
            for (int i = 0; i <= 100; i++)
            {
                cmbAraSinav.Items.Add(i);
                cmbFinal.Items.Add(i);

            }
            cmbAraSinav.SelectedIndex = cmbFinal.SelectedIndex = 0;
        }
        public void DersleriGetir()
        {
            dgvDersler.DataSource = null;
            dgvDersler.DataSource = secilenDersler;

        }
        public Form1()
        {
            InitializeComponent();
            NotlarýEkle();
            DersleriGetir();
        }
        public void HarfNotuAta(Ders ders)
        {
            double sonNot = ders.Vize * 0.4 + ders.Final * 0.6;
            switch (sonNot)
            {
                case <= 100 and >= 90:
                    ders.HarfNotu = Enums.HarfNotu.AA;
                    break;
                case <= 90 and >= 80:
                    ders.HarfNotu = Enums.HarfNotu.BA;
                    break;
                case <= 80 and >= 70:
                    ders.HarfNotu = Enums.HarfNotu.BB;
                    break;
                case <= 70 and >= 60:
                    ders.HarfNotu = Enums.HarfNotu.CB;
                    break;
                case <= 60 and >= 55:
                    ders.HarfNotu = Enums.HarfNotu.CC;
                    break;
                case <= 55 and >= 50:
                    ders.HarfNotu = Enums.HarfNotu.DC;
                    break;
                case <= 50 and >= 45:
                    ders.HarfNotu = Enums.HarfNotu.DD;
                    break;
                default:
                    ders.HarfNotu = Enums.HarfNotu.FF;
                    break;
            }
        }

        private void dgvDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSecilenDers.Text = "ÞEÇÝLEN DERS";
            secilenDers = (Ders)dgvDersler.SelectedRows[0].DataBoundItem;
            lblSecilenDers.Text += " " + secilenDers.Kod + " " + secilenDers.Ad + " " + secilenDers.Kredi;
        }

        private void btnGNO_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            uint toplamKredi = 0;
            foreach (var ders in secilenDersler)
            {
                toplam += (((int)ders.HarfNotu) / 10.0) * ders.Kredi;
                toplamKredi += (ders.Kredi);
            }
            toplam /= toplamKredi;
            lblSecilenDersler.Text = "GNO" + toplam;
        }

        private void btnHarfNotu_Click(object sender, EventArgs e)
        {
            if (secilenDers != null)
            {
                if (cmbAraSinav.SelectedIndex == 0 || cmbFinal.SelectedIndex == 0)
                {
                    MessageBox.Show("Lütfen Arasýnav/Finali Seçiniz");
                    return;
                }
                secilenDers.Vize = Convert.ToUInt32(cmbAraSinav.SelectedItem);
                secilenDers.Final = Convert.ToUInt32(cmbFinal.SelectedItem);
                HarfNotuAta(secilenDers);
                DersleriGetir();
            }
            else
                MessageBox.Show("Lütfen Ders Seçiniz");
        }
    }
}
