using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsZ
{
    class HardDrive
    {
        //stores any and all content for your computer. persistant data.

        //Member Variables
        public double totalStorage;
        public double availableStorage;
        public List<Applications> ApplicationsInHardDrive;

        //Constructor
        public HardDrive(double totalStorage, double availableStorage)
        {
            this.totalStorage = totalStorage;
            this.availableStorage = availableStorage;

        }
    }
}
