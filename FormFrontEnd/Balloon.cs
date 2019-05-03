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

        public string BalloonName { get; set; }

        public decimal Height{ get; set; }

        /*
         * Diameter
         * 1. Validate Colour is set prior to diameter
         *  Throw DataException
         * 2.Red Balloon Diameters cannot be greater than 12.
         *  Throw Constraint Exception
         * 3.Blue Balloon Diameter cannot be less than 5
         *  Throw Contraint Eception
         */

        public decimal Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                if(colour == string.Empty)
                {
                    throw new DataException("Colour must be chosen before the diameter can be set.");
                }
                else if(colour.ToUpper() == "RED")
                {
                    if(value <= 12)
                    {
                        diameter = value;
                    }
                    else
                    {
                        throw new ConstraintException("Diameter cannot be greater than 12 when Balloon is Red");
                    }
                }
                else if(colour.ToUpper() == "BLUE")
                {
                    if (value >= 5)
                    {
                        diameter = value;
                    }
                    else
                    {
                        throw new ConstraintException("Diameter cannot be less than 5 when Balloon is Blue");
                    }
                }

                
            }
        }

    }
}
