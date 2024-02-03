using System;
namespace OldStyleApp.AbstractClasses
{
	public class Sphere : Shape
	{

		public double Radius { get; set; }

		public Sphere(double radius)
		{
			this.Name = "Sphere";
			this.Radius = radius;
		}

        public override double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The Sphere has a radius of {this.Radius} and volume of {this.Volume()}");
        }
    }
}

