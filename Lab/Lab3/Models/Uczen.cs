using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Models
{
    class Uczen : Osoba
    {
        public string Szkola { get; private set; }
        public bool MozeSamWracacDoDomu { get; private set; }

        public void SetSchool(string szkola)
        {
            Szkola = szkola;
        }

        public void ChangeSchool(string nowaSzkola)
        {
            Szkola = nowaSzkola;
        }

        public void SetCanGoHomeAlone(bool mozeSam)
        {
            MozeSamWracacDoDomu = mozeSam;
        }

        public override string GetEducationInfo()
        {
            return $"Uczeń uczęszcza do szkoły: {Szkola}";
        }

        public override string CanGoAloneToHome()
        {
            if (GetAge() < 12 && !MozeSamWracacDoDomu)
            {
                return "Nie może sam wracać do domu poniżej 12 lat chyba że ma pozwolenie";
            }
            else
            {
                return "Może sam wracać do domu";
            }
        }

        public string Info()
        {
            return $"{GetFullName()} - {GetGender()} - {CanGoAloneToHome()}";
        }
    }
}
