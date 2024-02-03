using System;
namespace OldStyleApp.AbstractClasses
{
    //we use the abstract keyword
    //Create classes where we dont want to instantiate any object, we waant to instantiate for example type of shapes, but not shapes
    abstract public class Shape 
	{
        public string Name { get; set; } = "";

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        //abstract methods are not implemented
        //a calss that inherits must implement functionality for the Volume method
        public abstract double Volume(); 
	}
}

