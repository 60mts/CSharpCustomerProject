using ClassMetotDemo;
using System;
using System.Collections.Generic;

namespace KodlamaIoOdev
    {
    public class Program
        {
        static void Main(string[] args)
            {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Ersin";
            musteri1.MusteriSoyadi = "Silay";
            musteri1.MusteriBankaSubesi = "Şişli";
            musteri1.MusteriKartSayisi = 3;
            musteri1.MusteriTCkimlik = 111111;
            musteri1.MusteriHesabindakiParaMiktari = 10;
            musteri1.MusteriAdress = "Istanbul  Sisli";


            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Özcan ";
            musteri2.MusteriSoyadi = "Öner";
            musteri2.MusteriBankaSubesi = "Selçuklu";
            musteri2.MusteriKartSayisi = 1;
            musteri2.MusteriTCkimlik = 222222;
            musteri2.MusteriHesabindakiParaMiktari = 20;
            musteri2.MusteriAdress = "Konya Selcuklu";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Muhammed Tayyib";
            musteri3.MusteriSoyadi = "Şahin";
            musteri3.MusteriBankaSubesi = "Tokat Merkez";
            musteri3.MusteriKartSayisi = 5;
            musteri3.MusteriTCkimlik = 33333;
            musteri3.MusteriHesabindakiParaMiktari = 100;
            musteri3.MusteriAdress = "Esentepe Mah. Tokat Merkez";

            List<Musteri> musteriListe = new List<Musteri>();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1, musteriListe);
            musteriManager.listele(musteriListe);
            musteriManager.Sil(musteriListe,musteri1);

            musteriManager.listele(musteriListe);




            }
        }
    }
