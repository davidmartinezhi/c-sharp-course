using System;
namespace OldStyleApp
{
	public class Cat: Animal
	{

		public Cat(string name, int age):base(name, age)
		{
		}

        public override void Eat()
        {
            base.Eat(); //we use base keyword to use method from base class
        }

        public override void MakeSound()
        {
            Console.WriteLine("MIAU!");
        }

        public new void PolymorphismExample() //new, makes this method primary, over the superclass method
        {
            Console.WriteLine("This method is rom cat.");
        }


        public override void Play() //override is to override virtual methods from the superclass
        {
            base.Play();
        }
    }
}

