using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
        //BlogYorum sınıfı, iki farklı türdeki veriyi (Blog ve Yorumlar) tek bir modelde birleştiren bir ViewModel yapısıdır.
        //IEnumerable kullanılması, yalnızca veri okuma işlemi için idealdir ve performans açısından avantaj sağlar.
    }
}