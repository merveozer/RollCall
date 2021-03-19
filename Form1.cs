using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;


namespace yoklamadeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> _dersler = new Dictionary<string, string>();
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=YoklamaTakipDB;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

            DateTimePicker dtp = new DateTimePicker();
            int hour = dtp.Value.Hour;
            int minute = dtp.Value.Minute;
            timer1.Start();
            string saat = lblSaat.Text;

            _dersler.Add("1.DERS", "DERS1");
            _dersler.Add("2.DERS", "DERS2");
            _dersler.Add("3.DERS", "DERS3");
            _dersler.Add("4.DERS", "DERS4");
            _dersler.Add("5.DERS", "DERS5");
            _dersler.Add("6.DERS", "DERS6");
        }

        private void cmSinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmSinif.SelectedIndex != -1)
            {
                lbSinifListe.Items.Clear();
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("SELECT * FROM Ogrenci WHERE Sınıf='" + cmSinif.SelectedItem.ToString() + "'", baglanti);
                SqlDataReader read1 = komut1.ExecuteReader();
                while (read1.Read())
                {
                    lbSinifListe.Items.Add(read1["AdSoyad"]);
                }
                baglanti.Close();
            }
        }

        private void lbSinifListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DersKayit(string ders)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            for (int i = 0; i < lbSinifListe.Items.Count; i++)
            {
                int yoklama;
                int id = 0;
                if (lbSinifListe.GetSelected(i) == true)
                {
                    yoklama = 0;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Ogrenci WHERE AdSoyad ='" + lbSinifListe.SelectedItem.ToString() + "'", baglanti);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["ID"]);
                    }
                    baglanti.Close();
                    baglanti.Open();

                    SqlCommand komut = new SqlCommand($"Update  Yoklama  Set  {ders}= '" + yoklama + "' WHERE ID='" + id + "'", baglanti);
                    komut.ExecuteNonQuery();
                    lbSinifListe.SetSelected(i, false);
                }

            }
            baglanti.Close();
        }

        private void btGonder_Click_1(object sender, EventArgs e)
        {
            if (cmDers.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ders saati seçiminizi kontrol edin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cmDers.SelectedIndex != -1)
            {
                MessageBox.Show("Yoklamanız işlenmiştir.", "Kariyer Mimarı Koleji", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string tabloAdi = _dersler[cmDers.SelectedItem.ToString()];
                DersKayit(tabloAdi);

                switch (cmDers.SelectedItem)
                {
                    case "1.DERS":
                        DersKayit("DERS1");
                        break;
                    case "2.DERS":
                        DersKayit("DERS2");
                        break;
                    case "3.DERS":
                        DersKayit("DERS3");
                        break;
                    case "4.DERS":
                        DersKayit("DERS4");
                        break;
                    case "5.DERS":
                        DersKayit("DERS5");
                        break;
                    case "6.DERS":
                        DersKayit("DERS6");
                        MailAt();
                        break;
                }
            }
        }

        public void MailAt()
        {
                string sınıf = cmSinif.SelectedItem.ToString();       
                string konum = System.Reflection.Assembly.GetEntryAssembly().Location;
                string dosya_yolu = System.IO.Path.GetDirectoryName(konum);

                Excel ex = new Excel();
                ex.CreateNewFile();
                DateTime simdi = DateTime.Now;

                ex.SaveAs(@"" + dosya_yolu + "\\yoklama_" + simdi.ToString("dd-MM-yyyy") + ".xlsx");
                ex.Close();

                Excel tablocu = new Excel(@"" + dosya_yolu + "\\yoklama_" + simdi.ToString("dd-MM-yyyy") + ".xlsx", 1);
                tablocu.WriteToCell(0, 0, "Öğrenci Adı Soyadı");
                tablocu.WriteToCell(0, 1, "Sınıfı");
                tablocu.WriteToCell(0, 2, "Veli Telefonu");
                tablocu.WriteToCell(0, 3, "1.DERS");
                tablocu.WriteToCell(0, 4, "2.DERS");
                tablocu.WriteToCell(0, 5, "3.DERS");
                tablocu.WriteToCell(0, 6, "4.DERS");
                tablocu.WriteToCell(0, 7, "5.DERS");
                tablocu.WriteToCell(0, 8, "6.DERS");
                tablocu.WriteToCell(0, 9, "Katıldığı Ders Sayısı");

                int i = 1;
                baglanti.Open();
                SqlCommand tablo = new SqlCommand("SELECT AdSoyad, Sınıf, VeliTelefon,DERS1, DERS2, DERS3, DERS4, DERS5, DERS6, TOPLAM FROM Ogrenci INNER JOIN Yoklama ON Ogrenci.ID=Yoklama.ID WHERE SINIF='" + sınıf + "'", baglanti);
                SqlDataReader rapor = tablo.ExecuteReader();
                while (rapor.Read())
                {
                    tablocu.WriteToCell(i, 0, rapor["AdSoyad"].ToString());
                    tablocu.WriteToCell(i, 1, rapor["Sınıf"].ToString());
                    tablocu.WriteToCell(i, 2, rapor["VeliTelefon"].ToString());
                    tablocu.WriteToCell(i, 3, rapor["DERS1"].ToString());
                    tablocu.WriteToCell(i, 4, rapor["DERS2"].ToString());
                    tablocu.WriteToCell(i, 5, rapor["DERS3"].ToString());
                    tablocu.WriteToCell(i, 6, rapor["DERS4"].ToString());
                    tablocu.WriteToCell(i, 7, rapor["DERS5"].ToString());
                    tablocu.WriteToCell(i, 8, rapor["DERS6"].ToString());
                    tablocu.WriteToCell(i, 9, rapor["TOPLAM"].ToString());
                    i++;
                }
                tablocu.Save();
                tablocu.Close();
                baglanti.Close();
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;

                string konu = "yoklama" + simdi.ToString("dd-MM-yyyy");
                string icerik = sınıf + " sınıfının yoklaması ektedir.";

                sc.Credentials = new NetworkCredential("yoklama.km@gmail.com", "Yoklama1.");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("yoklama.km@gmail.com", "Kariyer Mimarı");
                mail.To.Add("yoklama.km@gmail.com");

                mail.Subject = konu;
                mail.IsBodyHtml = true;
                mail.Body = icerik;
                mail.Attachments.Add(new Attachment(@"" + dosya_yolu + "\\yoklama_" + simdi.ToString("dd-MM-yyyy") + ".xlsx"));
                sc.Send(mail);

                if (1 == 1)
                {
                    baglanti.Open();
                    SqlCommand guncelle = new SqlCommand("UPDATE Yoklama SET DERS1=1,DERS2=1,DERS3=1,DERS4=1,DERS5=1,DERS6=1", baglanti);
                    guncelle.ExecuteNonQuery();
                    baglanti.Close();
                }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void cmDers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmDers_TextChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = new DateTimePicker();
            int hour = dtp.Value.Hour;
            int minute = dtp.Value.Minute;

            if (cmDers.SelectedItem.ToString() != "6.DERS")
            {

            if (hour == 10 && (minute <= 10 || minute >= 50) || hour == 11 && (minute <= 50 && minute >= 40) || hour == 12 && (minute >= 30 && minute <= 40) ||
                hour == 13 && (minute >= 50 && minute <= 59) || hour == 14 && (minute <= 50 && minute >= 40))
            {
                btGonder.Enabled = true;
            }

            else
            {
                btGonder.Enabled = false;
            }

            }
            if (cmDers.SelectedItem.ToString() == "6.DERS")
            {
                btGonder.Enabled = true;
            }
        }
    }
}





