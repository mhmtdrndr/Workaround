using Business.Contrete;
using Entities.Concretes;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim: "Test Kullanıcısı");
            SelamVer(isim: "Deneme");
            SelamVer(isim: "ENGİN");
            SelamVer();
            int sonuc = Topla(10, 50);

            //Generic liste, koleksiyon
            List<string> sehirler = new List<string> { "Ankara", "İzmir", "İstanbul", "Bursa" };
            sehirler.Add("Trabzon");
            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİR";
            person1.DateOfBirthYear = 1980;
            person1.NationalIdenty = 0123456;

            Person person12 = new Person();
            person12.FirstName = "HACI";
            person12.LastName = "BEŞİR";
            person12.DateOfBirthYear = 1950;
            person12.NationalIdenty = 12345;


            Person person2 = new Person();
            person2.FirstName = "Nurettin";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();

            // metod örnek ---
            static void SelamVer(string isim = "isimsiz")
            {
                Console.WriteLine("Merhaba ...: " + isim);
            }
            // ---

            static int Topla(int sayi1, int sayi2) //default parametreler en son parametreye verilir.
            {
                int sonuc = sayi1 + sayi2;
                Console.WriteLine("Toplam ... : " + sonuc.ToString());
                return sonuc;
            }

        }               //pascal casing
            public class Vatandas
        {
            public String Ad { get; set; }
            public String Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }
        }


    }
}

