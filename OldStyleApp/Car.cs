using System;
namespace OldStyleApp
{
	internal class Car
	{

        //Member variable
		//Access modifier private
        private string _name; //private field
		private int _hp;
		private string _color;

		//public property
		//property can be used in struct and interfaces also
		public string Name {
			get { return _name; } // get accessor
			set
			{
				if (value.Trim() == "")
				{
					_name = "Default Name";
				}
				else{
                    _name = value;
                }
			} //set accessor
		}

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

