using System;
namespace OldStyleApp
{
	internal class Car
	{

        //Member variable
        private string _name; //private field
		private int _hp;
		private string _color;

		public Car(string name, int hp = 0, string color="black") //constructor
		{
			_name = name;
			Console.WriteLine(name.ToUpper() + " WAS CONSTRUCTED!");
			_hp = hp;
			_color = color;
		}

		//Member method
		public void Drive()
		{
            Console.WriteLine(this._name.ToUpper() + " IS DRIVING!");
        }

		public void Stop()
		{
            Console.WriteLine(this._name.ToUpper() + " STOPPED!");
        }

		public void Details()
		{
			Console.WriteLine($"The car {_name} has {_hp} horse power and is of color {_color}.");
		}
	}
}

