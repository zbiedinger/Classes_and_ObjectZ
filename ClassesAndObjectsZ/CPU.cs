using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsZ
{
    class CPU
    {
        //Performs basic arithmatic, logic, controlling, and in/output operations specific by the instrucitons in the program

        //Member Variables
        public string manufacturer;
        public string name;

        //Constructor
        public CPU(string manufacturer, string name)
        {
            this.manufacturer = manufacturer;
            this.name = name;

        }
    }
}
