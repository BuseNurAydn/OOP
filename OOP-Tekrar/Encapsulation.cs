using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar
{
    internal class Encapsulation
    {
         private string name;
         private int size;
       //  private int kilo;


        public int kilo { get; set; }

        public string Name
        {
            get { return name; }
        }

        public int Size
        {
            get { return size; }
            set
            {
                if (value < 200)
                {
                    size = value;
                }
            }
        }
    }
}
