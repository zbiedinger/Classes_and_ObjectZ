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

        //Member Methods
        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            if(CheckRequirements(app, hardDrive, ram))
            {
                hardDrive.ApplicationsInHardDrive.Add(app);
            }
        }

        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            if (app.RequiredRAM < ram.totalGigabytes && app.RequiredStorage < hardDrive.availableStorage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
