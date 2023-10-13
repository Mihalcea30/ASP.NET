using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_lab1_asp
{
    public class Materie
    {
        public string nume_materie { get; set; }
        public int nr_credite { get; set; }
        public Materie(string nume_materie_, int nr_credite_)
        {
            nume_materie = nume_materie_;
            nr_credite = nr_credite_;
        }
    }
}
