﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //individual - gerçek müşteri
    //Gerçek müşteri de bir müşteridir.
    class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        
    }
}
