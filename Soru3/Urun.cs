using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
 //Ürün sınıfı oluşturuldu.
    internal class Urun
    {
        //dışardan erişelemeyen field tanımlandı.
        private int _urunKodu;
        private string _urunAdi;
        private double _urunFiyati;

        //fieldlere erişim için get set propertileri oluşturuldu.
        public int UrunKodu
        {
            get { return _urunKodu; }
            set { _urunKodu = value; }
        }

        public string UrunAdi
        {
            get { return _urunAdi; }
            set { _urunAdi = value; }
        }

        public double UrunFiyati
        {
            get { return _urunFiyati; }
            set { _urunFiyati = value; }
        }

    }

    //Ürün sınıfından kalıtım alarak kitap sınıfı oluşturuldu.
    class Kitap : Urun
    {
        private int _ISBN_Numarasi;
        private string _yazarAdi;
        private string _yayinEvi;

        public int ISBN_Numarasi
        {
            get { return _ISBN_Numarasi; }
            set { _ISBN_Numarasi = value; }
        }

        public string YazarAdi
        {
            get { return _yazarAdi; }
            set { _yazarAdi = value; }
        }

        public string YayinEvi
        {
            get { return _yayinEvi; }
            set { _yayinEvi = value; }
        }

        //Özellikleri gösterern metod tanımlandı....
        public int OzelliklerISBN()
        {
            return _ISBN_Numarasi;
        }

        public string OzelliklerGosterYazaradi()
        {
            return _yazarAdi;
        }

        public string OzelliklerGosterYayinEvi()
        {
            return _yayinEvi;
        }

    }

        class Telefon : Urun
        {
            private string _marka;
            private string _model;
            private string _hafiza;

            public string Marka
            {
                get { return _marka; }
                set { _marka = value; }
            }

            public string Model
            {
                get { return _model; }
                set { _model = value; }
            }

            public string Hafiza
            {
                get { return _hafiza; }
                set { _hafiza = value; }
            }

            public string OzelliklerGosterMarka()
            {
                return _marka;
            }

            public string OzelliklerGosterModel()
            {
                return _model;
            }

            public string OzelliklerGosterHafiza()
            {
                return _hafiza;
            }

        }


        class Supurge : Urun
        {
            private string _agirlik;
            private string _calismaSuresi;
            private string _gucu;

            public string Agirlik
            {
                get { return _agirlik; }
                set { _agirlik = value; }
            }

            public string CalismaSuresi
            {
                get { return _calismaSuresi; }
                set { _calismaSuresi = value; }
            }

            public string Gucu
            {
                get { return _gucu; }
                set { _gucu = value; }
            }

            public string OzelliklerGosterAgirlik()
            {
                return _agirlik;
            }

            public string OzelliklerGosterCalismaSuresi()
            {
                return _calismaSuresi;
            }

            public string OzelliklerGosterGucu()
            {
                return _gucu;
            }
           
        }            
    }
