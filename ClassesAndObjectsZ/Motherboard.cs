using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsZ
{
    class Motherboard
    {

        //It is a printed cicuit board that allows the CPU, RAM, and all other 
        //computer hardware components to communicate with each other

        //Member Variables
        public string Manufacturer;
        public RAM TemporaryMemory;
        public CPU Processor;
        public HardDrive Storage;
        public GPU Graphics;

        //Constructor
        public Motherboard(string manufacturar, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturar;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;

        }

    }
}
