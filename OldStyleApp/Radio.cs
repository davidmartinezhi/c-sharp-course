using System;
namespace OldStyleApp
{
	public class Radio : ElectricalDevice // we extend from electrical device class
	{

		public Radio(bool isOn, string brand):base(isOn, brand) //base tells to pass the params to the electrical device constructor
        {
		}

		public void ListenRadio()
		{
			if (IsOn)
			{
				Console.WriteLine("Listening to radio");
			}
			else
			{
                Console.WriteLine("Radio is off, turn it on!");
            }
		}
    }
}

