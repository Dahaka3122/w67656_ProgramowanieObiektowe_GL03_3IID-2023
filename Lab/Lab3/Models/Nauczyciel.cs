using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Models
{
    class Nauczyciel : Uczen
    {
        public string TytulNaukowy { get; internal set; }
        public List<Uczen> PodwladniUczniowie { get; internal set; }

        public Nauczyciel()
        {
            PodwladniUczniowie = new List<Uczen>();
        }

        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            Console.WriteLine($"{Szkola} Dnia: {dateToCheck.DayOfWeek}");
            Console.WriteLine($"Nauczyciel: {TytulNaukowy} {Imie} {Nazwisko}");
            Console.WriteLine("Lista studentów:");

            int lp = 1;
            foreach (var uczen in PodwladniUczniowie)
            {
                string verdict = uczen.CanGoAloneToHome();
                string reasoning = "";
                if (uczen.GetAge() < 12 && !uczen.MozeSamWracacDoDomu)
                {
                    reasoning = "Chyba że ma pozwolenie";
                }

                Console.WriteLine($"{lp}. {uczen.GetFullName()} - {uczen.GetGender()} - {verdict} {reasoning}");
                lp++;
            }
        }
    }
}
