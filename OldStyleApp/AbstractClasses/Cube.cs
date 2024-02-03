using System;
namespace OldStyleApp.AbstractClasses
{
	public class Cube : Shape
	{
        public double Length { get; set; }

        public Cube(double length)
        {
            this.Name = "Cube";
            this.Length = length;
        }

        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The Cube has a length of {this.Length} and volume of {this.Volume()}");
        }
    }
}

