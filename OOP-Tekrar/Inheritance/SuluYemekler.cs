using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar
{
    internal class SuluYemekler:Yemek
    {
        public string Icerigi { get; set; }
        public string Kivami { get; set; }


        public override string SunumSekli()
        {
            return "Limon ile";
        }
    }
}
