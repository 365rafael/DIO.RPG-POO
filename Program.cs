using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.rpg.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas-vindas!\n");
            Console.WriteLine("--------Personagens--------");

            Guerreiro Gus = new Guerreiro("Gio", 17, 23, 15);
            Arqueiro Lamps = new Arqueiro("Lau", 19, 16, 21);
            Mago JoJo = new Mago("Jon", 15, 14, 25);

            Console.WriteLine(Gio.ToString());
            Console.WriteLine(Lau.ToString());
            Console.WriteLine(Jon.ToString());

            Console.WriteLine("");

            Console.WriteLine(Gio.Atacar(3));
            Console.WriteLine(Lau.Atacar());
            Console.WriteLine(Jon.Atacar());

            Console.ReadKey();
        }
    }
}
