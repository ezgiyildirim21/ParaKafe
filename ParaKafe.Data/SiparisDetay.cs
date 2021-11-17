﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaKafe.Data
{
    public class SiparisDetay
    {
        public string UrunAd { get; set; }
        public decimal BirimFiyat { get; set; }
        public int Adet { get; set; }
        private string TutarTL 
        { 
            get 
            { 
                return $"{Tutar():n2}₺"; 
            } 
        }     // readonly
        public decimal Tutar()
        {
            return Adet * BirimFiyat;
        }
    }
}
