using System;
namespace OldStyleApp
{
	internal class Car
	{
		public Car() //constructor
		{
			Console.WriteLine("CAR WAS CONSTRUCTED!");
		}

		public void Drive()
		{
            Console.WriteLine("CAR IS DRIVING!");
        }

		public void Stop()
		{
            Console.WriteLine("CAR STOPED!");
        }
	}
}

