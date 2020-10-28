using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Today();

            tablo.Columns.Add("Isim", typeof(string));
            tablo.Columns.Add("CurrencyName", typeof(string));
            tablo.Columns.Add("ForexBuying", typeof(string));
            tablo.Columns.Add("ForexSelling", typeof(string));
            tablo.Columns.Add("BanknoteBuying", typeof(string));
            tablo.Columns.Add("BanknoteSelling", typeof(string));
            tablo.Columns.Add("CrossRateUsd", typeof(string));
            tablo.Columns.Add("Unit", typeof(string));
            dataGridView1.DataSource = tablo;
            dataGridView1.AllowUserToAddRows = false;

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
            DateTime bugun = DateTime.Now;
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

                dataGridView1.DataSource = tablo;
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
                lblGun.Text = ("0"+dateTimePicker1.Value.Day.ToString());
            }
            if (Convert.ToInt32(lblAy.Text) < 10)
            {
                lblAy.Text = ("0" + dateTimePicker1.Value.Month.ToString());
            }

        }
    }
}


