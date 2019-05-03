using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFrontEnd
{
    public class Balloon
    {
        private string colour;
        //private decimal height; This is now an autoproperty, no need for the private feild
        private decimal diameter;

        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                if(value.ToUpper() == "RED" || value.ToUpper() == "BLUE")
                {
                    colour = value;
                }
                else
                {
                    throw new DataException("Colour must be red or blue");
                }
            }
        }

        public decimal Height{ get; set; }

        public decimal Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }

    }
}
