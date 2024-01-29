using System;
namespace OldStyleApp
{
	internal class Car
	{

        //Member variable
        private string _name; //private field
		private int _hp;
		private string _color;

		//Constructors
		public Car() //default
		{
			_name = "Car";
			_hp = 100;
			_color = "red";
		}

		
        public Car(string name, int hp = 0) //full specification constructor
        {
            _name = name;
            Console.WriteLine(name.ToUpper() + " WAS CONSTRUCTED!");
            _hp = hp;
            _color = "red";
        }

        public Car(string name, int hp = 0, string color="black") //partial specification
		{
			//así se utiliza el this
            this._name = name;
			Console.WriteLine(name.ToUpper() + " WAS CONSTRUCTED!");
            this._hp = hp;
            this._color = color;
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

