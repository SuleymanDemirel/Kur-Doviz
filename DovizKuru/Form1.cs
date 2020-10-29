using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace DovizKuru
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        XmlDocument xmlDocument = new XmlDocument();
        DataTable tablo = new DataTable();
        DateTime bugun = DateTime.Now;
        private void Form1_Load(object sender, EventArgs e)
        {
         
            Today();
            tabloOlustur();
            
            dgwVeriler.DataSource = tablo;
            dgwVeriler.AllowUserToAddRows = false;

            tablo.Columns.Add(bugun.Date.ToShortDateString(), typeof(string));
            dgwVerilerAralik.DataSource = tablo;
            dgwVerilerAralik.AllowUserToAddRows = false;

        }

        private void tabloOlustur()
        {
            tablo.Columns.Add("Isim", typeof(string));
            tablo.Columns.Add("CurrencyName", typeof(string));
            tablo.Columns.Add("ForexBuying", typeof(string));
            tablo.Columns.Add("ForexSelling", typeof(string));
            tablo.Columns.Add("BanknoteBuying", typeof(string));
            tablo.Columns.Add("BanknoteSelling", typeof(string));
            tablo.Columns.Add("CrossRateUsd", typeof(string));
            tablo.Columns.Add("Unit", typeof(string));
        }

        private void btn_GuncelKur_Click(object sender, EventArgs e)
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";

            xmlDocument.Load(today);

            KurCek();
            Today();
        }

        private void Today()
        {
           
            lblGun.Text = bugun.Date.Day.ToString();
            lblAy.Text = bugun.Date.Month.ToString();
            lblYil.Text = bugun.Date.Year.ToString();
        }

        private void KurCek()
        {
            tablo.Clear();
            DateTime tarih = Convert.ToDateTime(xmlDocument.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            for (int i = 0; i <= 18; i++)
            {

                string Isim = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/Isim").InnerXml;
                string CurrencyName = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/CurrencyName").InnerXml;
                string ForexBuying = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/ForexBuying").InnerXml;
                string ForexSelling = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/ForexSelling").InnerXml;
                string BanknoteBuying = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/BanknoteBuying").InnerXml;
                string BanknotSelling = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/BanknoteSelling").InnerXml;
                string CrossRateUSD = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/CrossRateUSD").InnerXml;
                string Unit = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/Unit").InnerXml;

                tablo.Rows.Add(Isim, CurrencyName, ForexBuying, ForexSelling, BanknoteBuying, BanknotSelling, CrossRateUSD, Unit).ToString();

                dgwVeriler.DataSource = tablo;
            }
        }

        private void btn_EskiKur_Click(object sender, EventArgs e)
        {

            string eski = "https://www.tcmb.gov.tr/kurlar/" + lblYil.Text + lblAy.Text + "/" + lblGun.Text + "" + lblAy.Text + "" + lblYil.Text + ".xml";

            xmlDocument.Load(eski);
            KurCek();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblGun.Text = dateTimePicker1.Value.Day.ToString();
            lblAy.Text = dateTimePicker1.Value.Month.ToString();
            lblYil.Text = dateTimePicker1.Value.Year.ToString();

            if (Convert.ToInt32(lblGun.Text) < 10)
            {
                lblGun.Text = ("0" + dateTimePicker1.Value.Day.ToString());
            }
            if (Convert.ToInt32(lblAy.Text) < 10)
            {
                lblAy.Text = ("0" + dateTimePicker1.Value.Month.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.FileName = "Kurlar";
                dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                dosyakaydet.Filter = "Txt Dosyası|*.txt";
                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    TextWriter txt = new StreamWriter(dosyakaydet.FileName);
                    foreach (DataGridViewColumn sutun in dgwVeriler.Columns)
                    {
                        txt.Write(sutun.HeaderText + " | ");
                    }
                    txt.Write("\n");
                    foreach (DataGridViewRow satir in dgwVeriler.Rows)
                    {
                        foreach (DataGridViewCell hucre in satir.Cells)
                        {
                            txt.Write(hucre.Value.ToString() + " : ");
                        }
                        
                        txt.Write("\n");
                    }
                    txt.Close();
                    MessageBox.Show("Kurlar başarıyla kayıt edildi.\n" , "Başarılı!", MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        int sayi = 1;
        private void button2_Click(object sender, EventArgs e)
        {
           
            var aralik = Convert.ToInt32(lblBitisGun.Text) - Convert.ToInt32(lblBaslangicGun.Text);
            lblToplam.Text = lblBaslangicGun.Text;
            for (int i = 0; i <= aralik; i++)
            {
                string eski = "https://www.tcmb.gov.tr/kurlar/" + lblBaslangicYil.Text + lblBaslangicAy.Text + "/" + lblToplam.Text + "" + lblBaslangicAy.Text + "" + lblBaslangicYil.Text + ".xml";

                xmlDocument.Load(eski);

                KurCek2();

                int toplam = Convert.ToInt32(lblBaslangicGun.Text) + sayi;
                if (Convert.ToInt32(lblToplam.Text) < 10)
                {
                    lblToplam.Text = ("0" + toplam.ToString());

                }
                else
                {
                    lblToplam.Text = toplam.ToString();
                }

            }

        }

        private void KurCek2()
        {
            
            DateTime tarih = Convert.ToDateTime(xmlDocument.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            for (int i = 0; i <= 18; i++)
            {

                string Isim = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/Isim").InnerXml;
                string CurrencyName = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/CurrencyName").InnerXml;
                string ForexBuying = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/ForexBuying").InnerXml;
                string ForexSelling = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/ForexSelling").InnerXml;
                string BanknoteBuying = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/BanknoteBuying").InnerXml;
                string BanknotSelling = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/BanknoteSelling").InnerXml;
                string CrossRateUSD = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/CrossRateUSD").InnerXml;
                string Unit = xmlDocument.SelectSingleNode("//Currency[@CrossOrder=" + i + "]/Unit").InnerXml;

                tablo.Rows.Add(Isim, CurrencyName, ForexBuying, ForexSelling, BanknoteBuying, BanknotSelling, CrossRateUSD, Unit).ToString();

                dgwVerilerAralik.DataSource = tablo;
            }
        }

        private void dateBaslangic_ValueChanged(object sender, EventArgs e)
        {
            Convert.ToInt32(lblBaslangicGun.Text = dateBaslangic.Value.Day.ToString());
            lblBaslangicAy.Text = dateBaslangic.Value.Month.ToString();
            lblBaslangicYil.Text = dateBaslangic.Value.Year.ToString();

            if (Convert.ToInt32(lblBaslangicGun.Text) < 10)
            {
                lblBaslangicGun.Text = ("0" + dateBaslangic.Value.Day.ToString());
            }
            if (Convert.ToInt32(lblBaslangicAy.Text) < 10)
            {
                lblBaslangicAy.Text = ("0" + dateBaslangic.Value.Month.ToString());
            }
        }

        private void dateBitis_ValueChanged(object sender, EventArgs e)
        {
            lblBitisGun.Text = dateBitis.Value.Day.ToString();
            lblBitisAy.Text = dateBitis.Value.Month.ToString();
            lblBitisYil.Text = dateBitis.Value.Year.ToString();

            if (Convert.ToInt32(lblBitisGun.Text) < 10)
            {
                lblBitisGun.Text = ("0" + dateBitis.Value.Day.ToString());
            }
            if (Convert.ToInt32(lblBitisAy.Text) < 10)
            {
                lblBitisAy.Text = ("0" + dateBitis.Value.Month.ToString());
            }
        }
        
    }
}


