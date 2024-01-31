using System;
using System.Collections.Generic;
using System.Linq;
using Powtorka.Klasy;

namespace Powtorka
{
    class Program //Zadanie 2
    {
        static List<Książka> listaKsiążek = new List<Książka>();

        static void DodajKsiążkę(string tytuł, string autor, int rokWydania)
        {
            listaKsiążek.Add(new Książka(tytuł, autor, rokWydania));
        }

        static void UsuńKsiążkę(string tytuł)
        {
            Książka książka = listaKsiążek.FirstOrDefault(k => k.Tytuł == tytuł);
            if (książka != null)
                listaKsiążek.Remove(książka);
            else
                Console.WriteLine("Książka nie została znaleziona");
        }

        static void EdytujKsiążkę(string tytuł, string nowyAutor, int nowyRokWydania)
        {
            Książka książka = listaKsiążek.FirstOrDefault(k => k.Tytuł == tytuł);
            if (książka != null)
            {
                książka.Autor = nowyAutor;
                książka.RokWydania = nowyRokWydania;
                Console.WriteLine("Książka została zaktualizowana");
            }
            else
                Console.WriteLine("Książka nie została zaktualizowana");
        }

        static void WypiszKsiążkiAutora(string Autor)
        {
            var książkiAutora = listaKsiążek.Where(k => k.Autor == Autor);
            if (książkiAutora.Any())
            {
                Console.WriteLine($"Książki autora {Autor}:");
                foreach (var książka in książkiAutora)
                {
                    książka.WyświetlInformacje();
                }
            }
            else
                Console.WriteLine($"Brak książek autora {Autor}.");
        }

        static void WypiszKsiążkiRok(int rok)
        {
            var KsiążkiRok = listaKsiążek.Where(k => k.RokWydania == rok);
            if (KsiążkiRok.Any())
            {
                Console.WriteLine($"Książki wydane w roku {rok}:");
                foreach (var książka in KsiążkiRok)
                {
                    książka.WyświetlInformacje();
                }
            }
            else
                Console.WriteLine($"Brak książek wydanych w roku {rok}.");
        }

        static void Main(string[] args)
        {
            // Zadanie 1
            Książka książka1 = new Książka("Wiedźmin", "Andrzej Sapkowski", 1993);
            Książka książka2 = new Książka("Harry Potter i Kamień Filozoficzny", "J.K. Rowling", 1997);
            Książka książka3 = new Książka("W Pustyni i w Puszczy", "Henryk Sienkiewicz", 1966);

            Console.WriteLine("Informacje o książce 1:");
            książka1.WyświetlInformacje();

            Console.WriteLine("Informacje o książce 2:");
            książka2.WyświetlInformacje();

            Console.WriteLine("Informacje o książce 3:");
            książka3.WyświetlInformacje();

            DodajKsiążkę("Venom", "Aleksandra Kondraciuk", 2023);
            DodajKsiążkę("Harry Potter i Komnata Tajemnic", "J.K. Rowling", 1998);
            DodajKsiążkę("Krzyżacy", "Henryk Sienkiewicz", 1899);

            Console.WriteLine("Lista książek: ");
            foreach(var książka in listaKsiążek)
            {
                książka.WyświetlInformacje();
            }

            Console.WriteLine("Wypisanie książek danego autora: ");
            WypiszKsiążkiAutora("Andrzej Sapkowski");

            Console.WriteLine("Wypisanie książek wydanych w wybranym roku: ");
            WypiszKsiążkiRok(1899);

            Console.ReadLine();
        }
    }
}
