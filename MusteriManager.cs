using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
    {
    public class MusteriManager
        {
        public void Ekle(List <Musteri>musteriListe ,Musteri musteri)
            {
            Console.WriteLine();


            }

        internal void Ekle(Musteri musteri, List<Musteri> musteriListe)
            {
            Console.WriteLine(musteri.MusteriTCkimlik +musteri.MusteriAdi + musteri.MusteriBankaSubesi + musteri.MusteriHesabindakiParaMiktari + "Müşteri Ekleme başarılı!");
            }

        internal void listele(List<Musteri> musteriListe)
            {
            foreach (var item in musteriListe)
                {
                Console.WriteLine(Musteri.Length);
                }
            }

        internal void Sil(List<Musteri> musteriListe, Musteri musteri)
            {

            Console.WriteLine(musteri.MusteriTCkimlik + musteri.MusteriAdi + musteri.MusteriBankaSubesi + musteri.MusteriTCkimlik + "Müşteri Silme başarılı!");
            musteriListe.Remove(musteri);
            }
        }
    }
