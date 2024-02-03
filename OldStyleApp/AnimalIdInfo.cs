using System;
namespace OldStyleApp
{
	public class AnimalIdInfo
	{
		//"Has a" relationship
		//we can have an instance of this class on our animals class

		public int IDNum { get; set; } = 0;
		public string Owner { get; set; } = "No owner";
	}
}

