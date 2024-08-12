using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar { 
    internal class Yemek
    {
        public double Fiyat { get; set; }
        public string Ad { get; set; }


        public virtual string SunumSekli()
             //override etmek için
        {
            return "Mevsim yeşillikleri ile";
        }
    }
}
