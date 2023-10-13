using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_lab1_asp
{
    internal class Student
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public double Medie { get; set; }
        public List<Materie> Materii; 

        public Student(string nume, string prenume, double medie, List<Materie>materii)
        {
            Materii = new List<Materie>();
            foreach (var x in materii)
            {
                Materii.Add(x);
            }
            Nume = nume;
            Prenume = prenume;
            Medie = medie;
        }

        public List<Materie> GetMaterii()
        {
            return Materii;
        }

        public void AfisMaterii()
        {
            Console.WriteLine(Nume + " " + Prenume + "\n");
            foreach (Materie m in Materii)
            {
                // You should do something with m here
                Console.WriteLine(m.nume_materie);
            }
            Console.WriteLine();
        }
    }
}
