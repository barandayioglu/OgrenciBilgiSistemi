using DataAccessLayer.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OgrenciManager:BaseManager<Ogrenci>
    {
        Repository<Ogrenci> repository = new Repository<Ogrenci>();
        public int Delete(int id)
        {
            Ogrenci ogrenci = Find(x => x.Id == id);
            return repository.Delete(ogrenci);
            
        }
        public new void Insert(Ogrenci yeniogrenci)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = yeniogrenci.Ad;
            ogrenci.Soyad = yeniogrenci.Soyad;
            ogrenci.TCKimlikNo = yeniogrenci.TCKimlikNo;
            ogrenci.Telefon = yeniogrenci.Telefon;
            ogrenci.Adres = yeniogrenci.Adres;
            ogrenci.AldigiEgitim = yeniogrenci.AldigiEgitim;
            ogrenci.BasariDurumu = yeniogrenci.BasariDurumu;
            repository.Insert(ogrenci);

        }
        public  new void Update(Ogrenci ogrenci)
        {
            Ogrenci guncelogrenci = Find(x => x.Id == ogrenci.Id);
            
           
            guncelogrenci.Ad = ogrenci.Ad;
            guncelogrenci.Soyad = ogrenci.Soyad;
            guncelogrenci.TCKimlikNo = ogrenci.TCKimlikNo;
            guncelogrenci.Telefon = ogrenci.Telefon;
            guncelogrenci.Adres = ogrenci.Adres;
            guncelogrenci.AldigiEgitim = ogrenci.AldigiEgitim;
            guncelogrenci.BasariDurumu = ogrenci.BasariDurumu;
            
            repository.Update(guncelogrenci);
           
        }
  
    }

}


