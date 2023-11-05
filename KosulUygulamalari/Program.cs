using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace KosulUygulamalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konsoldan alınan 2 notun ortalaması

            ////notlar 0 - 100 arasında olması sağlanacak yoksa hatalı not diyip çıkacak

            //Console.WriteLine("Lütfen 1. Notu giriniz");
            //double not1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. Notu Giriniz");
            //double not2 = Convert.ToDouble(Console.ReadLine());

            //if ((not1 >= 0 && not1 <= 100) && (not2 >= 0 && not2 <= 100))
            //{
            //    double ortalama = (not1 + not2) / 2;
            //    Console.WriteLine("Ortalamanız = " + ortalama);
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı not girildi");
            //}

            #endregion

            #region Sayı aralık kontrolu

            ////20-40 1. aralık
            ////60-80 2. aralık
            ////70-90 3. aralık

            //Console.WriteLine("Lütfen 1 sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi >= 20 && sayi <= 40)
            //{
            //    Console.WriteLine("Sayı 1. aralıktadır");
            //}
            //if (sayi >= 60 && sayi <= 80)
            //{
            //    Console.WriteLine("Sayı 2. aralıktadır");
            //}
            //if (sayi >= 70 && sayi <= 90)
            //{
            //    Console.WriteLine("Sayı 3. aralıktadır");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tanımlı aralıkların dışındadır");
            //}


            #endregion

            #region Sayı aralık kontrolu

            ////20-40 1. aralık
            ////60-80 2. aralık
            ////70-90 3. aralık

            //Console.WriteLine("Lütfen 1 sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi >= 20 && sayi <= 40)
            //{
            //    Console.WriteLine("Sayı 1. aralıktadır");
            //}
            //else if (sayi >= 60 && sayi <= 80)
            //{
            //    Console.WriteLine("Sayı 2. aralıktadır");
            //}
            //else if (sayi >= 70 && sayi <= 90)
            //{
            //    Console.WriteLine("Sayı 3. aralıktadır");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tanımlı aralıkların dışındadır");
            //}


            #endregion

            #region Sayı aralık kontrolu

            //Console.WriteLine("Lütfen 1 sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //string metin = "sayı ";

            //if ((sayi< 20 || sayi > 90) || (sayi>40 && sayi < 60))
            //{
            //    Console.WriteLine("Sayı Tanımlı aralıkların dışındadır");
            //}
            //else
            //{
            //    if (sayi >= 20 && sayi <= 40)
            //    {
            //        metin += "1. aralık";
            //    }
            //    if (sayi >= 60 && sayi <= 80)
            //    {
            //        metin += "2. aralık ";
            //    }
            //    if (sayi >= 70 && sayi <= 90)
            //    {
            //        metin += "3. aralık";
            //    }
            //    Console.WriteLine(metin + " içerisindedir");

            //}
            //Console.ReadKey();

            #endregion

            #region Konsoldan alınan karakter büyük ise küçük küçük ise büyük halini yazdırınız

            //Console.WriteLine("Lütfen bir karakter giriniz");
            //char karakter = Convert.ToChar(Console.ReadLine());
            //int sayisal = (int)karakter;

            ////Karakter Büyük
            //if (sayisal >= 65 && sayisal <= 90)
            //{
            //    int kucuksayisal = sayisal + 32;
            //    char kucukkarakter = (char)kucuksayisal;
            //    Console.WriteLine(kucukkarakter);
            //}
            //if (sayisal >= 97 && sayisal <= 122)
            //{
            //    int buyuksayisal = sayisal - 32;
            //    char buyukkarakter = (char)buyuksayisal;
            //    Console.WriteLine(buyukkarakter);
            //}

            #endregion

            #region Sadece Büyük Yazdırma

            //Console.WriteLine("Metin giriniz");
            //string metin = Console.ReadLine();

            //Console.WriteLine(metin.ToUpper());
            //Console.WriteLine(metin.ToLower());

            #endregion

            #region Canlı Hava Durumu

            string apikey = "e4b7070abab1899610fd58316c8d4c53";
            string link = "https://api.openweathermap.org/data/2.5/weather?q=Eskişehir&lang=tr&units=metric&mode=xml&appid="+ apikey;

            XDocument havadurumu = XDocument.Load(link);

            string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
            Console.WriteLine("Eskişehir için sıcaklık = " + havasicaklik + " Hava Durumu = " + durum);

            #endregion
        }
    }
}
