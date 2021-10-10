using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        //sonarqube: kod kalitesinin kontrol edildiği site.
        static void Main(string[] args)
        {
            SelamVer(isim: "Yasin");
            SelamVer();

            int sonuc = Topla();

            //Diziler / Array

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Yasin";
            ogrenciler[1] = "Engin";

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new string[] { "Antalya", "İstanbul", "İzmir" };
            string[] sehirler2 = new string[] { "Bursa", "Antep", "Kahramanmaraş" };

            sehirler2 = sehirler1; //burada sehirler2'nin referans numarasını sehirler1'in referansına eşitlemiş oluruz.
            sehirler1[0] = "Adana"; //sehirler1'in sıfırıncı elemanı olan Antalya'yı,Adana ile değiştirdik. Sonuç adana olur.
            Console.WriteLine(sehirler2[0]);

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);
            //int veri tipleri değer tiptir. Bu yüzden sayi2'nin değerini 10'a eşitlediğimiz için sonrasında sayi1'in değerini int kısmından değiştirmediğimiz sürece etkilenmez.
            //cevap= 10

            Person person1 = new Person();
            person1.FirstName = "Yasin";
            person1.LastName = "GÜL";
            person1.DateOfBirthYear = 1994;
            person1.NationalIdentitiy = 12345678910;


            foreach (string sehir in sehirler1) 
            {
                Console.WriteLine(sehir);
            }

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

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 4)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Topla : " + sonuc);
            return sonuc;

        }
    }
}
