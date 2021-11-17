using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaKafe.Data
{
    public enum SiparisDurum
    {
         Aktif = 0, 
        Odendi = 1, 
        Iptal = 2
            // değerleri aslında zaten yazılı ama biz açık açık yazabiliriz.
            // eğer böyle belirtirsek ama sıraları belli olur değişmez artık.
    }
}
