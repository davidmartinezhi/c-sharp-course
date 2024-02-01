using System;

namespace OldStyleApp
{
	public class ElectricalDevice
	{
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        //Modify to string method of base class
        public override string ToString()
        {
            return string.Format($"Brand: {Brand}, Is on? {IsOn}");
        }

    }
}

