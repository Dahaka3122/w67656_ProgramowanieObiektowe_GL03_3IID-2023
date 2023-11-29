using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Models
{
    class Osoba
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public string Pesel { get; private set; }

        public void SetFirstName(string imie)
        {
            Imie = imie;
        }

        public void SetLastName(string nazwisko)
        {
            Nazwisko = nazwisko;
        }

        public void SetPesel(string pesel)
        {
            Pesel = pesel;
        }

        public int GetAge()
        {
            return 0;
        }

        public string GetGender()
        {
            return "Mężczyzna";
        }

        public virtual string GetEducationInfo()
        {
            return "Brak informacji o edukacji";
        }

        public string GetFullName()
        {
            return $"{Imie} {Nazwisko}";
        }

        public virtual string CanGoAloneToHome()
        {
            return "Brak informacji o możliwości samodzielnego powrotu do domu";
        }
    }
}
