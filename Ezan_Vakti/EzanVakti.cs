using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Ezan_Vakti
{
    public partial class EzanVakti : Form
    {
        public EzanVakti()
        {
            InitializeComponent();
        }

        public string adres;

        public void EzanVakti_Load(object sender, EventArgs e)
        {
            this.Hide();
            Baslatici.Start();
        }

        public void EzanVaktiBaslat()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                if (File.Exists("ayarlar.ayr"))
                {
                    TextReader textReader = new StreamReader("ayarlar.ayr");
                    string ayarsatiri = textReader.ReadToEnd();
                    string[] ayarlar = ayarsatiri.Split(' ');
                    textReader.Close();

                    if (ayarlar.Length != 2)
                    {
                        SehirSecisEkrani sehirEkrani = new SehirSecisEkrani();

                        this.Hide();
                        sehirEkrani.Show();
                    }
                    else
                    {
                        if (ayarlar[1].Length >= 37)
                        {
                            if (ayarlar[1].Substring(0, 37) == "https://namazvakitleri.diyanet.gov.tr")
                            {
                                this.Show();
                                adres = ayarlar[1];

                                EzanVaktiGetir();
                            }
                            else
                            {
                                SehirSecisEkrani sehirEkrani = new SehirSecisEkrani();

                                this.Hide();
                                sehirEkrani.Show();
                            }
                        }
                        else
                        {
                            SehirSecisEkrani sehirEkrani = new SehirSecisEkrani();

                            this.Hide();
                            sehirEkrani.Show();
                        }
                    }
                }
                else
                {
                    SehirSecisEkrani sehirEkrani = new SehirSecisEkrani();

                    this.Hide();
                    sehirEkrani.Show();
                }
            }
            else
            {
                MessageBox.Show("İnternet bağlantınızı kontrol edin!", "Ezan Vakti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void EzanVaktiGetir()
        {
            try
            {
                WebRequest istek = HttpWebRequest.Create(adres);
                WebResponse cevap;
                cevap = istek.GetResponse();
                StreamReader donenbilgiler = new StreamReader(cevap.GetResponseStream());
                string gelen = donenbilgiler.ReadToEnd();

                int namazvakit = gelen.IndexOf("_imsakTime") + 14;
                int namazvakitbitis = gelen.Substring(namazvakit).IndexOf("\"");
                string vakit = gelen.Substring(namazvakit, namazvakitbitis);
                labelImsak.Text = vakit;

                namazvakit = gelen.IndexOf("_gunesTime") + 14;
                namazvakitbitis = gelen.Substring(namazvakit).IndexOf("\"");
                vakit = gelen.Substring(namazvakit, namazvakitbitis);
                labelGunes.Text = vakit;

                namazvakit = gelen.IndexOf("_ogleTime") + 13;
                namazvakitbitis = gelen.Substring(namazvakit).IndexOf("\"");
                vakit = gelen.Substring(namazvakit, namazvakitbitis);
                labelOgle.Text = vakit;

                namazvakit = gelen.IndexOf("_ikindiTime") + 15;
                namazvakitbitis = gelen.Substring(namazvakit).IndexOf("\"");
                vakit = gelen.Substring(namazvakit, namazvakitbitis);
                labelIkindi.Text = vakit;

                namazvakit = gelen.IndexOf("_aksamTime") + 14;
                namazvakitbitis = gelen.Substring(namazvakit).IndexOf("\"");
                vakit = gelen.Substring(namazvakit, namazvakitbitis);
                labelAksam.Text = vakit;

                namazvakit = gelen.IndexOf("_yatsiTime") + 14;
                namazvakitbitis = gelen.Substring(namazvakit).IndexOf("\"");
                vakit = gelen.Substring(namazvakit, namazvakitbitis);
                labelYatsi.Text = vakit;

                int sehirgelen = gelen.IndexOf("<caption>") + 9;
                int sehirbitis = gelen.Substring(sehirgelen).IndexOf(" İçin");
                string sehir = gelen.Substring(sehirgelen, sehirbitis);
                labelSehir.Text = sehir;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Siteden bilgi getirilemedi! \r" + "Hata: " + ex.Message);
                Application.Exit();
            }
        }

        private void Baslatici_Tick(object sender, EventArgs e)
        {
            Baslatici.Stop();
            EzanVaktiBaslat();
        }

        private void linkSehirDegistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SehirSecisEkrani sehirEkrani = new SehirSecisEkrani();

            this.Hide();
            sehirEkrani.Show();
        }
    }
}
