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

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            
        }
    }
}

