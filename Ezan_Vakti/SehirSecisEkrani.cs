using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Ezan_Vakti
{
    public partial class SehirSecisEkrani : Form
    {
        public SehirSecisEkrani()
        {
            InitializeComponent();
        }

        private void SehirGetir_Click(object sender, EventArgs e)
        {
            EzanVakti ezanVakti = new EzanVakti();

            string sehir;
            sehir = Clipboard.GetText();

            if (string.IsNullOrEmpty(sehir))
            {
                MessageBox.Show("Lütfen linki kopyalayın!");
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter("ayarlar.ayr");
                streamWriter.WriteLine("Şehir: " + sehir);
                streamWriter.Close();

                MessageBox.Show("Şehir başarıyla ayarlandı!");

                ezanVakti.EzanVaktiBaslat();

                Application.Restart();
            }
        }

        private void SehirSecisEkrani_Load(object sender, EventArgs e)
        {
            Process.Start("https://namazvakitleri.diyanet.gov.tr/");
        }

        private void SehirSecisEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
