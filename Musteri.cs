using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
    {
    public class Musteri
        {
        public static Musteri Length { get; internal set; }
        public int MusteriID { get; set; }
        public long MusteriTCkimlik { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string MusteriBankaSubesi { get; set; }
        public string MusteriAdress { get; set; }
        public int MusteriKartSayisi { get; set; }
        public int MusteriHesabindakiParaMiktari { get; set; }

        }
    }
