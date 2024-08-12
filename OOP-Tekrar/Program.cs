// See https://aka.ms/new-console-template for more information

namespace OOP_Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person person = new Person("Buse", 170, 60);
            //person.setName("Buse");
            //person.setSize(170);
            //person.setKilo(60);
            Console.WriteLine(person.getName());
            Console.WriteLine(person.getSize());
            Console.WriteLine(person.getKilo());
            Console.ReadKey();
            */

            /*
            PersonSecond person = new PersonSecond("Buse", 170, 80);
            Console.WriteLine(person.name);
            Console.WriteLine(person.size);
            Console.WriteLine(person.kilo);
            Console.ReadKey();
            */

            //Polymorphism
            EtYemekleri et = new EtYemekleri();
            Console.WriteLine(et.SunumSekli());   //çıktı : Mevsim yeşillikleri ile


            SuluYemekler sulu = new SuluYemekler();
            Console.WriteLine(sulu.SunumSekli());  //çıktı : Limon ile

            
        }
    }
}

