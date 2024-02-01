using System;
namespace OldStyleApp
{
	public class Animal
	{
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        // Constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true; // Assuming the animal is hungry by default
        }

        // Method to simulate the animal making a sound
        public virtual void MakeSound() //virtual can be overriten by classes that inherit
        {
            Console.WriteLine($"{Name} makes a sound.");
        }

        // Method for the animal to eat
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating.");
                IsHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry right now.");
            }
        }

        // Method for the animal to play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
            IsHungry = true; // Playing might make the animal hungry
        }

        //Modify to string method of base class
        public override string ToString()
        {
            string hunger = IsHungry ? "" : "not ";
            return string.Format($"{Name} is {Age} years old and is {hunger}hungry");
        }
    }
}

