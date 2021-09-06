using System;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace GazeteXML.ODEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //btnOkU_Click ile hem haberturk hemde Milliyet gazetesinin haberleri aynı anda çekilmektedir.
        private void btnOkU_Click(object sender, EventArgs e)
        {
            Thread Thread1 = new Thread(HaberTurkOku);
            Thread1 = new Thread(new ThreadStart(HaberTurkOku));

            Thread Thread2 = new Thread(MilliyetOku);
            Thread2 = new Thread(new ThreadStart(MilliyetOku));
            Thread1.Start();
            Thread2.Start();
        }

        #region HaberTurk Baslık Cekme
        private void HaberTurkOku()
        {
            XmlTextReader oku2 = new XmlTextReader("https://www.haberturk.com/rss/manset.xml");
            while (oku2.Read())
            {
                if (oku2.Name == "title")
                {

                    lstHaberTurk.Items.Add(oku2.ReadString());
                }

            }

        }
        #endregion

        #region Milliyet Baslik Cekme
        private void MilliyetOku()
        {
            XmlTextReader oku = new XmlTextReader("https://www.milliyet.com.tr/rss/rssnew/dunyarss.xml");

            while (oku.Read())
            {
                if (oku.Name == "title")
                {
                    lstMilliyet.Items.Add(oku.ReadString());
                }
            }
        }
        #endregion


        
        private void lstMilliyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenbaslik = lstMilliyet.SelectedItem.ToString();
            XmlTextReader oku = new XmlTextReader("https://www.milliyet.com.tr/rss/rssnew/dunyarss.xml");
            
            int sayac = 0;//sayac eğer bir ise title bulunmuştur ve ilk bulunan decription onun acıklamasıdır.Description bulunduğunda sayac tekrar sıfıra çekilir. 
            while (oku.Read())
            {
                if (sayac == 1 && oku.Name == "description")
                {
                    webBrowser1.DocumentText = oku.ReadString();
                    sayac = 0;
                }

                else if (oku.Name == "title" && secilenbaslik == oku.ReadString())
                {
                    lstMilliyet.Items.Add(oku.ReadString());
                    sayac = 1;
                }
            }
        }

        private void lstHaberTurk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenbaslik = lstHaberTurk.SelectedItem.ToString();
            XmlTextReader oku = new XmlTextReader("https://www.haberturk.com/rss/manset.xml");
            int sayac = 0;
            while (oku.Read())
            {
                if (sayac == 1 && oku.Name == "description")
                {
                    webBrowser1.DocumentText = oku.ReadString();
                    sayac = 0;
                }

                else if (oku.Name == "title" && secilenbaslik == oku.ReadString())
                {
                    lstMilliyet.Items.Add(oku.ReadString());
                    sayac = 1;
                }
            }
        }
    }
}
