using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_nye_stasning
{
    internal class Car
    {
        //Instance Variables
        private int battery;
        private int meterPerBatteryProcent;
        private string _color;
        private int metersDriven;
        private int timesToDrive;

        //Get set
        public int Battery
        {
            get { return battery; }
            set { battery = value; }
        }
        public int MeterPerBatteryProcent
        {
            get { return  meterPerBatteryProcent; }
            set {  meterPerBatteryProcent = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public int MetersDriven
        {
            get { return metersDriven; }
            set { metersDriven = value; }
        }

        public int TimesToDrive
        {
            get { return timesToDrive; }
            set { timesToDrive = value; }
        }


        public void Drive()
        {
            if (battery > 0)
            {
                for (int i = 0; i < timesToDrive; i++)
                {
                    battery--;
                    metersDriven += meterPerBatteryProcent;
                }
            }
            else
            {
                Console.WriteLine("needs to be charged before driving again!");
            }
        }

        //Charge method to charge the car battery to 100%
        private void Charge()
        {
            Thread.Sleep(4000);
            battery = 100;
            metersDriven = 0;
        }
    }
}
