using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7.AccessModifier
{
    class WaterHeater
    {
        protected int temperature;
        public void SetTemperature(int temperature)
        {
            if(temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }

            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }
}
