﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        // naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
