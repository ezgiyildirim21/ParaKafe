using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaKafe.Data
{
    public class Siparis
    {
        public int MasaNo { get; set; }
        public SiparisDurum Durum { get; set; }
        public decimal OdenenTutar { get; set; }
        public DateTime? AcilisZamani { get; set; } = DateTime.Now;
        // bişey girmezsek eğer değer 1 ocak diye yazar. Biz soru işareti koyduğumuzda değer girilmezse null olacak direk.
        public DateTime? KapanisZamani { get; set; }
        public List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>();
        public string ToplamTutarTL 
        { 
            get
            {
                return $"{ToplamTutar():n2}₺";
            }
        }    // readonly
        public decimal ToplamTutar()
        {
            return SiparisDetaylar.Sum(x => x.Tutar());
            // her bir sipariş detayının değerlerini al ve topla demek
        }
    }
}
