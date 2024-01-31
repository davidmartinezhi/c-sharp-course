using System;
namespace OldStyleApp
{
	public class TV : ElectricalDevice
	{

        public TV(bool isOn, string brand): base(isOn, brand)
        {
        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("watching TV");
            }
            else
            {
                Console.WriteLine("TV is off, turn it on!");
            }
        }
    }
}

