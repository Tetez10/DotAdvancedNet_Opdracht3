using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_1_2
{
    internal class Persoon
    {
        private string Naam { get; set; }
        private int Leeftijd { get; set; }

        public Persoon(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }
        public override string ToString()
        {
            return "my name is  " + Naam + " and im " + Leeftijd;
        }



    }
}

    

