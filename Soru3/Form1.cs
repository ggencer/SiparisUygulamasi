using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru3
{
    public partial class Form1 : Form
    {
        //Sınıflardan nesneler oluşturuldu...
        Kitap kitap = new Kitap();
        Telefon telefon = new Telefon();
        Supurge supurge = new Supurge();
        public Form1()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listbox seçildiğinde özellikler ekranı görünmez yapılıyor...
            ozellik1.Visible = false;
            ozellik2.Visible = false;
            ozellik3.Visible = false;
            urunKodu.Visible = true;
            urunAdi.Visible = true;
            urunFiyati.Visible = true;

            //listbox dan seçilen ürünlere göre bilgiler form ekranına yazdırılıyor..
            switch (listBox1.Text)
            {
                case "Kitap":
                    {
                        urunKodu.Text = kitap.UrunKodu.ToString();
                        urunAdi.Text = kitap.UrunAdi;
                        urunFiyati.Text = kitap.UrunFiyati.ToString() + " TL";
                        pictureBox1.Image = Image.FromFile(@"..\..\resimler\kitapresim.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case "Telefon":
                    {
                        urunKodu.Text = telefon.UrunKodu.ToString();
                        urunAdi.Text = telefon.UrunAdi;
                        urunFiyati.Text = telefon.UrunFiyati.ToString() + " TL";
                        pictureBox1.Image = Image.FromFile(@"..\..\resimler\s22.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }

                case "Süpürge":
                    {
                        urunKodu.Text = supurge.UrunKodu.ToString();
                        urunAdi.Text = supurge.UrunAdi;
                        urunFiyati.Text = supurge.UrunFiyati.ToString() + " TL";
                        pictureBox1.Image = Image.FromFile(@"..\..\resimler\robot.jpg");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                default:
                    break;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //özellikler tuşuna tekrar basıldığında özellikler ekranı açıp kapatılıyor...
            if (ozellik1.Visible == false)
            {
                ozellik1.Visible = true;
                ozellik2.Visible = true;
                ozellik3.Visible = true;
            }
            else
            {
                ozellik1.Visible = false;
                ozellik2.Visible = false;
                ozellik3.Visible = false;
            }

            //listbox da seçilen ürünün özellikleri buradan geliyor....
            switch (listBox1.Text)
            {
                case "Kitap":
                    {
                        ozellik1.Text = "ISBN Koud :" + kitap.OzelliklerISBN().ToString();
                        ozellik2.Text = "Yazar :" + kitap.OzelliklerGosterYazaradi();
                        ozellik3.Text = "Yayın Evi :" + kitap.OzelliklerGosterYayinEvi();


                        break;
                    }
                case "Telefon":
                    {
                        ozellik1.Text = "Marka :" + telefon.OzelliklerGosterMarka();
                        ozellik2.Text = "Model :" + telefon.OzelliklerGosterModel();
                        ozellik3.Text = "Hafıza :" + telefon.OzelliklerGosterHafiza();
                        break;
                    }

                case "Süpürge":
                    {
                        ozellik1.Text = "Ağırlık :" + supurge.OzelliklerGosterAgirlik();
                        ozellik2.Text = "Çalışma Süresi :" + supurge.OzelliklerGosterCalismaSuresi();
                        ozellik3.Text = "Gücü :" + supurge.OzelliklerGosterGucu();
                        break;
                    }
                default:
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Windows form ilk çalıştığında ürünlerin bilgileri ekleniyor...
            listBox1.Items.Add("Kitap");
            listBox1.Items.Add("Telefon");
            listBox1.Items.Add("Süpürge");
            kitap.UrunKodu = 12389;
            kitap.UrunAdi = "Kim korkar OOP'den";
            kitap.UrunFiyati = 49;
            kitap.ISBN_Numarasi = 1234567890;
            kitap.YazarAdi = "Gokhan Gencer";
            kitap.YayinEvi = "Gencer Yayin Evi";

            telefon.UrunKodu = 43581;
            telefon.UrunAdi = "Samsung S22";
            telefon.UrunFiyati = 22999;
            telefon.Marka = "Samsung";
            telefon.Model = "S22";
            telefon.Hafiza = "128 GB";

            supurge.UrunKodu = 56713;
            supurge.UrunAdi = "Xiaomi Mi Essential";
            supurge.UrunFiyati = 5499;
            supurge.Agirlik = "2 Kg";
            supurge.CalismaSuresi = "150 dakika";
            supurge.Gucu = "Emiş gücü 4000 Watt";




        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sepete eklenen ürünler....
            dataGridView1.Rows.Add(urunKodu.Text,urunAdi.Text,urunFiyati.Text );
        }
    }
}
