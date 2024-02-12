

using Business.Concrete;
using Entities.Concrete;
using System.Globalization;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas = new Vatandas();

            //SelamVer(Ad: "Engin");
            //SelamVer(Ad: "Ahmet");
            //SelamVer(Ad: "Ayşe");
            //SelamVer();
            //int sonuç = Topla(50);

            //string[] ogrenciler = { "Engin", "Kerem", "Berkay" };

            //string[] ogrenciler2 = new string[3];
            //ogrenciler2[0] = "Engin";
            //ogrenciler2[1] = "Kerem";
            //ogrenciler2[2] = "Brekey";


            //ogrenciler = new string[4];  Referans Tipler Örenek (Stack heap)
            //ogrenciler[3] = "İlker";

            string[] sehirler1 = { "Ankar ", "İstanbul", "İzmir" };
            string[] sehirler2 = { "Bursa ", "Antaya", "Diyarbakır" };
            sehirler1 = sehirler2;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person = new Person();
            person.FirstName = "Engin";

            Person person1 = new Person();
            person1.FirstName = "Ömür Furkan";
            person1.LastName = "Kurt";
            person1.DateOfBirthYear = 2003;
            person1.NationalIdentity = 43909425208;

            foreach (string sheir in sehirler1)
            {
                Console.WriteLine(sheir);

            }


            //foreach (var ogrenci in ogrenciler)
            //{
            //    Console.WriteLine(ogrenci);
            //}

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i]);

            //}


            List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            yeniSehirler1.Add("Adana1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);

            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



            Console.ReadLine();
        }

        static void SelamVer(string Ad = " isimsiz")
        {
            Console.WriteLine("{0} Merhaba", Ad);
        }


        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }








        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }


        }
    }
}