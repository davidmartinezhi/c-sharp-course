using System;
namespace OldStyleApp
{
	public class Dog: Animal
	{
		public bool IsHappy{ get; set; }

		public Dog(string name, int age): base(name, age)
		{
			IsHappy = true;
		}

        public override void Eat()
        {
            base.Eat(); //we use base keyword to use method from base class
        }

        public override void MakeSound()
        {
            Console.WriteLine("WUUF!");
        }

        public new void  PolymorphismExample() //new, makes this method primary, over the superclass method
        {
            Console.WriteLine("This method is rom dog.");
        }


        public override void Play() //override is to override virtual methods from the superclass
        {
            if (IsHappy)
            {
                base.Play();
            }
            
        }
    }
}

