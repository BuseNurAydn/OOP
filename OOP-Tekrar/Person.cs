using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar
{
    internal class Person
    {
        string name;
        int size;
        int kilo;

        //constructor
        public Person(string name,int size,int kilo)
        {
            this.name = name;
            this.size = size;
            this.kilo = kilo;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name1)
        {
            this.name = name1;
        }
        public int getSize()
        {
            return size;
        }
        public void setSize(int size1)
        {
            size = size1;
        }
        public int getKilo()
        {
            return kilo;
        }
        public void setKilo(int kilo1)
        {
            kilo = kilo1;
        }
    }
}
