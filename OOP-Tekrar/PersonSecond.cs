using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar
{
    internal class PersonSecond
    {
        //C# bize kolaylık sağlar. Person sınıfının yaptığı aynı işlemi yapar

        public string name { get; set; }
        public int size { get; set; }
        public int kilo { get; set; } 

        public PersonSecond(string name, int size, int kilo)
        {
            this.name = name;
            this.size = size;
            this.kilo = kilo;
        }

       
    }
}
