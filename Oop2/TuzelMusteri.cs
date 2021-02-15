using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Coorparate
    //miras inheritance deriz. Yani tüzel müşteri de bir müşteridir.
    class TuzelMusteri:Musteri
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
