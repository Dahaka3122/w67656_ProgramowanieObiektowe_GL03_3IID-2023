using System;
using System.Collections.Generic;
using System.Text;

namespace Powtorka.Klasy
{
    class Książka
    {
        public string Tytuł { get; set; }
        public string Autor { get; set; }
        public int RokWydania { get; set; }

        public Książka(string tytuł, string autor, int rokWydania)
        {
            Tytuł = tytuł;
            Autor = autor;
            RokWydania = rokWydania;
        }

        public void WyświetlInformacje()
        {
            Console.WriteLine($"Tytuł: {Tytuł}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Rok wydania: {RokWydania}");
            Console.WriteLine();
        }
    }
}
