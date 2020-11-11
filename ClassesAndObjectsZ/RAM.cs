using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsZ
{
    class RAM
    {
        //Short-term memory. It temporarily stores everthing that runs opn your pc
        //like all the services in windows, your web browser, your image editing tool, or game youre playing

        //Member Variables
        public double totalGigabytes;
        public string brand;

        //Constructor
        public RAM(double totalGigabytes, string brand)
        {
            this.totalGigabytes = totalGigabytes;
            this.brand = brand;

        }

    }
}
