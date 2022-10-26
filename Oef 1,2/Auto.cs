using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_1_2
{
    internal class Auto
    {
        private string model{ get; set; }
        private int JaarOpbouw{ get; set; }

        public Auto(string model, int JaarOpbouw)
        {
            model= model;
            JaarOpbouw = JaarOpbouw;
        }
        public override string ToString()
        {
            return "model is   " + model+ " en gebouwd in  " + JaarOpbouw;
        }



    }
}

    

