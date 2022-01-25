using System;

namespace Constructor_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi [Parametre Listesi]
            //     {
            //         Metot Komutları
            //     }
            // }

            // Erişim Belirleyiciler
            // *Public 
            // *Private
            // *Internal
            // *Protected

            Console.WriteLine("****** Çalışan 1 *********");
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 23442568, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("****** Çalışan 2 *********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Kara";
            calisan2.No = 23442569;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();

            Console.WriteLine("****** Çalışan 3 *********");
            Calisan calisan3 = new Calisan("Tunahan", "Karaçoban");
            calisan3.CalisanBilgileri();

        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan() { }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;

        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan Numarası:{0}", No);
            Console.WriteLine("Çalışan Departmanı:{0}", Departman);
        }
    }
}
