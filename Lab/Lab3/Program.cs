using System;
using System.Collections.Generic;
using Lab3.Models;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Rectangle rectangle = new Rectangle { X = 1, Y = 2, Width = 7, Height = 4 };
            Triangle triangle = new Triangle { X = 3, Y = 4, Width = 6, Height = 4 };
            Circle circle = new Circle { X = 5, Y = 6, Width = 10, Height = 10 };

            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Add(circle);

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Nauczyciel nauczyciel = new Nauczyciel();
            nauczyciel.SetFirstName("Jan");
            nauczyciel.SetLastName("Nowak");
            nauczyciel.SetPesel("12345678901");
            nauczyciel.SetSchool("Szkoła Podstawowa Nr 1");
            nauczyciel.ChangeSchool("Szkoła Podstawowa Nr 2");
            nauczyciel.SetCanGoHomeAlone(true);
            nauczyciel.TytulNaukowy = "Mgr";

            Uczen uczen1 = new Uczen();
            uczen1.SetFirstName("Anna");
            uczen1.SetLastName("Kowalska");
            uczen1.SetPesel("98765432109");
            uczen1.SetSchool("Szkoła Podstawowa Nr 2");
            uczen1.SetCanGoHomeAlone(false);

            Uczen uczen2 = new Uczen();
            uczen2.SetFirstName("Tomasz");
            uczen2.SetLastName("Nowakowski");
            uczen2.SetPesel("11122233344");
            uczen2.SetSchool("Szkoła Podstawowa Nr 2");
            uczen2.SetCanGoHomeAlone(true);

            nauczyciel.PodwladniUczniowie.Add(uczen1);
            nauczyciel.PodwladniUczniowie.Add(uczen2);

            DateTime dateToCheck = DateTime.Now;
            nauczyciel.WhichStudentCanGoHomeAlone(dateToCheck);
        }
    }
}
