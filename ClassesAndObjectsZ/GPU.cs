using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsZ
{
    class GPU
    {

        //handles the graphic operations of the computer (mostly 3D calculations)

        //Member Variables
        public string Manufacturer;
        public double effectiveMemory;

        //Constructor
        public GPU(string manufacturer, double effectiveMemory)
        {
            Manufacturer = manufacturer;
            this.effectiveMemory = effectiveMemory;

        }

    }
}
